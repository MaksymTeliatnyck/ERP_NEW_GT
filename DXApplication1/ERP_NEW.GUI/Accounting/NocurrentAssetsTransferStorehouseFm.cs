using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Infrastructure;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class NocurrentAssetsTransferStorehouseFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource noCurrentAssetsBS = new BindingSource();
        private BindingSource noCurrentAssetsMaterialsBS = new BindingSource();
        public List<NocurrentAsetsMaterialDTO> asetsMaterials = new List<NocurrentAsetsMaterialDTO>();

        private List<NocurrentAsetsMaterialDTO> noCurrentAssetsMaterialsList = new List<NocurrentAsetsMaterialDTO>();

        private UserTasksDTO userTasksDTO;

        public NocurrentAssetsTransferStorehouseFm(Utils.Operation operation, NocurrentAssetsDTO asetsMaterialCard, List<NocurrentAsetsMaterialDTO> asetsMaterials)
        {
            InitializeComponent();
            this.asetsMaterials = asetsMaterials;
            noCurrentAssetsMaterialsGrid.DataSource = asetsMaterials;

            ControlValidation();
        }

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.transferBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.transferBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void dateTransferEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (asetsMaterials.Count() == 0)
            {
                MessageBox.Show("Відсутні матеріали для переміщення", "Переміщення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = string.Join(
                Environment.NewLine,
                asetsMaterials.Select((x, index) =>
                    $"{index + 1}. {x.NomenclatureName} — кількість: {x.Quantity}")
            );

            if (MessageBox.Show("Перемістити наступні матеріали на склад:\n" + message + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItems())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool SaveItems()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            foreach (var item in asetsMaterials)
            {
                item.Status = 3;
                item.EndDate = ((DateTime?)dateTransferEdit.EditValue).Value.AddDays(-1);
                storeHouseService.NocurrentAssetsMaterialUpdate(item);
            }

            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}