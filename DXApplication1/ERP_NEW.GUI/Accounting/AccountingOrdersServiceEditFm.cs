using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingOrdersServiceEditFm : Form
    {

        private ICustomerOrdersService customerOrdersService;
        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource customerOrdersServiceBS = new BindingSource();

        private ObjectBase Item
        {
            get { return customerOrdersServiceBS.Current as ObjectBase; }
            set
            {
                customerOrdersServiceBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AccountingOrdersServiceEditFm(CustomerOrderServiceDTO model)
        {
            InitializeComponent();
            customerOrdersServiceBS.DataSource = Item = model;
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            orderNumberEdit.DataBindings.Add("EditValue", customerOrdersServiceBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            
            noteEdit.DataBindings.Add("EditValue", customerOrdersServiceBS, "Note", true, DataSourceUpdateMode.OnPropertyChanged);


            customerOrdersBS.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "";
        }

        private void endExpBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public CustomerOrderServiceDTO Return()
        {
            return ((CustomerOrderServiceDTO)Item);
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            ((CustomerOrderServiceDTO)Item).CustomerOrderNumber = orderNumberEdit.Text;
            dxValidationProvider1.Validate((Control)sender);
        }

        private void dxValidationProvider1_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider1.GetInvalidControls().Count == 0);
            this.endExpBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void dxValidationProvider1_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.endExpBtn.Enabled = false;
        }
    }
}
