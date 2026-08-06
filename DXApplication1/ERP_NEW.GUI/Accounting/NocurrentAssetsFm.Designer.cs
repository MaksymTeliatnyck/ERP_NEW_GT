namespace ERP_NEW.GUI.Accounting
{
    partial class NocurrentAssetsFm
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NocurrentAssetsFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.monthEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMonth1 = new DevExpress.XtraScheduler.UI.RepositoryItemMonth();
            this.yearEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.searchBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addCardBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editCardBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteCardBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.transferMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.storehouseMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.noCurrentAssetsGrid = new DevExpress.XtraGrid.GridControl();
            this.noCurrentAssetsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.noCurrentAssetsMaterialsGrid = new DevExpress.XtraGrid.GridControl();
            this.noCurrentAssetsMaterialsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.monthEdit,
            this.yearEdit,
            this.searchBtn,
            this.addCardBtn,
            this.editCardBtn,
            this.deleteCardBtn,
            this.addMaterialBtn,
            this.transferMaterialBtn,
            this.storehouseMaterialBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMonth1,
            this.repositoryItemDateEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1117, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // monthEdit
            // 
            this.monthEdit.Caption = "Місяць";
            this.monthEdit.Edit = this.repositoryItemMonth1;
            this.monthEdit.EditWidth = 100;
            this.monthEdit.Id = 1;
            this.monthEdit.Name = "monthEdit";
            // 
            // repositoryItemMonth1
            // 
            this.repositoryItemMonth1.AutoHeight = false;
            this.repositoryItemMonth1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMonth1.Name = "repositoryItemMonth1";
            // 
            // yearEdit
            // 
            this.yearEdit.Caption = "Рік      ";
            this.yearEdit.Edit = this.repositoryItemDateEdit1;
            this.yearEdit.EditWidth = 100;
            this.yearEdit.Id = 2;
            this.yearEdit.Name = "yearEdit";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEdit1.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.repositoryItemDateEdit1.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            // 
            // searchBtn
            // 
            this.searchBtn.Caption = "Показати";
            this.searchBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.Glyph")));
            this.searchBtn.Id = 3;
            this.searchBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.LargeGlyph")));
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // addCardBtn
            // 
            this.addCardBtn.Caption = "Додати";
            this.addCardBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addCardBtn.Glyph")));
            this.addCardBtn.Id = 4;
            this.addCardBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addCardBtn.LargeGlyph")));
            this.addCardBtn.Name = "addCardBtn";
            this.addCardBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addCardBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCardBtn_ItemClick);
            // 
            // editCardBtn
            // 
            this.editCardBtn.Caption = "Змінити";
            this.editCardBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editCardBtn.Glyph")));
            this.editCardBtn.Id = 5;
            this.editCardBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editCardBtn.LargeGlyph")));
            this.editCardBtn.Name = "editCardBtn";
            this.editCardBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editCardBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editCardBtn_ItemClick);
            // 
            // deleteCardBtn
            // 
            this.deleteCardBtn.Caption = "Видалити";
            this.deleteCardBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteCardBtn.Glyph")));
            this.deleteCardBtn.Id = 6;
            this.deleteCardBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteCardBtn.LargeGlyph")));
            this.deleteCardBtn.Name = "deleteCardBtn";
            this.deleteCardBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteCardBtn_ItemClick);
            // 
            // addMaterialBtn
            // 
            this.addMaterialBtn.Caption = "Додати";
            this.addMaterialBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addMaterialBtn.Glyph")));
            this.addMaterialBtn.Id = 7;
            this.addMaterialBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addMaterialBtn.LargeGlyph")));
            this.addMaterialBtn.Name = "addMaterialBtn";
            this.addMaterialBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addMaterialBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addMaterialBtn_ItemClick);
            // 
            // transferMaterialBtn
            // 
            this.transferMaterialBtn.Caption = "Перемістити";
            this.transferMaterialBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("transferMaterialBtn.Glyph")));
            this.transferMaterialBtn.Id = 8;
            this.transferMaterialBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("transferMaterialBtn.LargeGlyph")));
            this.transferMaterialBtn.Name = "transferMaterialBtn";
            this.transferMaterialBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // storehouseMaterialBtn
            // 
            this.storehouseMaterialBtn.Caption = "Перемістити на склад";
            this.storehouseMaterialBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("storehouseMaterialBtn.Glyph")));
            this.storehouseMaterialBtn.Id = 9;
            this.storehouseMaterialBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("storehouseMaterialBtn.LargeGlyph")));
            this.storehouseMaterialBtn.Name = "storehouseMaterialBtn";
            this.storehouseMaterialBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.monthEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.yearEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.searchBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Період";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.addCardBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.editCardBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteCardBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Картку";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.addMaterialBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.transferMaterialBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.storehouseMaterialBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Матеріал";
            // 
            // noCurrentAssetsGrid
            // 
            this.noCurrentAssetsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noCurrentAssetsGrid.Location = new System.Drawing.Point(2, 21);
            this.noCurrentAssetsGrid.MainView = this.noCurrentAssetsGridView;
            this.noCurrentAssetsGrid.Name = "noCurrentAssetsGrid";
            this.noCurrentAssetsGrid.Size = new System.Drawing.Size(1113, 206);
            this.noCurrentAssetsGrid.TabIndex = 1;
            this.noCurrentAssetsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.noCurrentAssetsGridView});
            // 
            // noCurrentAssetsGridView
            // 
            this.noCurrentAssetsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.noCurrentAssetsGridView.GridControl = this.noCurrentAssetsGrid;
            this.noCurrentAssetsGridView.Name = "noCurrentAssetsGridView";
            this.noCurrentAssetsGridView.OptionsView.ShowGroupPanel = false;
            this.noCurrentAssetsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.noCurrentAssetsGridView_FocusedRowChanged);
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Номер картки";
            this.gridColumn5.FieldName = "DocNumber";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Дата оформлення";
            this.gridColumn1.FieldName = "DocDate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Ф.І.О";
            this.gridColumn2.FieldName = "EmployeeFullName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Професія";
            this.gridColumn3.FieldName = "Profession";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Відповідальна особа";
            this.gridColumn4.FieldName = "ResponsibleFullName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 95);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1117, 458);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.noCurrentAssetsGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1117, 229);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Картки обліку";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.noCurrentAssetsMaterialsGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1117, 224);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Засоби";
            // 
            // noCurrentAssetsMaterialsGrid
            // 
            this.noCurrentAssetsMaterialsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noCurrentAssetsMaterialsGrid.Location = new System.Drawing.Point(2, 21);
            this.noCurrentAssetsMaterialsGrid.MainView = this.noCurrentAssetsMaterialsGridView;
            this.noCurrentAssetsMaterialsGrid.MenuManager = this.ribbonControl1;
            this.noCurrentAssetsMaterialsGrid.Name = "noCurrentAssetsMaterialsGrid";
            this.noCurrentAssetsMaterialsGrid.Size = new System.Drawing.Size(1113, 201);
            this.noCurrentAssetsMaterialsGrid.TabIndex = 0;
            this.noCurrentAssetsMaterialsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.noCurrentAssetsMaterialsGridView});
            // 
            // noCurrentAssetsMaterialsGridView
            // 
            this.noCurrentAssetsMaterialsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
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
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Номенклатура";
            this.gridColumn7.FieldName = "Nomenclature";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.Caption = "Кількість";
            this.gridColumn8.FieldName = "Quantity";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.Caption = "Статус";
            this.gridColumn9.FieldName = "Status";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.Caption = "Дата отримання";
            this.gridColumn10.FieldName = "BeginDate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // NocurrentAssetsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 553);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NocurrentAssetsFm";
            this.ShowIcon = false;
            this.Text = "Необоротні засоби";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCurrentAssetsMaterialsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarEditItem monthEdit;
        private DevExpress.XtraScheduler.UI.RepositoryItemMonth repositoryItemMonth1;
        private DevExpress.XtraBars.BarEditItem yearEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl noCurrentAssetsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView noCurrentAssetsGridView;
        private DevExpress.XtraBars.BarButtonItem searchBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem addCardBtn;
        private DevExpress.XtraBars.BarButtonItem editCardBtn;
        private DevExpress.XtraBars.BarButtonItem deleteCardBtn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl noCurrentAssetsMaterialsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView noCurrentAssetsMaterialsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem addMaterialBtn;
        private DevExpress.XtraBars.BarButtonItem transferMaterialBtn;
        private DevExpress.XtraBars.BarButtonItem storehouseMaterialBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}