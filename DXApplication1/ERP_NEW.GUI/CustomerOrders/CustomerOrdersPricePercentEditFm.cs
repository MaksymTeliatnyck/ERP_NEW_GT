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

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class CustomerOrdersPricePercentEditFm : DevExpress.XtraEditors.XtraForm
    {

        private ICustomerOrdersService customerOrdersService;

        private BindingSource customerOrdersBS = new BindingSource();

        private ObjectBase Item
        {
            get { return customerOrdersBS.Current as ObjectBase; }
            set
            {
                customerOrdersBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }
        public CustomerOrdersPricePercentEditFm(CustomerOrdersDTO model)
        {
            InitializeComponent();

            customerOrdersBS.DataSource = Item = model;
            orderNumberTBox.DataBindings.Add("EditValue", customerOrdersBS, "ExpenditureTotalPercent");

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (SaveOrder())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool SaveOrder()
        {
            ((CustomerOrdersDTO)Item).DateUpdate = DateTime.Now;

            this.Item.EndEdit();

            try
            {
                customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
                ((CustomerOrdersDTO)Item).ExpenditureTotalPercent = (int)orderNumberTBox.EditValue;
                customerOrdersService.CustomerOrderUpdate(((CustomerOrdersDTO)Item));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}