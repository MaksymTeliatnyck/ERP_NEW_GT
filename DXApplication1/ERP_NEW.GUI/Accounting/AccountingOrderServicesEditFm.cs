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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    
    public partial class AccountingOrderServicesEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrderService;
        private IStoreHouseService storeHouseService;
        private BindingSource customerOrderServiceBS = new BindingSource();
        private BindingSource ordersBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        private Utils.Operation operation;
        private ObjectBase Item
        {
            get { return customerOrderServiceBS.Current as ObjectBase; }
            set
            {
                customerOrderServiceBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AccountingOrderServicesEditFm(UserTasksDTO userTasksDTO, Utils.Operation operation, CustomerOrderServiceDTO model)
        {
            InitializeComponent();
            
            this.operation = operation;
            customerOrderServiceBS.DataSource = Item = model;
            LoadData();
            //customerOrderServiceBS
            receiptEdit.DataBindings.Add("EditValue", customerOrderServiceBS, "OrderId");
            receiptEdit.Properties.DataSource = ordersBS;
            receiptEdit.Properties.ValueMember = "ID";
            receiptEdit.Properties.DisplayMember = "RECEIPT_NUM";
            receiptEdit.Properties.NullText = "Немає данних";
            LoadDataCustomerOrders();


            if (operation == Utils.Operation.Update)
                receiptEdit.ReadOnly = true;




        }


        public void LoadData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            splashScreenManager.ShowWaitForm();
            ordersBS.DataSource = storeHouseService.GetOrders().ToList();
            splashScreenManager.CloseWaitForm();
        }

        public void LoadDataCustomerOrders()
        {
            customerOrderService = Program.kernel.Get<ICustomerOrdersService>();
            if(((CustomerOrderServiceDTO)Item).OrderId!=0)
                customerOrdersBS.DataSource = customerOrderService.GetCustomerServiceByOrderId(((CustomerOrderServiceDTO)Item).OrderId);
            customerOrderGrid.DataSource = customerOrdersBS;
        }
    }
}