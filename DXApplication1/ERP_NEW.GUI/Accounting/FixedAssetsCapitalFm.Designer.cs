namespace ERP_NEW.GUI.Accounting
{
    partial class FixedAssetsCapitalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedAssetsCapitalFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.montFixedhEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMonth1 = new DevExpress.XtraScheduler.UI.RepositoryItemMonth();
            this.yearFixedEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.fixedAssesOrderCapShowBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.monthEdit = new DevExpress.XtraBars.BarEditItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.transferBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.montFixedhEdit,
            this.yearFixedEdit,
            this.fixedAssesOrderCapShowBtn,
            this.addBtn,
            this.editBtn,
            this.barButtonItem1,
            this.transferBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemMonth1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(926, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // montFixedhEdit
            // 
            this.montFixedhEdit.Caption = "Місяць      ";
            this.montFixedhEdit.Edit = this.repositoryItemMonth1;
            this.montFixedhEdit.EditWidth = 100;
            this.montFixedhEdit.Id = 3;
            this.montFixedhEdit.Name = "montFixedhEdit";
            // 
            // repositoryItemMonth1
            // 
            this.repositoryItemMonth1.AutoHeight = false;
            this.repositoryItemMonth1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMonth1.Name = "repositoryItemMonth1";
            // 
            // yearFixedEdit
            // 
            this.yearFixedEdit.Caption = "Рік            ";
            this.yearFixedEdit.Edit = this.repositoryItemDateEdit2;
            this.yearFixedEdit.EditWidth = 100;
            this.yearFixedEdit.Id = 4;
            this.yearFixedEdit.Name = "yearFixedEdit";
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
            // fixedAssesOrderCapShowBtn
            // 
            this.fixedAssesOrderCapShowBtn.Caption = "Показати";
            this.fixedAssesOrderCapShowBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("fixedAssesOrderCapShowBtn.Glyph")));
            this.fixedAssesOrderCapShowBtn.Id = 5;
            this.fixedAssesOrderCapShowBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fixedAssesOrderCapShowBtn.LargeGlyph")));
            this.fixedAssesOrderCapShowBtn.Name = "fixedAssesOrderCapShowBtn";
            this.fixedAssesOrderCapShowBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.montFixedhEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.yearFixedEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.fixedAssesOrderCapShowBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Період";
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 95);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(926, 379);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // monthEdit
            // 
            this.monthEdit.Caption = "Місяць";
            this.monthEdit.Edit = null;
            this.monthEdit.EditWidth = 100;
            this.monthEdit.Id = 2;
            this.monthEdit.Name = "monthEdit";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.transferBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Необоротні активи";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 6;
            this.addBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBtn.LargeGlyph")));
            this.addBtn.Name = "addBtn";
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 7;
            this.editBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editBtn.LargeGlyph")));
            this.editBtn.Name = "editBtn";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Видалити";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // transferBtn
            // 
            this.transferBtn.Caption = "Перемістити";
            this.transferBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("transferBtn.Glyph")));
            this.transferBtn.Id = 9;
            this.transferBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("transferBtn.LargeGlyph")));
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.transferBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.transferBtn_ItemClick);
            // 
            // FixedAssetsCapitalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 474);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FixedAssetsCapitalFm";
            this.ShowIcon = false;
            this.Text = "Необоротні активи";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem monthEdit;
        private DevExpress.XtraBars.BarEditItem montFixedhEdit;
        private DevExpress.XtraScheduler.UI.RepositoryItemMonth repositoryItemMonth1;
        private DevExpress.XtraBars.BarEditItem yearFixedEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem fixedAssesOrderCapShowBtn;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem transferBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}