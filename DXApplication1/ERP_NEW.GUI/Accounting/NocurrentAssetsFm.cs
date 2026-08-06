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
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class NocurrentAssetsFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource noCurrentAssetsBS = new BindingSource();
        private BindingSource noCurrentAssetsMaterialsBS = new BindingSource();
        private UserTasksDTO userTasksDTO;

        public NocurrentAssetsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            LoadDataNocurrentAssets();
            this.userTasksDTO = userTasksDTO;
            AuthorizatedUserAccess();
        }

        private void AuthorizatedUserAccess()
        {
            addCardBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editCardBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteCardBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataNocurrentAssets()
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            noCurrentAssetsBS.DataSource = storeHouseService.GetNocurrentAssets();
            noCurrentAssetsBS.DataSource = storeHouseService.GetNoCurrentAssetsDetail();
            noCurrentAssetsGrid.DataSource = noCurrentAssetsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void EditNocurrentAsets(Utils.Operation operation, NocurrentAssetsDTO model)
        {
            using (NocurrentAssetsEditFm nocurrentAssetsEditFm = new NocurrentAssetsEditFm(operation, model))
            {
                if (nocurrentAssetsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    NocurrentAssetsDTO nocurrentAssetsDTO = nocurrentAssetsEditFm.Return();

                    noCurrentAssetsGridView.BeginDataUpdate();

                    LoadDataNocurrentAssets();

                    noCurrentAssetsGridView.EndDataUpdate();

                    int rowHandle = noCurrentAssetsGridView.LocateByValue("Id", nocurrentAssetsDTO.Id);
                    noCurrentAssetsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void addCardBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditNocurrentAsets(Utils.Operation.Add, new NocurrentAssetsDTO());
        }

        private void editCardBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noCurrentAssetsBS.Count > 0)
            {
                EditNocurrentAsets(Utils.Operation.Update, ((NocurrentAssetsDTO)noCurrentAssetsBS.Current));
            }
        }

        private void deleteCardBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DeleteAccountClothes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAccountClothes()
        {
            if (noCurrentAssetsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити картку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = noCurrentAssetsGridView.FocusedRowHandle - 1;
                    noCurrentAssetsGridView.BeginDataUpdate();
                    storeHouseService.NocurrentAssetsDelete(((NocurrentAssetsDTO)noCurrentAssetsBS.Current).Id);
                    LoadDataNocurrentAssets();
                    noCurrentAssetsGridView.EndDataUpdate();
                    noCurrentAssetsGridView.FocusedRowHandle = (noCurrentAssetsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void addMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (NocurrentAssetsMaterialSelectFm nocurrentAssetsMaterialSelectFm = new NocurrentAssetsMaterialSelectFm(((NocurrentAssetsDTO)noCurrentAssetsBS.Current)))
            {
                if (nocurrentAssetsMaterialSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnModel = nocurrentAssetsMaterialSelectFm.Return();
                    noCurrentAssetsGridView.BeginDataUpdate();

                    LoadDataNocurrentAssets(((NocurrentAssetsDTO)noCurrentAssetsBS.Current).Id);

                    noCurrentAssetsGridView.EndDataUpdate();

                    int rowHandle = noCurrentAssetsGridView.LocateByValue("Id", returnModel.NocurrentAsetsId);

                    noCurrentAssetsGridView.FocusedRowHandle = rowHandle;


                    //var returnModel = nocurrentAssetsMaterialSelectFm.Return();

                    //dkppCodeEdit.EditValue = returnModel.CodeDKPP;
                    //((CalcWithBuyersSpecDTO)Item).DkppId = returnModel.Id;
                }
            }
        }

        private void noCurrentAssetsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //splashScreenManager.ShowWaitForm();
            if(noCurrentAssetsBS.Count>0)
            {
                LoadDataNocurrentAssets(((NocurrentAssetsDTO)noCurrentAssetsBS.Current).Id);
            }
            //splashScreenManager.CloseWaitForm();
        }


        private void LoadDataNocurrentAssets(int nocurrentAssetId)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            noCurrentAssetsMaterialsBS.DataSource = storeHouseService.GetNocurrentsAssetsMaterialDetailById(nocurrentAssetId);
            noCurrentAssetsMaterialsGrid.DataSource = noCurrentAssetsMaterialsBS;
        }
    }
}