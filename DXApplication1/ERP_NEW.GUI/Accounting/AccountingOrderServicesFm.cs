using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingOrderServicesFm : DevExpress.XtraEditors.XtraForm
    {

        private UserTasksDTO userTasksDTO;

        private ICustomerOrdersService customerOrderService;
        private BindingSource customerOrderServiceBS = new BindingSource();

        

        DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
        DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public AccountingOrderServicesFm(UserTasksDTO userTasksDTO, DateTime? firstDate = null, DateTime? lastDate = null)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;
            LoadDelivery();


        }

        public void LoadDelivery()
        {
            customerOrderService = Program.kernel.Get<ICustomerOrdersService>();
            customerOrderServiceBS.DataSource = customerOrderService.GetCustomerServiceFull();
            accountingOrderServiceGrid.DataSource = customerOrderServiceBS;
        }


        private void EditCustomerOrdersService(UserTasksDTO userTasksDTO, Utils.Operation operation, CustomerOrderServiceDTO model)
        {
            using (AccountingOrderServicesEditFm accountingOrderServicesEditFm = new AccountingOrderServicesEditFm(userTasksDTO, operation, model))
            {
                if (accountingOrderServicesEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //BusinessTripsDTO return_Id = businessTripsEditFm.Return();
                    //businessTripsGridView.BeginDataUpdate();
                    //LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
                    //businessTripsGridView.EndDataUpdate();
                    //int rowHandle = businessTripsGridView.LocateByValue("BusinessTripsID", return_Id.ID);
                    //businessTripsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addServiceBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditCustomerOrdersService(userTasksDTO, Utils.Operation.Add, new CustomerOrderServiceDTO());
        }
    }
}