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

        }

        private void DeleteAccountClothes()
        {
            if (accountClothesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити картку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = accountClothesGridView.FocusedRowHandle - 1;
                    accountClothesGridView.BeginDataUpdate();
                    storeHouseService.AccountClothesDelete(((AccountClothesInfoDTO)accountClothesBS.Current).Id);
                    LoadDataAccountClothes();
                    accountClothesGridView.EndDataUpdate();
                    accountClothesGridView.FocusedRowHandle = (accountClothesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }
    }
}