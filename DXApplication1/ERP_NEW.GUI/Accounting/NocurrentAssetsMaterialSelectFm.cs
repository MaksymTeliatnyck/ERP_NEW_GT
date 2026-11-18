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
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;

namespace ERP_NEW.GUI.Accounting
{
    public partial class NocurrentAssetsMaterialSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource noCurrentAssetsMaterialsBS = new BindingSource();
        private NocurrentAssetsDTO nocurrentAssets;
        public NocurrentAsetsMaterialDTO nocurrentAssetsMaterial;

        public NocurrentAssetsMaterialSelectFm(NocurrentAssetsDTO nocurrentAssets, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            LoadDataNocurrentAssetsMaterials(startDate, endDate);
            this.nocurrentAssets = nocurrentAssets;

             

        }

        private void LoadDataNocurrentAssetsMaterials(DateTime startDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            noCurrentAssetsMaterialsBS.DataSource = storeHouseService.GetNocurrentAssetsRemainsMaterial(startDate, endDate);
            noCurrentAssetsMaterialsGrid.DataSource = noCurrentAssetsMaterialsBS;

            splashScreenManager.CloseWaitForm();
        }

        public NocurrentAsetsMaterialDTO Return()
        {
            return nocurrentAssetsMaterial;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void noCurrentAssetsMaterialsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            quantityEdit.Properties.MinValue = 1;
            quantityEdit.Properties.MaxValue = (decimal)((NocurrentAssetsMaterialJournalDTO)noCurrentAssetsMaterialsBS.Current).RemainsQuantity;
            quantityEdit.Properties.IsFloatValue = false; // Set to true if decimals are allowed
            quantityEdit.Properties.EditMask = "N0";
            dateEdit.EditValue = DateTime.Now; 
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (noCurrentAssetsMaterialsBS.Count == 0)
            {
                MessageBox.Show("До документу не додана специфікація.", "Переміщення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (quantityEdit.Value == 0 || dateEdit.EditValue == null)
            {
                MessageBox.Show("Вкажіть кількість та дату переміщення.", "Переміщення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }





            if (MessageBox.Show("Перемістити "+ ((NocurrentAssetsMaterialJournalDTO)noCurrentAssetsMaterialsBS.Current).NomenclatureName +
                " в кількості "+ quantityEdit.Value + " на картку працівника " + nocurrentAssets.EmployeeFullName + " ?",
                "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
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



        private bool SaveItem()
        {
             noCurrentAssetsMaterialsBS.EndEdit();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            nocurrentAssetsMaterial = new NocurrentAsetsMaterialDTO()
                                {
                                    ParentId = null,
                                     BeginDate = ((DateTime)dateEdit.EditValue).AddDays(1 - ((DateTime)dateEdit.EditValue).Day),
                                      EndDate = null,
                                       NocurrentAsetsId = nocurrentAssets.Id,
                                        NomenclatureId = ((NocurrentAssetsMaterialJournalDTO)noCurrentAssetsMaterialsBS.Current).NomenclatureId,
                                         Percentage = null,
                                          ReceiptDate = ((NocurrentAssetsMaterialJournalDTO)noCurrentAssetsMaterialsBS.Current).OrderDate,
                                          Quantity = quantityEdit.Value,
                                           Price = (decimal)((NocurrentAssetsMaterialJournalDTO)noCurrentAssetsMaterialsBS.Current).UnitPrice* quantityEdit.Value,
                                            ReceiptId = ((NocurrentAssetsMaterialJournalDTO)noCurrentAssetsMaterialsBS.Current).ReceiptId,
                                            Status = 1
            };

            storeHouseService.NocurrentAssetsMaterialCreate(nocurrentAssetsMaterial);


            return true;
            }
        
    }
}