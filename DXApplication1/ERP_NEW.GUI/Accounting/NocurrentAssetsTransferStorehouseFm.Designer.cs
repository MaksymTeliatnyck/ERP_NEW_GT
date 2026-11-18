namespace ERP_NEW.GUI.Accounting
{
    partial class NocurrentAssetsTransferStorehouseFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.noCurrentAssetsMaterialsGrid = new DevExpress.XtraGrid.GridControl();
            this.noCurrentAssetsMaterialsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.dateTransferEdit = new DevExpress.XtraEditors.DateEdit();
            this.transferBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(608, 212);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(138, 21);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 187);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 57;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // noCurrentAssetsMaterialsGrid
            // 
            this.noCurrentAssetsMaterialsGrid.Location = new System.Drawing.Point(12, 12);
            this.noCurrentAssetsMaterialsGrid.MainView = this.noCurrentAssetsMaterialsGridView;
            this.noCurrentAssetsMaterialsGrid.Name = "noCurrentAssetsMaterialsGrid";
            this.noCurrentAssetsMaterialsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.noCurrentAssetsMaterialsGrid.Size = new System.Drawing.Size(734, 167);
            this.noCurrentAssetsMaterialsGrid.TabIndex = 56;
            this.noCurrentAssetsMaterialsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.noCurrentAssetsMaterialsGridView});
            // 
            // noCurrentAssetsMaterialsGridView
            // 
            this.noCurrentAssetsMaterialsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.noCurrentAssetsMaterialsGridView.GridControl = this.noCurrentAssetsMaterialsGrid;
            this.noCurrentAssetsMaterialsGridView.Name = "noCurrentAssetsMaterialsGridView";
            this.noCurrentAssetsMaterialsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Назва";
            this.gridColumn6.FieldName = "NomenclatureName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 182;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Номенклатура";
            this.gridColumn7.FieldName = "Nomenclature";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 182;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.Caption = "Кількість";
            this.gridColumn8.FieldName = "Quantity";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 182;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(380, 187);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(146, 13);
            this.labelControl11.TabIndex = 55;
            this.labelControl11.Text = "Дата переміщення на склад:";
            // 
            // dateTransferEdit
            // 
            this.dateTransferEdit.EditValue = null;
            this.dateTransferEdit.Location = new System.Drawing.Point(549, 184);
            this.dateTransferEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTransferEdit.MaximumSize = new System.Drawing.Size(206, 0);
            this.dateTransferEdit.MinimumSize = new System.Drawing.Size(197, 0);
            this.dateTransferEdit.Name = "dateTransferEdit";
            this.dateTransferEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTransferEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTransferEdit.Size = new System.Drawing.Size(197, 20);
            this.dateTransferEdit.TabIndex = 54;
            this.dateTransferEdit.ToolTip = "Дата створення заявки";
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule1.ErrorText = "Не вказано дату переміщення";
            compareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.dateTransferEdit, compareAgainstControlValidationRule1);
            this.dateTransferEdit.EditValueChanged += new System.EventHandler(this.dateTransferEdit_EditValueChanged);
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(484, 212);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(118, 23);
            this.transferBtn.TabIndex = 53;
            this.transferBtn.Text = "Перемістити";
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // NocurrentAssetsTransferStorehouseFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 245);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.noCurrentAssetsMaterialsGrid);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.dateTransferEdit);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.cancelBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NocurrentAssetsTransferStorehouseFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переміщення матеріалів на склад";
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraGrid.GridControl noCurrentAssetsMaterialsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView noCurrentAssetsMaterialsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit dateTransferEdit;
        private DevExpress.XtraEditors.SimpleButton transferBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}