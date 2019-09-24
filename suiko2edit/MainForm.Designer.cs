namespace suiko2edit
{
	partial class MainForm
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
            this.m_mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openISOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMaxAll = new System.Windows.Forms.Button();
            this.m_brightAff = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.m_darkAff = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.m_resurrAff = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.m_lightningAff = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.m_earthAff = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.m_windAff = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.m_waterAff = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.m_fireAff = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m_rawData = new System.Windows.Forms.Label();
            this.m_lhLev = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.m_rhLev = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.m_headLev = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.m_hpGr = new System.Windows.Forms.ComboBox();
            this.m_luckGr = new System.Windows.Forms.ComboBox();
            this.m_spdGr = new System.Windows.Forms.ComboBox();
            this.m_techGr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_mdfGr = new System.Windows.Forms.ComboBox();
            this.m_protGr = new System.Windows.Forms.ComboBox();
            this.m_magGr = new System.Windows.Forms.ComboBox();
            this.m_strGr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_characterName = new System.Windows.Forms.ComboBox();
            this.m_weaponTab = new System.Windows.Forms.TabPage();
            this.m_weaponList = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mainMenu.SuspendLayout();
            this.m_mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_lhLev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rhLev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_headLev)).BeginInit();
            this.m_weaponTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_mainMenu
            // 
            this.m_mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.m_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.m_mainMenu.Name = "m_mainMenu";
            this.m_mainMenu.Size = new System.Drawing.Size(737, 24);
            this.m_mainMenu.TabIndex = 0;
            this.m_mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openISOToolStripMenuItem,
            this.btnSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openISOToolStripMenuItem
            // 
            this.openISOToolStripMenuItem.Name = "openISOToolStripMenuItem";
            this.openISOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openISOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openISOToolStripMenuItem.Text = "Open ISO";
            this.openISOToolStripMenuItem.Click += new System.EventHandler(this.openISOToolStripMenuItem_Click);
            // 
            // m_mainTabControl
            // 
            this.m_mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_mainTabControl.Controls.Add(this.tabPage1);
            this.m_mainTabControl.Controls.Add(this.m_weaponTab);
            this.m_mainTabControl.Location = new System.Drawing.Point(12, 27);
            this.m_mainTabControl.Name = "m_mainTabControl";
            this.m_mainTabControl.SelectedIndex = 0;
            this.m_mainTabControl.Size = new System.Drawing.Size(713, 444);
            this.m_mainTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMaxAll);
            this.tabPage1.Controls.Add(this.m_brightAff);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.m_darkAff);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.m_resurrAff);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.m_lightningAff);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.m_earthAff);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.m_windAff);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.m_waterAff);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.m_fireAff);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.m_rawData);
            this.tabPage1.Controls.Add(this.m_lhLev);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.m_rhLev);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.m_headLev);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.m_hpGr);
            this.tabPage1.Controls.Add(this.m_luckGr);
            this.tabPage1.Controls.Add(this.m_spdGr);
            this.tabPage1.Controls.Add(this.m_techGr);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.m_mdfGr);
            this.tabPage1.Controls.Add(this.m_protGr);
            this.tabPage1.Controls.Add(this.m_magGr);
            this.tabPage1.Controls.Add(this.m_strGr);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.m_characterName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character initial stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMaxAll
            // 
            this.btnMaxAll.Location = new System.Drawing.Point(613, 378);
            this.btnMaxAll.Name = "btnMaxAll";
            this.btnMaxAll.Size = new System.Drawing.Size(75, 23);
            this.btnMaxAll.TabIndex = 44;
            this.btnMaxAll.Text = "Max All";
            this.btnMaxAll.UseVisualStyleBackColor = true;
            this.btnMaxAll.Click += new System.EventHandler(this.btnMaxAll_Click);
            // 
            // m_brightAff
            // 
            this.m_brightAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_brightAff.FormattingEnabled = true;
            this.m_brightAff.Location = new System.Drawing.Point(341, 259);
            this.m_brightAff.Name = "m_brightAff";
            this.m_brightAff.Size = new System.Drawing.Size(131, 21);
            this.m_brightAff.TabIndex = 43;
            this.m_brightAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(262, 262);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Bright Affinity:";
            // 
            // m_darkAff
            // 
            this.m_darkAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_darkAff.FormattingEnabled = true;
            this.m_darkAff.Location = new System.Drawing.Point(94, 258);
            this.m_darkAff.Name = "m_darkAff";
            this.m_darkAff.Size = new System.Drawing.Size(131, 21);
            this.m_darkAff.TabIndex = 41;
            this.m_darkAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Dark Affinity:";
            // 
            // m_resurrAff
            // 
            this.m_resurrAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_resurrAff.FormattingEnabled = true;
            this.m_resurrAff.Location = new System.Drawing.Point(341, 232);
            this.m_resurrAff.Name = "m_resurrAff";
            this.m_resurrAff.Size = new System.Drawing.Size(131, 21);
            this.m_resurrAff.TabIndex = 39;
            this.m_resurrAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(237, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Resurrection Affinity:";
            // 
            // m_lightningAff
            // 
            this.m_lightningAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_lightningAff.FormattingEnabled = true;
            this.m_lightningAff.Location = new System.Drawing.Point(94, 231);
            this.m_lightningAff.Name = "m_lightningAff";
            this.m_lightningAff.Size = new System.Drawing.Size(131, 21);
            this.m_lightningAff.TabIndex = 37;
            this.m_lightningAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Lighning Affinity:";
            // 
            // m_earthAff
            // 
            this.m_earthAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_earthAff.FormattingEnabled = true;
            this.m_earthAff.Location = new System.Drawing.Point(341, 205);
            this.m_earthAff.Name = "m_earthAff";
            this.m_earthAff.Size = new System.Drawing.Size(131, 21);
            this.m_earthAff.TabIndex = 35;
            this.m_earthAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Earth Affinity:";
            // 
            // m_windAff
            // 
            this.m_windAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_windAff.FormattingEnabled = true;
            this.m_windAff.Location = new System.Drawing.Point(94, 204);
            this.m_windAff.Name = "m_windAff";
            this.m_windAff.Size = new System.Drawing.Size(131, 21);
            this.m_windAff.TabIndex = 33;
            this.m_windAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Wind Affinity:";
            // 
            // m_waterAff
            // 
            this.m_waterAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_waterAff.FormattingEnabled = true;
            this.m_waterAff.Location = new System.Drawing.Point(341, 178);
            this.m_waterAff.Name = "m_waterAff";
            this.m_waterAff.Size = new System.Drawing.Size(131, 21);
            this.m_waterAff.TabIndex = 31;
            this.m_waterAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Water Affinity:";
            // 
            // m_fireAff
            // 
            this.m_fireAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_fireAff.FormattingEnabled = true;
            this.m_fireAff.Location = new System.Drawing.Point(94, 177);
            this.m_fireAff.Name = "m_fireAff";
            this.m_fireAff.Size = new System.Drawing.Size(131, 21);
            this.m_fireAff.TabIndex = 29;
            this.m_fireAff.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fire Affinity:";
            // 
            // m_rawData
            // 
            this.m_rawData.Location = new System.Drawing.Point(570, 55);
            this.m_rawData.Name = "m_rawData";
            this.m_rawData.Size = new System.Drawing.Size(118, 288);
            this.m_rawData.TabIndex = 27;
            // 
            // m_lhLev
            // 
            this.m_lhLev.Location = new System.Drawing.Point(133, 363);
            this.m_lhLev.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_lhLev.Name = "m_lhLev";
            this.m_lhLev.Size = new System.Drawing.Size(43, 20);
            this.m_lhLev.TabIndex = 26;
            this.m_lhLev.ValueChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "LH rune slot level:";
            // 
            // m_rhLev
            // 
            this.m_rhLev.Location = new System.Drawing.Point(133, 337);
            this.m_rhLev.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_rhLev.Name = "m_rhLev";
            this.m_rhLev.Size = new System.Drawing.Size(43, 20);
            this.m_rhLev.TabIndex = 24;
            this.m_rhLev.ValueChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "RH rune slot level:";
            // 
            // m_headLev
            // 
            this.m_headLev.Location = new System.Drawing.Point(133, 311);
            this.m_headLev.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_headLev.Name = "m_headLev";
            this.m_headLev.Size = new System.Drawing.Size(43, 20);
            this.m_headLev.TabIndex = 22;
            this.m_headLev.ValueChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Head rune slot level:";
            // 
            // m_hpGr
            // 
            this.m_hpGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_hpGr.FormattingEnabled = true;
            this.m_hpGr.Location = new System.Drawing.Point(364, 136);
            this.m_hpGr.Name = "m_hpGr";
            this.m_hpGr.Size = new System.Drawing.Size(108, 21);
            this.m_hpGr.TabIndex = 20;
            this.m_hpGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // m_luckGr
            // 
            this.m_luckGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_luckGr.FormattingEnabled = true;
            this.m_luckGr.Location = new System.Drawing.Point(117, 136);
            this.m_luckGr.Name = "m_luckGr";
            this.m_luckGr.Size = new System.Drawing.Size(108, 21);
            this.m_luckGr.TabIndex = 19;
            this.m_luckGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // m_spdGr
            // 
            this.m_spdGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_spdGr.FormattingEnabled = true;
            this.m_spdGr.Location = new System.Drawing.Point(364, 83);
            this.m_spdGr.Name = "m_spdGr";
            this.m_spdGr.Size = new System.Drawing.Size(108, 21);
            this.m_spdGr.TabIndex = 18;
            this.m_spdGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // m_techGr
            // 
            this.m_techGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_techGr.FormattingEnabled = true;
            this.m_techGr.Location = new System.Drawing.Point(364, 57);
            this.m_techGr.Name = "m_techGr";
            this.m_techGr.Size = new System.Drawing.Size(108, 21);
            this.m_techGr.TabIndex = 17;
            this.m_techGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "HP growth rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "LUCK growth rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "SPD growth rate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "TECH growth rate:";
            // 
            // m_mdfGr
            // 
            this.m_mdfGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_mdfGr.FormattingEnabled = true;
            this.m_mdfGr.Location = new System.Drawing.Point(364, 110);
            this.m_mdfGr.Name = "m_mdfGr";
            this.m_mdfGr.Size = new System.Drawing.Size(108, 21);
            this.m_mdfGr.TabIndex = 12;
            this.m_mdfGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // m_protGr
            // 
            this.m_protGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_protGr.FormattingEnabled = true;
            this.m_protGr.Location = new System.Drawing.Point(117, 108);
            this.m_protGr.Name = "m_protGr";
            this.m_protGr.Size = new System.Drawing.Size(108, 21);
            this.m_protGr.TabIndex = 11;
            this.m_protGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // m_magGr
            // 
            this.m_magGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_magGr.FormattingEnabled = true;
            this.m_magGr.Location = new System.Drawing.Point(117, 81);
            this.m_magGr.Name = "m_magGr";
            this.m_magGr.Size = new System.Drawing.Size(108, 21);
            this.m_magGr.TabIndex = 10;
            this.m_magGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // m_strGr
            // 
            this.m_strGr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_strGr.FormattingEnabled = true;
            this.m_strGr.Location = new System.Drawing.Point(117, 55);
            this.m_strGr.Name = "m_strGr";
            this.m_strGr.Size = new System.Drawing.Size(108, 21);
            this.m_strGr.TabIndex = 9;
            this.m_strGr.SelectedIndexChanged += new System.EventHandler(this.stat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MDF growth rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PROT growth rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAG growth rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "STR growth rate:";
            // 
            // m_characterName
            // 
            this.m_characterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_characterName.FormattingEnabled = true;
            this.m_characterName.Location = new System.Drawing.Point(6, 6);
            this.m_characterName.Name = "m_characterName";
            this.m_characterName.Size = new System.Drawing.Size(157, 21);
            this.m_characterName.TabIndex = 0;
            this.m_characterName.SelectedIndexChanged += new System.EventHandler(this.m_characterName_SelectedIndexChanged);
            // 
            // m_weaponTab
            // 
            this.m_weaponTab.Controls.Add(this.m_weaponList);
            this.m_weaponTab.Location = new System.Drawing.Point(4, 22);
            this.m_weaponTab.Name = "m_weaponTab";
            this.m_weaponTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_weaponTab.Size = new System.Drawing.Size(705, 418);
            this.m_weaponTab.TabIndex = 1;
            this.m_weaponTab.Text = "Weapon DMG Growth";
            this.m_weaponTab.UseVisualStyleBackColor = true;
            // 
            // m_weaponList
            // 
            this.m_weaponList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_weaponList.FormattingEnabled = true;
            this.m_weaponList.Location = new System.Drawing.Point(6, 6);
            this.m_weaponList.Name = "m_weaponList";
            this.m_weaponList.Size = new System.Drawing.Size(188, 21);
            this.m_weaponList.TabIndex = 0;
            this.m_weaponList.SelectedIndexChanged += new System.EventHandler(this.m_weaponList_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 483);
            this.Controls.Add(this.m_mainTabControl);
            this.Controls.Add(this.m_mainMenu);
            this.MainMenuStrip = this.m_mainMenu;
            this.Name = "MainForm";
            this.Text = "Suiko2Edit";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.m_mainMenu.ResumeLayout(false);
            this.m_mainMenu.PerformLayout();
            this.m_mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_lhLev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rhLev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_headLev)).EndInit();
            this.m_weaponTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openISOToolStripMenuItem;
		private System.Windows.Forms.TabControl m_mainTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage m_weaponTab;
		private System.Windows.Forms.ComboBox m_characterName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox m_strGr;
		private System.Windows.Forms.ComboBox m_mdfGr;
		private System.Windows.Forms.ComboBox m_protGr;
		private System.Windows.Forms.ComboBox m_magGr;
		private System.Windows.Forms.ComboBox m_hpGr;
		private System.Windows.Forms.ComboBox m_luckGr;
		private System.Windows.Forms.ComboBox m_spdGr;
		private System.Windows.Forms.ComboBox m_techGr;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown m_lhLev;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown m_rhLev;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown m_headLev;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label m_rawData;
		private System.Windows.Forms.ComboBox m_waterAff;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox m_fireAff;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox m_brightAff;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox m_darkAff;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox m_resurrAff;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox m_lightningAff;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox m_earthAff;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox m_windAff;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox m_weaponList;
        private System.Windows.Forms.Button btnMaxAll;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
    }
}

