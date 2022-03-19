
namespace BackupRestoreSqlServer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.menuBar = new DevExpress.XtraBars.Bar();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.cbTime = new DevExpress.XtraBars.BarCheckItem();
            this.btnCreateBackupDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new BackupRestoreSqlServer.DS();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsDatabases = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.databasesTableAdapter = new BackupRestoreSqlServer.DSTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new BackupRestoreSqlServer.DSTableAdapters.TableAdapterManager();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblBackupNum = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDatabaseName = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cbDelAll = new System.Windows.Forms.CheckBox();
            this.groupDatetime = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timeStop = new DevExpress.XtraEditors.TimeEdit();
            this.dateStop = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.STTBACKUPGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsSPSttBackup = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbAdapterSttBackup = new BackupRestoreSqlServer.DSTableAdapters.SP_STT_BACKUPTableAdapter();
            this.bdsBackupDevice = new System.Windows.Forms.BindingSource(this.components);
            this.tbAdapterBackupDevice = new BackupRestoreSqlServer.DSTableAdapters.backup_devicesTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.doSqlWork = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDatetime)).BeginInit();
            this.groupDatetime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STTBACKUPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPSttBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.menuBar,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBackup,
            this.btnRestore,
            this.cbTime,
            this.btnCreateBackupDevice,
            this.btnLogout,
            this.btnThoat,
            this.btnDelBackup});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // menuBar
            // 
            this.menuBar.BarName = "Tools";
            this.menuBar.DockCol = 0;
            this.menuBar.DockRow = 0;
            this.menuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.menuBar.FloatLocation = new System.Drawing.Point(258, 135);
            this.menuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestore),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCreateBackupDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.menuBar.Text = "Tools";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu";
            this.btnBackup.Id = 0;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 1;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // cbTime
            // 
            this.cbTime.Caption = "Tham số theo thời gian";
            this.cbTime.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.cbTime.Id = 2;
            this.cbTime.Name = "cbTime";
            this.cbTime.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.cbTime_CheckedChanged);
            // 
            // btnCreateBackupDevice
            // 
            this.btnCreateBackupDevice.Caption = "Tạo device sao lưu";
            this.btnCreateBackupDevice.Id = 3;
            this.btnCreateBackupDevice.Name = "btnCreateBackupDevice";
            this.btnCreateBackupDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateBackupDevice_ItemClick);
            // 
            // btnDelBackup
            // 
            this.btnDelBackup.Caption = "Xóa backup";
            this.btnDelBackup.Enabled = false;
            this.btnDelBackup.Id = 6;
            this.btnDelBackup.Name = "btnDelBackup";
            this.btnDelBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelBackup_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 4;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(998, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(998, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 628);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(998, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 628);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.databasesGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(230, 628);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Danh sách cơ sở dữ liệu";
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.bdsDatabases;
            this.databasesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databasesGridControl.Location = new System.Drawing.Point(2, 23);
            this.databasesGridControl.MainView = this.gridView1;
            this.databasesGridControl.MenuManager = this.barManager1;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(226, 603);
            this.databasesGridControl.TabIndex = 0;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.databasesGridControl.Click += new System.EventHandler(this.databasesGridControl_Click);
            // 
            // bdsDatabases
            // 
            this.bdsDatabases.DataMember = "databases";
            this.bdsDatabases.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.gridView1.GridControl = this.databasesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colname
            // 
            this.colname.Caption = "Tên database";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BackupRestoreSqlServer.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblBackupNum);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.lblDatabaseName);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.groupDatetime);
            this.groupControl2.Controls.Add(this.STTBACKUPGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(230, 20);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(768, 628);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Tên cơ sở dữ liệu";
            // 
            // lblBackupNum
            // 
            this.lblBackupNum.Location = new System.Drawing.Point(408, 5);
            this.lblBackupNum.Name = "lblBackupNum";
            this.lblBackupNum.Size = new System.Drawing.Size(6, 13);
            this.lblBackupNum.TabIndex = 5;
            this.lblBackupNum.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(326, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Bản sao lưu thứ";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.Location = new System.Drawing.Point(126, 5);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(74, 13);
            this.lblDatabaseName.TabIndex = 3;
            this.lblDatabaseName.Text = "TÊN DATABASE";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.progressBar);
            this.groupControl3.Controls.Add(this.cbDelAll);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 274);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(764, 148);
            this.groupControl3.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(124, 93);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(517, 23);
            this.progressBar.TabIndex = 1;
            // 
            // cbDelAll
            // 
            this.cbDelAll.AutoSize = true;
            this.cbDelAll.Location = new System.Drawing.Point(124, 52);
            this.cbDelAll.Name = "cbDelAll";
            this.cbDelAll.Size = new System.Drawing.Size(303, 17);
            this.cbDelAll.TabIndex = 3;
            this.cbDelAll.Text = "Xóa tất cả bản sao lưu trong file trước khi sao lưu bản mới";
            this.cbDelAll.UseVisualStyleBackColor = true;
            // 
            // groupDatetime
            // 
            this.groupDatetime.Controls.Add(this.richTextBox1);
            this.groupDatetime.Controls.Add(this.timeStop);
            this.groupDatetime.Controls.Add(this.dateStop);
            this.groupDatetime.Controls.Add(this.label1);
            this.groupDatetime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupDatetime.Location = new System.Drawing.Point(2, 422);
            this.groupDatetime.Name = "groupDatetime";
            this.groupDatetime.Size = new System.Drawing.Size(764, 204);
            this.groupDatetime.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(124, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(517, 63);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // timeStop
            // 
            this.timeStop.EditValue = new System.DateTime(2022, 3, 18, 0, 0, 0, 0);
            this.timeStop.Location = new System.Drawing.Point(535, 59);
            this.timeStop.MenuManager = this.barManager1;
            this.timeStop.Name = "timeStop";
            this.timeStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeStop.Size = new System.Drawing.Size(106, 20);
            this.timeStop.TabIndex = 2;
            // 
            // dateStop
            // 
            this.dateStop.EditValue = null;
            this.dateStop.Location = new System.Drawing.Point(341, 59);
            this.dateStop.MenuManager = this.barManager1;
            this.dateStop.Name = "dateStop";
            this.dateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateStop.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStop.Size = new System.Drawing.Size(161, 20);
            this.dateStop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày giờ để phục hồi tới thời điểm đó";
            // 
            // STTBACKUPGridControl
            // 
            this.STTBACKUPGridControl.DataSource = this.bdsSPSttBackup;
            this.STTBACKUPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.STTBACKUPGridControl.Location = new System.Drawing.Point(2, 23);
            this.STTBACKUPGridControl.MainView = this.gridView2;
            this.STTBACKUPGridControl.MenuManager = this.barManager1;
            this.STTBACKUPGridControl.Name = "STTBACKUPGridControl";
            this.STTBACKUPGridControl.Size = new System.Drawing.Size(764, 251);
            this.STTBACKUPGridControl.TabIndex = 0;
            this.STTBACKUPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.STTBACKUPGridControl.Click += new System.EventHandler(this.STTBACKUPGridControl_Click);
            // 
            // bdsSPSttBackup
            // 
            this.bdsSPSttBackup.DataMember = "SP_STT_BACKUP";
            this.bdsSPSttBackup.DataSource = this.dS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView2.GridControl = this.STTBACKUPGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colposition
            // 
            this.colposition.Caption = "Bản sao lưu thứ #";
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            // 
            // colname1
            // 
            this.colname1.Caption = "Mô tả";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Ngày giờ sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.GroupFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colbackup_start_date.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "User sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            // 
            // tbAdapterSttBackup
            // 
            this.tbAdapterSttBackup.ClearBeforeFill = true;
            // 
            // bdsBackupDevice
            // 
            this.bdsBackupDevice.DataMember = "backup_devices";
            this.bdsBackupDevice.DataSource = this.dS;
            // 
            // tbAdapterBackupDevice
            // 
            this.tbAdapterBackupDevice.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 668);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDatetime)).EndInit();
            this.groupDatetime.ResumeLayout(false);
            this.groupDatetime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STTBACKUPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPSttBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar menuBar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarCheckItem cbTime;
        private DevExpress.XtraBars.BarButtonItem btnCreateBackupDevice;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDatabases;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DSTableAdapters.databasesTableAdapter databasesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource bdsSPSttBackup;
        private DSTableAdapters.SP_STT_BACKUPTableAdapter tbAdapterSttBackup;
        private DevExpress.XtraGrid.GridControl STTBACKUPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupDatetime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cbDelAll;
        private DevExpress.XtraEditors.TimeEdit timeStop;
        private DevExpress.XtraEditors.DateEdit dateStop;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.BindingSource bdsBackupDevice;
        private DSTableAdapters.backup_devicesTableAdapter tbAdapterBackupDevice;
        private System.Windows.Forms.ProgressBar progressBar;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblDatabaseName;
        private DevExpress.XtraEditors.LabelControl lblBackupNum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnDelBackup;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        public System.ComponentModel.BackgroundWorker doSqlWork;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}