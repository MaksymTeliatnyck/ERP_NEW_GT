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

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsCapitalFm : DevExpress.XtraEditors.XtraForm
    {
        public FixedAssetsCapitalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
        }

        private void transferBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}