namespace TabCleaner
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gematrigawebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.computername = new System.Windows.Forms.Label();
            this.systemfeatures = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ramcapacity = new System.Windows.Forms.Label();
            this.displaycard = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Label();
            this.heightandrefreshrate = new System.Windows.Forms.Label();
            this.operatingsystem = new System.Windows.Forms.Label();
            this.cpuname = new System.Windows.Forms.Label();
            this.cpuaddresswidth = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.recyclebinbox = new System.Windows.Forms.CheckBox();
            this.tempfolderbox = new System.Windows.Forms.CheckBox();
            this.recentfolderbox = new System.Windows.Forms.CheckBox();
            this.prefetchbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsandfunctions = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.appearanceselection = new System.Windows.Forms.ComboBox();
            this.runonstartup = new System.Windows.Forms.CheckBox();
            this.support = new System.Windows.Forms.LinkLabel();
            this.clean = new System.Windows.Forms.Button();
            this.darkandwhitemode = new System.Windows.Forms.CheckBox();
            this.programnametabcleaner = new System.Windows.Forms.Label();
            this.macviewbar = new System.Windows.Forms.ToolStrip();
            this.logob = new System.Windows.Forms.ToolStripButton();
            this.programname = new System.Windows.Forms.ToolStripLabel();
            this.close = new System.Windows.Forms.ToolStripButton();
            this.minimized = new System.Windows.Forms.ToolStripButton();
            this.maximized = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.systemfeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.settingsandfunctions.SuspendLayout();
            this.macviewbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Bilgisayarını temizleyeyim mi dolu olabilir.";
            this.notifyIcon1.BalloonTipTitle = "TABCLEANER";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TabCleaner";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.gematrigawebsite});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem1.Text = "Göster";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Showme_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem2.Text = "Çıkış";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Exitme_Click);
            // 
            // gematrigawebsite
            // 
            this.gematrigawebsite.Name = "gematrigawebsite";
            this.gematrigawebsite.Size = new System.Drawing.Size(129, 22);
            this.gematrigawebsite.Text = "Gematriga";
            this.gematrigawebsite.ToolTipText = "Gematriga\'ya git!";
            this.gematrigawebsite.Click += new System.EventHandler(this.Gematrigawebsite_Click);
            // 
            // computername
            // 
            this.computername.AutoSize = true;
            this.computername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.computername.Location = new System.Drawing.Point(6, 26);
            this.computername.Name = "computername";
            this.computername.Size = new System.Drawing.Size(72, 13);
            this.computername.TabIndex = 2;
            this.computername.Text = "Bilgisayar Adı:";
            // 
            // systemfeatures
            // 
            this.systemfeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.systemfeatures.BackColor = System.Drawing.Color.Transparent;
            this.systemfeatures.Controls.Add(this.richTextBox1);
            this.systemfeatures.Controls.Add(this.ramcapacity);
            this.systemfeatures.Controls.Add(this.displaycard);
            this.systemfeatures.Controls.Add(this.screen);
            this.systemfeatures.Controls.Add(this.heightandrefreshrate);
            this.systemfeatures.Controls.Add(this.operatingsystem);
            this.systemfeatures.Controls.Add(this.cpuname);
            this.systemfeatures.Controls.Add(this.cpuaddresswidth);
            this.systemfeatures.Controls.Add(this.computername);
            this.systemfeatures.Location = new System.Drawing.Point(12, 19);
            this.systemfeatures.Name = "systemfeatures";
            this.systemfeatures.Size = new System.Drawing.Size(528, 214);
            this.systemfeatures.TabIndex = 1;
            this.systemfeatures.TabStop = false;
            this.systemfeatures.Text = "Bilgisayar Özellikleri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(522, 195);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBox1_LinkClicked);
            // 
            // ramcapacity
            // 
            this.ramcapacity.AutoSize = true;
            this.ramcapacity.Location = new System.Drawing.Point(6, 188);
            this.ramcapacity.Name = "ramcapacity";
            this.ramcapacity.Size = new System.Drawing.Size(83, 13);
            this.ramcapacity.TabIndex = 9;
            this.ramcapacity.Text = "Ram Kapasitesi:";
            // 
            // displaycard
            // 
            this.displaycard.AutoSize = true;
            this.displaycard.Location = new System.Drawing.Point(6, 165);
            this.displaycard.Name = "displaycard";
            this.displaycard.Size = new System.Drawing.Size(62, 13);
            this.displaycard.TabIndex = 8;
            this.displaycard.Text = "Ekran Kartı:";
            // 
            // screen
            // 
            this.screen.AutoSize = true;
            this.screen.Location = new System.Drawing.Point(6, 142);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(38, 13);
            this.screen.TabIndex = 7;
            this.screen.Text = "Ekran:";
            // 
            // heightandrefreshrate
            // 
            this.heightandrefreshrate.AutoSize = true;
            this.heightandrefreshrate.Location = new System.Drawing.Point(6, 120);
            this.heightandrefreshrate.Name = "heightandrefreshrate";
            this.heightandrefreshrate.Size = new System.Drawing.Size(199, 13);
            this.heightandrefreshrate.TabIndex = 6;
            this.heightandrefreshrate.Text = "Yükseklik ve Yenileme Hızı (Videomode):";
            // 
            // operatingsystem
            // 
            this.operatingsystem.AutoSize = true;
            this.operatingsystem.Location = new System.Drawing.Point(6, 98);
            this.operatingsystem.Name = "operatingsystem";
            this.operatingsystem.Size = new System.Drawing.Size(75, 13);
            this.operatingsystem.TabIndex = 5;
            this.operatingsystem.Text = "İşletim Sistemi:";
            // 
            // cpuname
            // 
            this.cpuname.AutoSize = true;
            this.cpuname.Location = new System.Drawing.Point(6, 76);
            this.cpuname.Name = "cpuname";
            this.cpuname.Size = new System.Drawing.Size(53, 13);
            this.cpuname.TabIndex = 4;
            this.cpuname.Text = "CPU İsmi:";
            // 
            // cpuaddresswidth
            // 
            this.cpuaddresswidth.AutoSize = true;
            this.cpuaddresswidth.Location = new System.Drawing.Point(6, 51);
            this.cpuaddresswidth.Name = "cpuaddresswidth";
            this.cpuaddresswidth.Size = new System.Drawing.Size(104, 13);
            this.cpuaddresswidth.TabIndex = 3;
            this.cpuaddresswidth.Text = "CPU Adres Genişliği:";
            // 
            // recyclebinbox
            // 
            this.recyclebinbox.AutoSize = true;
            this.recyclebinbox.Location = new System.Drawing.Point(222, 23);
            this.recyclebinbox.Name = "recyclebinbox";
            this.recyclebinbox.Size = new System.Drawing.Size(129, 17);
            this.recyclebinbox.TabIndex = 13;
            this.recyclebinbox.Text = "Geri Dönüşüm Kutusu";
            this.toolTip1.SetToolTip(this.recyclebinbox, "Sildiğiniz verileri geri dönüşüm kutusundan kalıcı olarak siler.");
            this.recyclebinbox.UseVisualStyleBackColor = true;
            this.recyclebinbox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // tempfolderbox
            // 
            this.tempfolderbox.AutoSize = true;
            this.tempfolderbox.Location = new System.Drawing.Point(222, 46);
            this.tempfolderbox.Name = "tempfolderbox";
            this.tempfolderbox.Size = new System.Drawing.Size(91, 17);
            this.tempfolderbox.TabIndex = 14;
            this.tempfolderbox.Text = "Temp Klasörü";
            this.toolTip1.SetToolTip(this.tempfolderbox, "Geçici ve gereksiz dosyaların bulunduğu bir klasördür.İşaretlemeniz Önerilir.");
            this.tempfolderbox.UseVisualStyleBackColor = true;
            this.tempfolderbox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // recentfolderbox
            // 
            this.recentfolderbox.AutoSize = true;
            this.recentfolderbox.Location = new System.Drawing.Point(222, 69);
            this.recentfolderbox.Name = "recentfolderbox";
            this.recentfolderbox.Size = new System.Drawing.Size(99, 17);
            this.recentfolderbox.TabIndex = 15;
            this.recentfolderbox.Text = "Recent Klasörü";
            this.toolTip1.SetToolTip(this.recentfolderbox, "Ram\'in performansını arttırır.Belirli zaman aralıklarında işaretlemeniz önerilir." +
        "");
            this.recentfolderbox.UseVisualStyleBackColor = true;
            this.recentfolderbox.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // prefetchbox
            // 
            this.prefetchbox.AutoSize = true;
            this.prefetchbox.Location = new System.Drawing.Point(222, 92);
            this.prefetchbox.Name = "prefetchbox";
            this.prefetchbox.Size = new System.Drawing.Size(104, 17);
            this.prefetchbox.TabIndex = 16;
            this.prefetchbox.Text = "Prefetch Klasörü";
            this.toolTip1.SetToolTip(this.prefetchbox, "Çok sık kullanmayınız genelde kendisini belli bir süre sonra temizler.");
            this.prefetchbox.UseVisualStyleBackColor = true;
            this.prefetchbox.CheckedChanged += new System.EventHandler(this.Prefetchbox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "İşlemlerim");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // settingsandfunctions
            // 
            this.settingsandfunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsandfunctions.BackColor = System.Drawing.Color.Transparent;
            this.settingsandfunctions.Controls.Add(this.pictureBox1);
            this.settingsandfunctions.Controls.Add(this.richTextBox2);
            this.settingsandfunctions.Controls.Add(this.progressBar1);
            this.settingsandfunctions.Controls.Add(this.prefetchbox);
            this.settingsandfunctions.Controls.Add(this.recentfolderbox);
            this.settingsandfunctions.Controls.Add(this.appearanceselection);
            this.settingsandfunctions.Controls.Add(this.runonstartup);
            this.settingsandfunctions.Controls.Add(this.support);
            this.settingsandfunctions.Controls.Add(this.clean);
            this.settingsandfunctions.Controls.Add(this.tempfolderbox);
            this.settingsandfunctions.Controls.Add(this.darkandwhitemode);
            this.settingsandfunctions.Controls.Add(this.recyclebinbox);
            this.settingsandfunctions.Location = new System.Drawing.Point(12, 255);
            this.settingsandfunctions.Name = "settingsandfunctions";
            this.settingsandfunctions.Size = new System.Drawing.Size(528, 118);
            this.settingsandfunctions.TabIndex = 9;
            this.settingsandfunctions.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(3, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(213, 90);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "Sonuç Ekranı : Daha Bir İşlem Yapmadınız!\n\nBu ekranı bu alana çift tıklayarak vey" +
    "a CTRL+K kısayolu tuşundan kapatabilirsiniz.";
            this.richTextBox2.Visible = false;
            this.richTextBox2.DoubleClick += new System.EventHandler(this.richTextBox2_DoubleClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(134, 21);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Visible = false;
            // 
            // appearanceselection
            // 
            this.appearanceselection.FormattingEnabled = true;
            this.appearanceselection.Items.AddRange(new object[] {
            "Normal Görünüm",
            "Mac Görünüm"});
            this.appearanceselection.Location = new System.Drawing.Point(23, 69);
            this.appearanceselection.Name = "appearanceselection";
            this.appearanceselection.Size = new System.Drawing.Size(134, 21);
            this.appearanceselection.TabIndex = 12;
            this.appearanceselection.Text = "Görünüm Seçiniz";
            this.appearanceselection.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // runonstartup
            // 
            this.runonstartup.AutoSize = true;
            this.runonstartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.runonstartup.Location = new System.Drawing.Point(23, 46);
            this.runonstartup.Name = "runonstartup";
            this.runonstartup.Size = new System.Drawing.Size(134, 17);
            this.runonstartup.TabIndex = 11;
            this.runonstartup.Text = "Başlangıçta Çalıştır";
            this.runonstartup.UseVisualStyleBackColor = true;
            this.runonstartup.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // support
            // 
            this.support.AutoSize = true;
            this.support.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.support.LinkColor = System.Drawing.Color.Black;
            this.support.Location = new System.Drawing.Point(444, 92);
            this.support.Name = "support";
            this.support.Size = new System.Drawing.Size(64, 13);
            this.support.TabIndex = 18;
            this.support.TabStop = true;
            this.support.Text = "Gematriga";
            this.support.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clean.Location = new System.Drawing.Point(369, 23);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(139, 40);
            this.clean.TabIndex = 17;
            this.clean.Text = "Temizle";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // darkandwhitemode
            // 
            this.darkandwhitemode.AutoSize = true;
            this.darkandwhitemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkandwhitemode.Location = new System.Drawing.Point(23, 23);
            this.darkandwhitemode.Name = "darkandwhitemode";
            this.darkandwhitemode.Size = new System.Drawing.Size(89, 17);
            this.darkandwhitemode.TabIndex = 10;
            this.darkandwhitemode.Text = "Koyu Tema";
            this.darkandwhitemode.UseVisualStyleBackColor = true;
            this.darkandwhitemode.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // programnametabcleaner
            // 
            this.programnametabcleaner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.programnametabcleaner.AutoSize = true;
            this.programnametabcleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programnametabcleaner.Location = new System.Drawing.Point(231, 234);
            this.programnametabcleaner.Name = "programnametabcleaner";
            this.programnametabcleaner.Size = new System.Drawing.Size(72, 13);
            this.programnametabcleaner.TabIndex = 19;
            this.programnametabcleaner.Text = "TabCleaner";
            this.programnametabcleaner.Click += new System.EventHandler(this.Programnametabcleaner_Click);
            // 
            // macviewbar
            // 
            this.macviewbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.macviewbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logob,
            this.programname,
            this.close,
            this.minimized,
            this.maximized});
            this.macviewbar.Location = new System.Drawing.Point(0, 0);
            this.macviewbar.Name = "macviewbar";
            this.macviewbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.macviewbar.Size = new System.Drawing.Size(552, 25);
            this.macviewbar.TabIndex = 10;
            this.macviewbar.Text = "toolStrip1";
            this.macviewbar.Visible = false;
            this.macviewbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip1_MouseDown);
            this.macviewbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolStrip1_MouseMove);
            this.macviewbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolStrip1_MouseUp);
            // 
            // logob
            // 
            this.logob.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logob.Image = ((System.Drawing.Image)(resources.GetObject("logob.Image")));
            this.logob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logob.Name = "logob";
            this.logob.Size = new System.Drawing.Size(23, 22);
            this.logob.Text = "TabCleaner";
            this.logob.Click += new System.EventHandler(this.Logob_Click);
            // 
            // programname
            // 
            this.programname.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.programname.Name = "programname";
            this.programname.Size = new System.Drawing.Size(65, 22);
            this.programname.Text = "TabCleaner";
            // 
            // close
            // 
            this.close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 22);
            this.close.Text = "Kapat";
            this.close.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // minimized
            // 
            this.minimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minimized.Image = ((System.Drawing.Image)(resources.GetObject("minimized.Image")));
            this.minimized.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(23, 22);
            this.minimized.Text = "Küçült";
            this.minimized.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // maximized
            // 
            this.maximized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximized.Enabled = false;
            this.maximized.Image = ((System.Drawing.Image)(resources.GetObject("maximized.Image")));
            this.maximized.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maximized.Name = "maximized";
            this.maximized.Size = new System.Drawing.Size(23, 22);
            this.maximized.Text = "Ekranı Kapla";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 385);
            this.Controls.Add(this.macviewbar);
            this.Controls.Add(this.programnametabcleaner);
            this.Controls.Add(this.settingsandfunctions);
            this.Controls.Add(this.systemfeatures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "home";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabCleaner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.systemfeatures.ResumeLayout(false);
            this.systemfeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.settingsandfunctions.ResumeLayout(false);
            this.settingsandfunctions.PerformLayout();
            this.macviewbar.ResumeLayout(false);
            this.macviewbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label computername;
        private System.Windows.Forms.GroupBox systemfeatures;
        private System.Windows.Forms.Label cpuaddresswidth;
        private System.Windows.Forms.Label operatingsystem;
        private System.Windows.Forms.Label cpuname;
        private System.Windows.Forms.Label displaycard;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Label heightandrefreshrate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox recyclebinbox;
        private System.Windows.Forms.CheckBox tempfolderbox;
        private System.Windows.Forms.GroupBox settingsandfunctions;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.CheckBox darkandwhitemode;
        private System.Windows.Forms.LinkLabel support;
        private System.Windows.Forms.CheckBox runonstartup;
        private System.Windows.Forms.ComboBox appearanceselection;
        private System.Windows.Forms.ToolStrip macviewbar;
        private System.Windows.Forms.ToolStripButton logob;
        private System.Windows.Forms.ToolStripLabel programname;
        private System.Windows.Forms.ToolStripButton close;
        private System.Windows.Forms.CheckBox recentfolderbox;
        private System.Windows.Forms.ToolStripButton minimized;
        private System.Windows.Forms.ToolStripButton maximized;
        private System.Windows.Forms.CheckBox prefetchbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gematrigawebsite;
        private System.Windows.Forms.Label programnametabcleaner;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ramcapacity;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

