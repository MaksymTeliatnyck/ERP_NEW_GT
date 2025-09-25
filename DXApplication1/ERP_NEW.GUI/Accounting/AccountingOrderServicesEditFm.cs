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
        private BindingSource customerOrdersBS = new BindingSource();
        private List<CustomerOrderServiceDTO> customerOrderServiceList = new List<CustomerOrderServiceDTO>();
        private List<CustomerOrderServiceDTO> deleteCustomerOrderServiceList = new List<CustomerOrderServiceDTO>();
        
        private int receiptId;
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

        public AccountingOrderServicesEditFm(UserTasksDTO userTasksDTO, Utils.Operation operation, int receiptId)
        {
            InitializeComponent();
            this.receiptId = receiptId;
            this.operation = operation;
            LoadData();
        }


        public void LoadData()
        {
            customerOrderService = Program.kernel.Get<ICustomerOrdersService>();
            splashScreenManager.ShowWaitForm();
            customerOrderServiceList = customerOrderService.GetCustomerServiceByOrderId(receiptId).ToList();
            customerOrderServiceBS.DataSource = customerOrderServiceList;
            customerOrderGrid.DataSource = customerOrderServiceBS;
            splashScreenManager.CloseWaitForm();
        }


        private void addServiceBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void deleteServiceBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerOrderServiceBS.Count > 0)
            {
                customerOrderGridView.PostEditor();
                customerOrderGridView.BeginDataUpdate();
                var checkItems = customerOrderServiceList.Where(t => t.Selected && t.Id != 0);
                deleteCustomerOrderServiceList.AddRange(checkItems);
                customerOrderServiceList.RemoveAll(s => s.Selected);
                customerOrderServiceBS.DataSource = customerOrderServiceList;
                customerOrderGrid.DataSource = customerOrderServiceBS;
                customerOrderGridView.EndDataUpdate();
            }
        }

        private void addCustomerOrdersBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (AccountingOrdersServiceEditFm accountingOrdersServiceEditFm = new AccountingOrdersServiceEditFm(new CustomerOrderServiceDTO()))
            {
                if (accountingOrdersServiceEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CustomerOrderServiceDTO customerOrderServiceDTO = accountingOrdersServiceEditFm.Return();

                    customerOrderGridView.BeginDataUpdate();

                    if (!customerOrderServiceList.Any(srch => srch.CustomerOrderId == customerOrderServiceDTO.CustomerOrderId && srch.ReceiptNum == ((OrdersDTO)Item).RECEIPT_NUM))
                    {
                        customerOrderServiceList.Add(new CustomerOrderServiceDTO()
                        {
                            Id = 0,
                            CustomerOrderId = customerOrderServiceDTO.CustomerOrderId,
                            CustomerOrderNumber = customerOrderServiceDTO.CustomerOrderNumber,
                            Note = customerOrderServiceDTO.Note,
                            OrderId = receiptId
                        });

                    }
                    else
                    {
                        MessageBox.Show("Такий заказ вже додано", "Повыдомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                    customerOrderServiceBS.DataSource = customerOrderServiceList;

                    customerOrderGridView.EndDataUpdate();
                }
            }

        }

        private bool AddCustomerOrderService()
        {
            customerOrderService = Program.kernel.Get<ICustomerOrdersService>();
            try
            {
                foreach (var item in customerOrderServiceBS)
                {
                    CustomerOrderServiceDTO newModel = new CustomerOrderServiceDTO();

                    newModel.OrderId = ((OrdersDTO)Item).ID;
                    newModel.Note = ((CustomerOrderServiceDTO)item).Note;
                    newModel.CustomerOrderId = ((CustomerOrderServiceDTO)item).CustomerOrderId;

                    customerOrderService.CustomerOrderServiceCreate(newModel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при записі матеріалу! Помилка " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTaskDTO, NameForm);
                return false;
            }

            return true;

        }

        private void deleteCustomerOrdersBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerOrderServiceBS.Count > 0)
            {
                customerOrderGridView.PostEditor();
                customerOrderGridView.BeginDataUpdate();
                var checkItems = customerOrderServiceList.Where(t => t.Selected && t.Id != 0);
                deleteCustomerOrderServiceList.AddRange(checkItems);
                customerOrderServiceList.RemoveAll(s => s.Selected);
                customerOrderServiceBS.DataSource = customerOrderServiceList;
                customerOrderGrid.DataSource = customerOrderServiceBS;
                customerOrderGridView.EndDataUpdate();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in customerOrderServiceList)
            {
                if (item.Id == 0)
                {
                    CustomerOrderServiceDTO newModel = new CustomerOrderServiceDTO()
                    {

                        OrderId = receiptId,
                        Note = item.Note,
                        CustomerOrderId = ((CustomerOrderServiceDTO)item).CustomerOrderId
                    };

                    customerOrderService.CustomerOrderServiceCreate(newModel);

                }
            }

            if (deleteCustomerOrderServiceList.Count > 0)
            {
                foreach (var item in deleteCustomerOrderServiceList)
                {
                    if (item.Id > 0)
                        customerOrderService.CustomerOrderServiceDelete(item.Id);
                }
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}