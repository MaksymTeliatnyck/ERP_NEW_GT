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
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.Accounting
{
    public partial class NocurrentAssetsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;

        private BindingSource nocurrentAssetsBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();
        private BindingSource responsiblePersonBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return nocurrentAssetsBS.Current as ObjectBase; }
            set
            {
                nocurrentAssetsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private List<EmployeesInfoDTO> employeesList;


        public NocurrentAssetsEditFm(Utils.Operation operation, NocurrentAssetsDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.operation = operation;

            nocurrentAssetsBS.DataSource = Item = model;

            docNumberEdit.DataBindings.Add("EditValue", nocurrentAssetsBS, "DocNumber");

            docDateEdit.DataBindings.Add("EditValue", nocurrentAssetsBS, "DocDate");

            employeesService = Program.kernel.Get<IEmployeesService>();
            employeesList = employeesService.GetEmployeesWorkingAll().ToList();


            employeeEdit.DataBindings.Add("EditValue", nocurrentAssetsBS, "EmployeeId");
            employeesBS.DataSource = employeesList;
            employeeEdit.Properties.DataSource = employeesBS;
            employeeEdit.Properties.ValueMember = "EmployeeID";
            employeeEdit.Properties.DisplayMember = "Fio";
            employeeEdit.Properties.NullText = "Немає данних";

            responsiblePersonEdit.DataBindings.Add("EditValue", nocurrentAssetsBS, "ResponsiblePersonId", true, DataSourceUpdateMode.OnPropertyChanged);
            responsiblePersonBS.DataSource = employeesList;
            responsiblePersonEdit.Properties.DataSource = responsiblePersonBS;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Add)
            {
                ((NocurrentAssetsDTO)Item).DocDate = DateTime.Now;
                ((NocurrentAssetsDTO)Item).DocNumber = GetLastNumber();
            }

            splashScreenManager.CloseWaitForm();

            dxValidationProvider.Validate();


        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            if (FindDublicate((NocurrentAssetsDTO)this.Item))
            {
                MessageBox.Show("Картка з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();

        

                if (operation == Utils.Operation.Add)
                {
                    ((NocurrentAssetsDTO)Item).Id = storeHouseService.NocurrentAssetsCreate((NocurrentAssetsDTO)Item);


                    return true;
                }
                else
                {
                    storeHouseService.NocurrentAssetsUpdate((NocurrentAssetsDTO)Item);


                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        public NocurrentAssetsDTO Return()
        {
            return ((NocurrentAssetsDTO)Item);
        }

        private bool FindDublicate(NocurrentAssetsDTO model)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            return storeHouseService.GetNocurrentAssets().Any(s => s.DocNumber == model.DocNumber && s.Id != model.Id);
        }

        private string GetLastNumber()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            var allNumberBusinessTrips = storeHouseService.GetNocurrentAssets().OrderByDescending(x => Decimal.
                Parse(x.DocNumber.Replace('/', ','))).FirstOrDefault();

            if (allNumberBusinessTrips != null)
            {
                decimal lastNumberBusinessTrips = Decimal.Parse(allNumberBusinessTrips.DocNumber.Replace('/', ','));
                allNumberBusinessTrips.DocNumber = (Math.Truncate(lastNumberBusinessTrips) + 1).ToString();
                return allNumberBusinessTrips.DocNumber;
            }
            else
            {
                return "1";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();

            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        #region Validation

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion

        private void docNumberEdit_TextChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void docDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void employeeEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("При збереженні картки виникла помилка. " + ex.Message, "Збереження картки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}