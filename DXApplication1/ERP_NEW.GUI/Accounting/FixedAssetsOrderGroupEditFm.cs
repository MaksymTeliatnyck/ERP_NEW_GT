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
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderGroupEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IFixedAssetsOrderService fixedassetsOrderService;
        private BindingSource groupBS = new BindingSource();
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return groupBS.Current as ObjectBase; }
            set
            {
                groupBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public FixedAssetsOrderGroupEditFm(Utils.Operation operation, FixedAssetsGroupDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            groupBS.DataSource = Item = model;

            fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "Name");
            //fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "AmortizationFactor");
            //fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "UsefulPeriod");

            fixedAssetsGroupValidationProvider.Validate();
        }



        #region Method's

        private void LoadData()
        {
            fixedassetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            //contractorBS.DataSource = contractorService.GetContractors();
        }
         
        public long Return()
        {
            return ((FixedAssetsGroupDTO)Item).Id;
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            fixedassetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

            if (operation == Utils.Operation.Add)
            {
                ((FixedAssetsGroupDTO)Item).Id = fixedassetsOrderService.FixedAssetsOrderGroupCreate((FixedAssetsGroupDTO)Item);
            }
            else
            {
                fixedassetsOrderService.FixedAssetsOrderGroupUpdate((FixedAssetsGroupDTO)Item);
            }
            return true;
        }
        #endregion

        private void fixedAssetsGroupValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (fixedAssetsGroupValidationProvider.GetInvalidControls().Count == 0);

            this.validateLbl.Visible = !isValidate;
            this.saveBtn.Enabled = isValidate;
        }

        private void fixedAssetsGroupValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // MessageBox.Show("Не вірний номер податкової.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void fixedAssetsGroupNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsGroupValidationProvider.Validate((Control)sender);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}