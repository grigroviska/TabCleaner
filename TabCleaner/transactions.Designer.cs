namespace TabCleaner
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.macviewbar = new System.Windows.Forms.ToolStrip();
            this.logob = new System.Windows.Forms.ToolStripButton();
            this.programname = new System.Windows.Forms.ToolStripLabel();
            this.close = new System.Windows.Forms.ToolStripButton();
            this.minimized = new System.Windows.Forms.ToolStripButton();
            this.maximized = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.macviewbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.macviewbar.Size = new System.Drawing.Size(897, 25);
            this.macviewbar.TabIndex = 11;
            this.macviewbar.Text = "toolStrip1";
            this.macviewbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Macviewbar_MouseDown);
            this.macviewbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Macviewbar_MouseMove);
            this.macviewbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Macviewbar_MouseUp);
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
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // minimized
            // 
            this.minimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minimized.Image = ((System.Drawing.Image)(resources.GetObject("minimized.Image")));
            this.minimized.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(23, 22);
            this.minimized.Text = "Küçült";
            this.minimized.Click += new System.EventHandler(this.Minimized_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 289);
            this.dataGridView1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(837, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Tüm Verileri Sil");
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(586, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Seçili Olanı Sil");
            this.pictureBox2.WaitOnLoad = true;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Verileri Excel\'e Aktar");
            this.pictureBox3.WaitOnLoad = true;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(263, 327);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Arama Aracı");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(368, 298);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(368, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 88);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.macviewbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Transactions";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemlerim";
            this.toolTip1.SetToolTip(this, "Seçili Olanı Sil");
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Transactions_KeyDown);
            this.macviewbar.ResumeLayout(false);
            this.macviewbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip macviewbar;
        private System.Windows.Forms.ToolStripButton logob;
        private System.Windows.Forms.ToolStripLabel programname;
        private System.Windows.Forms.ToolStripButton close;
        private System.Windows.Forms.ToolStripButton minimized;
        private System.Windows.Forms.ToolStripButton maximized;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}