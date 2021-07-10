namespace _3DMapTool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("StaticMesh");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("DynamicMesh");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Mesh", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Scene");
            this.mainPanel = new System.Windows.Forms.Panel();
            this.renderPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.InfoTabControl = new System.Windows.Forms.TabControl();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.modeTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeViewMesh = new System.Windows.Forms.TreeView();
            this.panelMeshBottom = new System.Windows.Forms.Panel();
            this.buttonMesh = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonLoadVertex = new System.Windows.Forms.Button();
            this.buttonSaveVertex = new System.Windows.Forms.Button();
            this.listBoxVertex = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.HierarchyTabControl = new System.Windows.Forms.TabControl();
            this.hierarchyPage = new System.Windows.Forms.TabPage();
            this.treeViewObject = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.InfoTabControl.SuspendLayout();
            this.infoPage.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.settingPanel.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.modeTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelMeshBottom.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.HierarchyTabControl.SuspendLayout();
            this.hierarchyPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.renderPanel);
            this.mainPanel.Controls.Add(this.statusStrip1);
            this.mainPanel.Controls.Add(this.splitter3);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.splitter2);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Controls.Add(this.menuStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1370, 561);
            this.mainPanel.TabIndex = 0;
            // 
            // renderPanel
            // 
            this.renderPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.renderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderPanel.Location = new System.Drawing.Point(352, 24);
            this.renderPanel.Name = "renderPanel";
            this.renderPanel.Size = new System.Drawing.Size(690, 515);
            this.renderPanel.TabIndex = 9;
            this.renderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.renderPanel_MouseDown);
            this.renderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.renderPanel_MouseMove);
            this.renderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.renderPanel_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Location = new System.Drawing.Point(352, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(690, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(1042, 24);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(10, 537);
            this.splitter3.TabIndex = 7;
            this.splitter3.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightPanel.Controls.Add(this.InfoTabControl);
            this.rightPanel.Controls.Add(this.splitter4);
            this.rightPanel.Controls.Add(this.settingPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1052, 24);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(318, 537);
            this.rightPanel.TabIndex = 6;
            // 
            // InfoTabControl
            // 
            this.InfoTabControl.Controls.Add(this.infoPage);
            this.InfoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTabControl.Location = new System.Drawing.Point(0, 136);
            this.InfoTabControl.Name = "InfoTabControl";
            this.InfoTabControl.SelectedIndex = 0;
            this.InfoTabControl.Size = new System.Drawing.Size(318, 401);
            this.InfoTabControl.TabIndex = 2;
            // 
            // infoPage
            // 
            this.infoPage.Controls.Add(this.groupBoxInfo);
            this.infoPage.Location = new System.Drawing.Point(4, 22);
            this.infoPage.Name = "infoPage";
            this.infoPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoPage.Size = new System.Drawing.Size(310, 375);
            this.infoPage.TabIndex = 0;
            this.infoPage.Text = "Information";
            this.infoPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.groupBox1);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInfo.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(304, 233);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown9);
            this.groupBox1.Controls.Add(this.numericUpDown8);
            this.groupBox1.Controls.Add(this.numericUpDown7);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transform";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.DecimalPlaces = 2;
            this.numericUpDown9.Location = new System.Drawing.Point(217, 99);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown9.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown9.TabIndex = 11;
            this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.numericUpDown9_ValueChanged);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.DecimalPlaces = 2;
            this.numericUpDown8.Location = new System.Drawing.Point(146, 101);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown8.TabIndex = 10;
            this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.numericUpDown8_ValueChanged);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DecimalPlaces = 2;
            this.numericUpDown7.Location = new System.Drawing.Point(75, 101);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown7.TabIndex = 9;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 2;
            this.numericUpDown6.Location = new System.Drawing.Point(217, 74);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown6.TabIndex = 8;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Location = new System.Drawing.Point(146, 74);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown5.TabIndex = 7;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Location = new System.Drawing.Point(75, 74);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown4.TabIndex = 6;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(217, 41);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(146, 41);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(75, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotation ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position";
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(0, 126);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(318, 10);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // settingPanel
            // 
            this.settingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.settingPanel.Controls.Add(this.groupBoxMode);
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingPanel.Location = new System.Drawing.Point(0, 0);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(318, 126);
            this.settingPanel.TabIndex = 0;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.comboBoxMode);
            this.groupBoxMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMode.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBoxMode.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(318, 63);
            this.groupBoxMode.TabIndex = 0;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Object",
            "NavMesh"});
            this.comboBoxMode.Location = new System.Drawing.Point(29, 22);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(263, 23);
            this.comboBoxMode.TabIndex = 0;
            this.comboBoxMode.Text = "Object";
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter2.Location = new System.Drawing.Point(342, 24);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 537);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.leftPanel.Controls.Add(this.modeTabControl);
            this.leftPanel.Controls.Add(this.splitter1);
            this.leftPanel.Controls.Add(this.HierarchyTabControl);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 24);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(342, 537);
            this.leftPanel.TabIndex = 3;
            // 
            // modeTabControl
            // 
            this.modeTabControl.Controls.Add(this.tabPage1);
            this.modeTabControl.Controls.Add(this.tabPage2);
            this.modeTabControl.Controls.Add(this.tabPage3);
            this.modeTabControl.Controls.Add(this.tabPage4);
            this.modeTabControl.Controls.Add(this.tabPage5);
            this.modeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeTabControl.Location = new System.Drawing.Point(0, 252);
            this.modeTabControl.Name = "modeTabControl";
            this.modeTabControl.SelectedIndex = 0;
            this.modeTabControl.Size = new System.Drawing.Size(342, 285);
            this.modeTabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Terrain";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeViewMesh);
            this.tabPage2.Controls.Add(this.panelMeshBottom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mesh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeViewMesh
            // 
            this.treeViewMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMesh.Location = new System.Drawing.Point(3, 3);
            this.treeViewMesh.Name = "treeViewMesh";
            treeNode9.Name = "nodeStaticMesh";
            treeNode9.NodeFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode9.Text = "StaticMesh";
            treeNode10.Name = "nodeDynamicMesh";
            treeNode10.NodeFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode10.Text = "DynamicMesh";
            treeNode11.Name = "nodeMesh";
            treeNode11.NodeFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode11.Text = "Mesh";
            this.treeViewMesh.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeViewMesh.Size = new System.Drawing.Size(328, 206);
            this.treeViewMesh.TabIndex = 2;
            // 
            // panelMeshBottom
            // 
            this.panelMeshBottom.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMeshBottom.Controls.Add(this.buttonMesh);
            this.panelMeshBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMeshBottom.Location = new System.Drawing.Point(3, 209);
            this.panelMeshBottom.Name = "panelMeshBottom";
            this.panelMeshBottom.Size = new System.Drawing.Size(328, 47);
            this.panelMeshBottom.TabIndex = 0;
            // 
            // buttonMesh
            // 
            this.buttonMesh.Location = new System.Drawing.Point(239, 9);
            this.buttonMesh.Name = "buttonMesh";
            this.buttonMesh.Size = new System.Drawing.Size(75, 23);
            this.buttonMesh.TabIndex = 0;
            this.buttonMesh.Text = "추가";
            this.buttonMesh.UseVisualStyleBackColor = true;
            this.buttonMesh.Click += new System.EventHandler(this.buttonMesh_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(334, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Camera";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(334, 259);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Effect";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonLoadVertex);
            this.tabPage5.Controls.Add(this.buttonSaveVertex);
            this.tabPage5.Controls.Add(this.listBoxVertex);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(334, 259);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "NavMesh";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonLoadVertex
            // 
            this.buttonLoadVertex.Location = new System.Drawing.Point(8, 200);
            this.buttonLoadVertex.Name = "buttonLoadVertex";
            this.buttonLoadVertex.Size = new System.Drawing.Size(120, 23);
            this.buttonLoadVertex.TabIndex = 3;
            this.buttonLoadVertex.Text = "Load";
            this.buttonLoadVertex.UseVisualStyleBackColor = true;
            this.buttonLoadVertex.Click += new System.EventHandler(this.buttonLoadVertex_Click);
            // 
            // buttonSaveVertex
            // 
            this.buttonSaveVertex.Location = new System.Drawing.Point(8, 171);
            this.buttonSaveVertex.Name = "buttonSaveVertex";
            this.buttonSaveVertex.Size = new System.Drawing.Size(120, 23);
            this.buttonSaveVertex.TabIndex = 2;
            this.buttonSaveVertex.Text = "Save";
            this.buttonSaveVertex.UseVisualStyleBackColor = true;
            this.buttonSaveVertex.Click += new System.EventHandler(this.buttonSaveVertex_Click);
            // 
            // listBoxVertex
            // 
            this.listBoxVertex.FormattingEnabled = true;
            this.listBoxVertex.ItemHeight = 12;
            this.listBoxVertex.Location = new System.Drawing.Point(8, 17);
            this.listBoxVertex.Name = "listBoxVertex";
            this.listBoxVertex.Size = new System.Drawing.Size(120, 148);
            this.listBoxVertex.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 242);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(342, 10);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // HierarchyTabControl
            // 
            this.HierarchyTabControl.Controls.Add(this.hierarchyPage);
            this.HierarchyTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HierarchyTabControl.Location = new System.Drawing.Point(0, 0);
            this.HierarchyTabControl.Name = "HierarchyTabControl";
            this.HierarchyTabControl.SelectedIndex = 0;
            this.HierarchyTabControl.Size = new System.Drawing.Size(342, 242);
            this.HierarchyTabControl.TabIndex = 2;
            // 
            // hierarchyPage
            // 
            this.hierarchyPage.Controls.Add(this.treeViewObject);
            this.hierarchyPage.Location = new System.Drawing.Point(4, 22);
            this.hierarchyPage.Name = "hierarchyPage";
            this.hierarchyPage.Padding = new System.Windows.Forms.Padding(3);
            this.hierarchyPage.Size = new System.Drawing.Size(334, 216);
            this.hierarchyPage.TabIndex = 0;
            this.hierarchyPage.Text = "Hierarchy";
            this.hierarchyPage.UseVisualStyleBackColor = true;
            // 
            // treeViewObject
            // 
            this.treeViewObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewObject.Location = new System.Drawing.Point(3, 3);
            this.treeViewObject.Name = "treeViewObject";
            treeNode12.Name = "nodeScene";
            treeNode12.NodeFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            treeNode12.Text = "Scene";
            this.treeViewObject.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeViewObject.Size = new System.Drawing.Size(328, 210);
            this.treeViewObject.TabIndex = 0;
            this.treeViewObject.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewObject_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "박경훈 맵툴";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.InfoTabControl.ResumeLayout(false);
            this.infoPage.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.settingPanel.ResumeLayout(false);
            this.groupBoxMode.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.modeTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelMeshBottom.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.HierarchyTabControl.ResumeLayout(false);
            this.hierarchyPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel renderPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TabControl InfoTabControl;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.TabControl modeTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl HierarchyTabControl;
        private System.Windows.Forms.TabPage hierarchyPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView treeViewObject;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TreeView treeViewMesh;
        private System.Windows.Forms.Panel panelMeshBottom;
        private System.Windows.Forms.Button buttonMesh;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox listBoxVertex;
        private System.Windows.Forms.Button buttonLoadVertex;
        private System.Windows.Forms.Button buttonSaveVertex;
    }
}

