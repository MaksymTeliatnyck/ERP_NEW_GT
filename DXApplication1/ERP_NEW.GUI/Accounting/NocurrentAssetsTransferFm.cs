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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;

namespace ERP_NEW.GUI.Accounting
{
    public partial class NocurrentAssetsTransferFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;

        private BindingSource nocurrentAssetsBS = new BindingSource();
        //private BindingSource employeesBS = new BindingSource();
        //private BindingSource responsiblePersonBS = new BindingSource();
        public NocurrentAssetsDTO previewAsetsMaterialCard = new NocurrentAssetsDTO();
        public List<NocurrentAsetsMaterialDTO> asetsMaterials = new List<NocurrentAsetsMaterialDTO>();


        public NocurrentAssetsTransferFm(Utils.Operation operation, NocurrentAssetsDTO asetsMaterialCard, List<NocurrentAsetsMaterialDTO> asetsMaterials)
        {
            InitializeComponent();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            previewAsetsMaterialCard = asetsMaterialCard;
            this.asetsMaterials = asetsMaterials;
            nocurrentAssetsBS.DataSource = storeHouseService.GetNoCurrentAssetsDetail().Where(x => x.Id != asetsMaterialCard.Id).ToList();
            docNumberTranferEdit.Properties.DataSource = nocurrentAssetsBS;
            docNumberTranferEdit.Properties.ValueMember = "Id";
            docNumberTranferEdit.Properties.DisplayMember = "DocNumber";
            docNumberTranferEdit.Properties.NullText = "Немає данних";

            docNumberEdit.EditValue = asetsMaterialCard.DocNumber;
            employeeEdit.EditValue = asetsMaterialCard.EmployeeFullName;
            docDateEdit.EditValue = asetsMaterialCard.DocDate;

            noCurrentAssetsMaterialsGrid.DataSource = asetsMaterials;

            ControlValidation();


        }

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void docNumberTranferEdit_EditValueChanged(object sender, EventArgs e)
        {
            NocurrentAssetsDTO current =
               docNumberTranferEdit.Properties.View.GetFocusedRow()
               as NocurrentAssetsDTO;

            if (current == null)
                return;

            employeeTransferEdit.EditValue = current.EmployeeFullName;
            docDateTransferEdit.EditValue = current.DocDate;

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

            if (MessageBox.Show("Перемістити наступні матеріали:\n"+ message + "\n На картку номер "+ docNumberTranferEdit.Text + " та відповідальну особу "+ employeeTransferEdit.EditValue+"?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                var createMaterial = new NocurrentAsetsMaterialDTO()
                {
                    BeginDate = (DateTime?)dateTransferEdit.EditValue,
                    EndDate = null,
                    NocurrentAsetsId = (int)docNumberTranferEdit.EditValue,
                    Nomenclature = item.Nomenclature,
                    NomenclatureId = item.NomenclatureId,
                    NomenclatureName = item.NomenclatureName,
                    ParentId = item.Id,
                    Percentage = null,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ReceiptId = item.ReceiptId,
                    ReceiptNum = item.ReceiptNum,
                    Status = 1
                };


                storeHouseService.NocurrentAssetsMaterialCreate(createMaterial);

                item.Status = 2;
                item.EndDate = ((DateTime?)dateTransferEdit.EditValue).Value.AddDays(-1);


                storeHouseService.NocurrentAssetsMaterialUpdate(item);
            }

            return true;
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
    }
}