namespace ERP_NEW.GUI.Accounting
{
    partial class AccountingOrderServicesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingOrderServicesFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.з = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.lasDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addServiceBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editServiceBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteServiceBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.іо = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.accountingOrderServiceGrid = new DevExpress.XtraGrid.GridControl();
            this.accountingOrderServiceGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingOrderServiceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingOrderServiceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.з,
            this.lasDateEdit,
            this.showBtn,
            this.addServiceBtn,
            this.editServiceBtn,
            this.deleteServiceBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1067, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // з
            // 
            this.з.Caption = "З     ";
            this.з.Edit = this.repositoryItemDateEdit1;
            this.з.EditWidth = 100;
            this.з.Id = 1;
            this.з.Name = "з";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // lasDateEdit
            // 
            this.lasDateEdit.Caption = "по   ";
            this.lasDateEdit.Edit = this.repositoryItemDateEdit2;
            this.lasDateEdit.EditWidth = 100;
            this.lasDateEdit.Id = 2;
            this.lasDateEdit.Name = "lasDateEdit";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 3;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.Caption = "Додати";
            this.addServiceBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addServiceBtn.Glyph")));
            this.addServiceBtn.Id = 4;
            this.addServiceBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addServiceBtn.LargeGlyph")));
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addServiceBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addServiceBtn_ItemClick);
            // 
            // editServiceBtn
            // 
            this.editServiceBtn.Caption = "Змінити";
            this.editServiceBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editServiceBtn.Glyph")));
            this.editServiceBtn.Id = 5;
            this.editServiceBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editServiceBtn.LargeGlyph")));
            this.editServiceBtn.Name = "editServiceBtn";
            this.editServiceBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // deleteServiceBtn
            // 
            this.deleteServiceBtn.Caption = "Видалити";
            this.deleteServiceBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteServiceBtn.Glyph")));
            this.deleteServiceBtn.Id = 6;
            this.deleteServiceBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteServiceBtn.LargeGlyph")));
            this.deleteServiceBtn.Name = "deleteServiceBtn";
            this.deleteServiceBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.іо,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // іо
            // 
            this.іо.ItemLinks.Add(this.з);
            this.іо.ItemLinks.Add(this.lasDateEdit);
            this.іо.ItemLinks.Add(this.showBtn);
            this.іо.Name = "іо";
            this.іо.Text = "Період надходжень";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addServiceBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editServiceBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteServiceBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Керування послугами";
            // 
            // accountingOrderServiceGrid
            // 
            this.accountingOrderServiceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountingOrderServiceGrid.Location = new System.Drawing.Point(0, 95);
            this.accountingOrderServiceGrid.MainView = this.accountingOrderServiceGridView;
            this.accountingOrderServiceGrid.Name = "accountingOrderServiceGrid";
            this.accountingOrderServiceGrid.Size = new System.Drawing.Size(1067, 434);
            this.accountingOrderServiceGrid.TabIndex = 1;
            this.accountingOrderServiceGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accountingOrderServiceGridView});
            // 
            // accountingOrderServiceGridView
            // 
            this.accountingOrderServiceGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.accountingOrderServiceGridView.GridControl = this.accountingOrderServiceGrid;
            this.accountingOrderServiceGridView.Name = "accountingOrderServiceGridView";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Надходження";
            this.gridColumn1.FieldName = "ReceiptNum";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Номер заказу";
            this.gridColumn2.FieldName = "CustomerOrderNumber";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Примітка";
            this.gridColumn3.FieldName = "Note";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // firstDateEdit
            // 
            this.firstDateEdit.Caption = "З  ";
            this.firstDateEdit.Edit = null;
            this.firstDateEdit.EditWidth = 100;
            this.firstDateEdit.Id = 6;
            this.firstDateEdit.Name = "firstDateEdit";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Дата надходження";
            this.gridColumn4.FieldName = "ReceiptDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // AccountingOrderServicesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 529);
            this.Controls.Add(this.accountingOrderServiceGrid);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountingOrderServicesFm";
            this.ShowIcon = false;
            this.Text = "Послуги";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingOrderServiceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingOrderServiceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup іо;
        private DevExpress.XtraGrid.GridControl accountingOrderServiceGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView accountingOrderServiceGridView;
        private DevExpress.XtraBars.BarEditItem firstDateEdit;
        private DevExpress.XtraBars.BarEditItem з;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem lasDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.BarButtonItem addServiceBtn;
        private DevExpress.XtraBars.BarButtonItem editServiceBtn;
        private DevExpress.XtraBars.BarButtonItem deleteServiceBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}