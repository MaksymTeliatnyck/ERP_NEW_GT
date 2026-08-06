namespace ERP_NEW.GUI.Accounting
{
    partial class NocurrentAssetsMaterialSelectFm
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
            this.noCurrentAssetsMaterialsGrid = new DevExpress.XtraGrid.GridControl();
            this.noCurrentAssetsMaterialsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainsQuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.quantityEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // noCurrentAssetsMaterialsGrid
            // 
            this.noCurrentAssetsMaterialsGrid.Location = new System.Drawing.Point(-2, 1);
            this.noCurrentAssetsMaterialsGrid.MainView = this.noCurrentAssetsMaterialsGridView;
            this.noCurrentAssetsMaterialsGrid.Name = "noCurrentAssetsMaterialsGrid";
            this.noCurrentAssetsMaterialsGrid.Size = new System.Drawing.Size(1246, 429);
            this.noCurrentAssetsMaterialsGrid.TabIndex = 0;
            this.noCurrentAssetsMaterialsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.noCurrentAssetsMaterialsGridView});
            // 
            // noCurrentAssetsMaterialsGridView
            // 
            this.noCurrentAssetsMaterialsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureNameCol,
            this.nomenclatureCol,
            this.orderDateCol,
            this.receiptNumCol,
            this.remainsQuantityCol});
            this.noCurrentAssetsMaterialsGridView.GridControl = this.noCurrentAssetsMaterialsGrid;
            this.noCurrentAssetsMaterialsGridView.Name = "noCurrentAssetsMaterialsGridView";
            this.noCurrentAssetsMaterialsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.noCurrentAssetsMaterialsGridView_FocusedRowChanged);
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.Caption = "Найменування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.VisibleIndex = 0;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.Caption = "Ном. номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 1;
            // 
            // orderDateCol
            // 
            this.orderDateCol.Caption = "Дата Надходження";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 2;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.Caption = "Номер надходження";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 3;
            // 
            // remainsQuantityCol
            // 
            this.remainsQuantityCol.Caption = "Залишок";
            this.remainsQuantityCol.FieldName = "RemainsQuantity";
            this.remainsQuantityCol.Name = "remainsQuantityCol";
            this.remainsQuantityCol.OptionsColumn.AllowEdit = false;
            this.remainsQuantityCol.OptionsColumn.AllowFocus = false;
            this.remainsQuantityCol.Visible = true;
            this.remainsQuantityCol.VisibleIndex = 4;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1156, 447);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Відміна";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1076, 447);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 21);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(598, 451);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Кількість";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(900, 448);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(150, 20);
            this.dateEdit.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(857, 451);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Дата";
            // 
            // quantityEdit
            // 
            this.quantityEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantityEdit.Location = new System.Drawing.Point(662, 448);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quantityEdit.Size = new System.Drawing.Size(155, 20);
            this.quantityEdit.TabIndex = 23;
            // 
            // NocurrentAssetsMaterialSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 487);
            this.Controls.Add(this.quantityEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.noCurrentAssetsMaterialsGrid);
            this.Name = "NocurrentAssetsMaterialSelectFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір матеріалу";
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl noCurrentAssetsMaterialsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView noCurrentAssetsMaterialsGridView;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn remainsQuantityCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit quantityEdit;
    }
}