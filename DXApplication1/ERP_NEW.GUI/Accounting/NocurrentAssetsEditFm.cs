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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;

namespace ERP_NEW.GUI.Accounting
{
    public partial class NocurrentAssetsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;

        private BindingSource nocurrentAssetsBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();
        private BindingSource responsiblePersonBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return nocurrentAssetsBS.Current as ObjectBase; }
            set
            {
                nocurrentAssetsBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public NocurrentAssetsEditFm(Utils.Operation operation, NocurrentAssetsDTO model)
        {
            InitializeComponent();
        }

        public NocurrentAssetsDTO Return()
        {
            return ((NocurrentAssetsDTO)Item);
        }
    }
}