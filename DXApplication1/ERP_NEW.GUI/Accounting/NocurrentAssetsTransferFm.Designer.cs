namespace ERP_NEW.GUI.Accounting
{
    partial class NocurrentAssetsTransferFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.employeeEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.docDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.docNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.employeeTransferEdit = new DevExpress.XtraEditors.TextEdit();
            this.docNumberTranferEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.docNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeeNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.docDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.docDateTransferEdit = new DevExpress.XtraEditors.DateEdit();
            this.transferBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dateTransferEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.noCurrentAssetsMaterialsGrid = new DevExpress.XtraGrid.GridControl();
            this.noCurrentAssetsMaterialsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTransferEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNumberTranferEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateTransferEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateTransferEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.employeeEdit);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.docDateEdit);
            this.groupControl3.Controls.Add(this.docNumberEdit);
            this.groupControl3.Location = new System.Drawing.Point(12, 11);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(734, 111);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Інформація про облікову картку з якої виконується переміщення";
            // 
            // employeeEdit
            // 
            this.employeeEdit.Location = new System.Drawing.Point(190, 62);
            this.employeeEdit.Name = "employeeEdit";
            this.employeeEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.employeeEdit.Properties.Appearance.Options.UseFont = true;
            this.employeeEdit.Properties.ReadOnly = true;
            this.employeeEdit.Size = new System.Drawing.Size(383, 20);
            this.employeeEdit.TabIndex = 56;
            this.employeeEdit.ToolTip = "Номер заявки";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 13);
            this.labelControl2.TabIndex = 53;
            this.labelControl2.Text = "Підзвітна особа (робітник):";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Номер картки:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(281, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Дата видачі:";
            // 
            // docDateEdit
            // 
            this.docDateEdit.EditValue = null;
            this.docDateEdit.Location = new System.Drawing.Point(376, 30);
            this.docDateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docDateEdit.MaximumSize = new System.Drawing.Size(206, 0);
            this.docDateEdit.MinimumSize = new System.Drawing.Size(197, 0);
            this.docDateEdit.Name = "docDateEdit";
            this.docDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.docDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.docDateEdit.Properties.ReadOnly = true;
            this.docDateEdit.Size = new System.Drawing.Size(197, 20);
            this.docDateEdit.TabIndex = 2;
            this.docDateEdit.ToolTip = "Дата створення заявки";
            // 
            // docNumberEdit
            // 
            this.docNumberEdit.Location = new System.Drawing.Point(107, 30);
            this.docNumberEdit.Name = "docNumberEdit";
            this.docNumberEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.docNumberEdit.Properties.Appearance.Options.UseFont = true;
            this.docNumberEdit.Properties.ReadOnly = true;
            this.docNumberEdit.Size = new System.Drawing.Size(157, 20);
            this.docNumberEdit.TabIndex = 0;
            this.docNumberEdit.ToolTip = "Номер заявки";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.employeeTransferEdit);
            this.groupControl1.Controls.Add(this.docNumberTranferEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.docDateTransferEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 136);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(734, 111);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Інформація про облікову картку на яку виконується переміщення";
            // 
            // employeeTransferEdit
            // 
            this.employeeTransferEdit.Location = new System.Drawing.Point(190, 62);
            this.employeeTransferEdit.Name = "employeeTransferEdit";
            this.employeeTransferEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.employeeTransferEdit.Properties.Appearance.Options.UseFont = true;
            this.employeeTransferEdit.Properties.ReadOnly = true;
            this.employeeTransferEdit.Size = new System.Drawing.Size(383, 20);
            this.employeeTransferEdit.TabIndex = 55;
            this.employeeTransferEdit.ToolTip = "Номер заявки";
            // 
            // docNumberTranferEdit
            // 
            this.docNumberTranferEdit.Location = new System.Drawing.Point(107, 34);
            this.docNumberTranferEdit.Name = "docNumberTranferEdit";
            this.docNumberTranferEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.docNumberTranferEdit.Properties.View = this.gridLookUpEdit2View;
            this.docNumberTranferEdit.Size = new System.Drawing.Size(111, 20);
            this.docNumberTranferEdit.TabIndex = 54;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Не вказано картку";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = 0;
            this.dxValidationProvider.SetValidationRule(this.docNumberTranferEdit, conditionValidationRule1);
            this.docNumberTranferEdit.EditValueChanged += new System.EventHandler(this.docNumberTranferEdit_EditValueChanged);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.docNumberCol,
            this.employeeNameCol,
            this.docDateCol});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // docNumberCol
            // 
            this.docNumberCol.Caption = "Номер картки";
            this.docNumberCol.FieldName = "DocNumber";
            this.docNumberCol.Name = "docNumberCol";
            this.docNumberCol.Visible = true;
            this.docNumberCol.VisibleIndex = 0;
            // 
            // employeeNameCol
            // 
            this.employeeNameCol.Caption = "Відповідальна особа";
            this.employeeNameCol.FieldName = "EmployeeFullName";
            this.employeeNameCol.Name = "employeeNameCol";
            this.employeeNameCol.Visible = true;
            this.employeeNameCol.VisibleIndex = 1;
            // 
            // docDateCol
            // 
            this.docDateCol.Caption = "Дата видачі";
            this.docDateCol.FieldName = "DocDate";
            this.docDateCol.Name = "docDateCol";
            this.docDateCol.Visible = true;
            this.docDateCol.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(138, 13);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Підзвітна особа (робітник):";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 37);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "Номер картки:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(281, 33);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 49;
            this.labelControl6.Text = "Дата видачі:";
            // 
            // docDateTransferEdit
            // 
            this.docDateTransferEdit.EditValue = null;
            this.docDateTransferEdit.Location = new System.Drawing.Point(376, 30);
            this.docDateTransferEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docDateTransferEdit.MaximumSize = new System.Drawing.Size(206, 0);
            this.docDateTransferEdit.MinimumSize = new System.Drawing.Size(197, 0);
            this.docDateTransferEdit.Name = "docDateTransferEdit";
            this.docDateTransferEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.docDateTransferEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.docDateTransferEdit.Properties.ReadOnly = true;
            this.docDateTransferEdit.Size = new System.Drawing.Size(197, 20);
            this.docDateTransferEdit.TabIndex = 2;
            this.docDateTransferEdit.ToolTip = "Дата створення заявки";
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(645, 433);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(101, 23);
            this.transferBtn.TabIndex = 6;
            this.transferBtn.Text = "Перемістити";
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // dateTransferEdit
            // 
            this.dateTransferEdit.EditValue = null;
            this.dateTransferEdit.Location = new System.Drawing.Point(442, 435);
            this.dateTransferEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTransferEdit.MaximumSize = new System.Drawing.Size(206, 0);
            this.dateTransferEdit.MinimumSize = new System.Drawing.Size(197, 0);
            this.dateTransferEdit.Name = "dateTransferEdit";
            this.dateTransferEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTransferEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTransferEdit.Size = new System.Drawing.Size(197, 20);
            this.dateTransferEdit.TabIndex = 7;
            this.dateTransferEdit.ToolTip = "Дата створення заявки";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не вказана дата";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.dateTransferEdit, conditionValidationRule2);
            this.dateTransferEdit.EditValueChanged += new System.EventHandler(this.dateTransferEdit_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(335, 438);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(98, 13);
            this.labelControl11.TabIndex = 50;
            this.labelControl11.Text = "Дата переміщення:";
            // 
            // noCurrentAssetsMaterialsGrid
            // 
            this.noCurrentAssetsMaterialsGrid.Location = new System.Drawing.Point(12, 254);
            this.noCurrentAssetsMaterialsGrid.MainView = this.noCurrentAssetsMaterialsGridView;
            this.noCurrentAssetsMaterialsGrid.Name = "noCurrentAssetsMaterialsGrid";
            this.noCurrentAssetsMaterialsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.noCurrentAssetsMaterialsGrid.Size = new System.Drawing.Size(734, 167);
            this.noCurrentAssetsMaterialsGrid.TabIndex = 51;
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
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 438);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 52;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // NocurrentAssetsTransferFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 467);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.noCurrentAssetsMaterialsGrid);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.dateTransferEdit);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NocurrentAssetsTransferFm";
            this.ShowIcon = false;
            this.Text = "Переміщення матеріалу";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTransferEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNumberTranferEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateTransferEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDateTransferEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTransferEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit docDateEdit;
        private DevExpress.XtraEditors.TextEdit docNumberEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GridLookUpEdit docNumberTranferEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit docDateTransferEdit;
        private DevExpress.XtraEditors.SimpleButton transferBtn;
        private DevExpress.XtraEditors.DateEdit dateTransferEdit;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit employeeEdit;
        private DevExpress.XtraEditors.TextEdit employeeTransferEdit;
        private DevExpress.XtraGrid.Columns.GridColumn docNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn employeeNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn docDateCol;
        private DevExpress.XtraGrid.GridControl noCurrentAssetsMaterialsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView noCurrentAssetsMaterialsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.LabelControl validateLbl;
    }
}