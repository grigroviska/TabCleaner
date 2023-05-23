using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;
using System.Management;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Data.OleDb;


namespace TabCleaner
{
    public partial class home : Form
    {
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Alper\\Documents\\islemveritabani.mdb");
        //NotifyIcon Kod kısmı
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.ShowBalloonTip(2000, "TabCleaner", "Gizli simgelerdeyiz korkma :)", ToolTipIcon.Info);
            }
        }
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private void Showme_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private void Exitme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Gematrigawebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gematriga.blogspot.com");
        }
        public home()
        {
            InitializeComponent();
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue(ProgramAdi).ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    runonstartup.Checked = true;
                }
            }
            catch
            {
            }
        }
        //Geri Dönüşüm Kutusunun Kodları
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath,RecycleFlags dwFlags);
        //Form1 Yüklenince Olması Gerekenler
        private void Form1_Load(object sender, EventArgs e)
        {
            clean.Enabled = false;
            if (Properties.Settings.Default.thememw == 0)
            {
                Normal();
                appearanceselection.SelectedIndex = 0;
            }
            else if (Properties.Settings.Default.thememw == 1)
            {
                Macview();
                appearanceselection.SelectedIndex = 1;
            }
            if (Properties.Settings.Default.tempfileloga == 1)
            {
                tempfolderbox.Checked = true;
            }
            else
            {
                tempfolderbox.Checked = false;
            }
            if (Properties.Settings.Default.mode == 1)
            {
                darkandwhitemode.Checked = true;
                Darktheme();
            }
            else
            {
                darkandwhitemode.Checked = false;
                WhiteTheme();
            }
            //Bilgisayar Özelliklerini Gösteren Komutlar
            string bilgisayarAdi = Dns.GetHostName();
            computername.Text = "Bilgisayar Adı: " + bilgisayarAdi;
            string host = Dns.GetHostName();
            string serialNumber = string.Empty;
            ManagementObjectSearcher managmentSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    cpuaddresswidth.Text = ("CPU Adres Genişliği: " + queryObj["AddressWidth"] + " Bit");
                    cpuname.Text = string.Format("CPU İsmi: " + queryObj["Name"]);
                }
            }
            catch (ManagementException)
            {
            }
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    operatingsystem.Text = string.Format("İşletim Sistemi: " + queryObj["Name"]);
                }
            }
            catch (ManagementException)
            {
            }
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DisplayControllerConfiguration");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    heightandrefreshrate.Text = string.Format("Yenileme Hızı: " + queryObj["RefreshRate"] + " Hz");
                    screen.Text = string.Format("Ekran: " + queryObj["Name"]);
                }
            }
            catch (ManagementException)
            {
            }
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    displaycard.Text = string.Format("Ekran Kartı: " + queryObj["Name"]);
                }
            }
            catch (ManagementException)
            {
            }
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    double rambytes = (Convert.ToDouble(queryObj["Capacity"]));
                    double ramgb = rambytes / 1073741824;
                    double ramislem = Math.Ceiling(ramgb);
                    ramcapacity.Text = string.Format("Ram Kapasitesi: " + ramislem + " GB");
                }
            }
            catch (ManagementException)
            {
            }
        }
        string ProgramAdi = "TabCleaner";
        //Regedit Kaydı Açılışta Başlatmak İçin
        private void ChckAcilistaCalistir_CheckedChanged(object sender, EventArgs e)
        {
            string runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            string appName = "İşlem Otomasyonu";

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(runKey, true);

            if (runonstartup.Checked)
            {
                if (rk.GetValue(appName) == null)
                    rk.SetValue(appName, Application.ExecutablePath.ToString());
            }
            else
            {
                if (rk.GetValue(appName) != null)
                    rk.DeleteValue(appName);
            }

            rk.Close();
        }
        //Recent, Prefetch gibi verilerin sileneceği kodlar
        private void RecentTemporaryFolders()
        {
            String recent = Environment.ExpandEnvironmentVariables("%appdata%\\Microsoft\\Windows") + ("\\Recent");
            EmptyFolderContents(recent);
        }
        private void PrefetchTemporaryFolders()
        {
            String prefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%") + "\\Prefetch";
            EmptyFolderContents(prefetch);
        }
        private void EmptyFolderContents(string folderName)
        {
            foreach (var folder in Directory.GetDirectories(folderName))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
            foreach (var file in Directory.GetFiles(folderName))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
        }
        //Temaların Güvenli İstemleri
        private void Darktheme()
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");
            ForeColor = Color.White;
            systemfeatures.ForeColor = Color.White;
            macviewbar.BackColor = System.Drawing.Color.Black;
            support.LinkColor = System.Drawing.Color.White;
            richTextBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");
            richTextBox1.ForeColor = Color.White;
            richTextBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");
            richTextBox2.ForeColor = Color.Aqua;
            TabCleaner.Properties.Settings.Default.mode = 1;
            TabCleaner.Properties.Settings.Default.Save();
        }
        private void WhiteTheme()
        {
            this.BackColor = Color.White;
            ForeColor = Color.Black;
            systemfeatures.ForeColor = Color.Black;
            macviewbar.BackColor = System.Drawing.Color.White;
            support.LinkColor = System.Drawing.Color.Black;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            richTextBox2.BackColor = Color.White;
            richTextBox2.ForeColor = Color.Black;
            TabCleaner.Properties.Settings.Default.mode = 0;
            TabCleaner.Properties.Settings.Default.Save();
        }
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (darkandwhitemode.Checked == true)
            {
                Darktheme();
            }
            if (darkandwhitemode.Checked == false)
            {
                WhiteTheme();
            }
        }
        public static long FolderSizeCalculation(string yol)
        {
            long size = 0;
            string[] folders = Directory.GetFiles(yol, "*.*", SearchOption.AllDirectories);
            foreach (string folder in folders)
            {
                FileInfo fileInfo = new FileInfo(folder);
                size += fileInfo.Length;
            }
            return size;
        }
        bool recyclebox = false;
        bool tempfolder = false;
        bool recentfolder = false;
        bool prefetchboxa = false;
        //Butonun İşlevi
        private void Clean_Click(object sender, EventArgs e)
        {
            string islemsaati = DateTime.Now.ToLongTimeString();
            string islemtarihi = DateTime.Now.ToShortDateString();
            string ftemp = Environment.ExpandEnvironmentVariables("%Temp%");
            long ftemps = FolderSizeCalculation(ftemp);
            int firsttempsize = Convert.ToInt32(ftemps.ToString());
            String frecent = Environment.ExpandEnvironmentVariables("%appdata%\\Microsoft\\Windows") + ("\\Recent");
            long frecents = FolderSizeCalculation(frecent);
            int firstrecentsize = Convert.ToInt32(frecents.ToString());
            String fprefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%") + ("\\Prefetch");
            long fprefetchs = FolderSizeCalculation(fprefetch);
            int firstprefetchsize = Convert.ToInt32(fprefetchs.ToString());
            int a = firsttempsize + firstrecentsize + firstprefetchsize;
            if (recyclebinbox.Checked == true || tempfolderbox.Checked == true || recentfolderbox.Checked == true || prefetchbox.Checked == true)
            {
                if (recyclebinbox.Checked == true)
                {
                    try
                    {
                        recyclebox = true;
                        uint result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);
                    }
                    catch (Exception bug)
                    {
                        MessageBox.Show(bug + "Hatası ile karşılaşıldı.", "Hata!");
                    }
                }
                if (tempfolderbox.Checked == true)
                {
                    try
                    {
                        tempfolder = true;
                        string tempFilePathWithoutFileName = Path.GetTempPath();
                        Directory.Delete(tempFilePathWithoutFileName, true);
                    }
                    catch (Exception)
                    {
                    }
                }
                if (recentfolderbox.Checked == true)
                {
                    try
                    {
                        recentfolder = true;
                        RecentTemporaryFolders();
                    }
                    catch (Exception)
                    {
                    }
                }
                if (prefetchbox.Checked == true)
                {
                    try
                    {
                        prefetchboxa = true;
                        PrefetchTemporaryFolders();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                
                progressBar1.Maximum = 100;

                for (int i = 0; i <= 100; i += 5)
                {
                    progressBar1.Value = i;
                    TaskbarManager.Instance.SetProgressValue(i, 100);
                    System.Threading.Thread.Sleep(300);
                }

                //loading frm3 = new loading();
                //frm3.ShowDialog();
            }
            String stemp = Environment.ExpandEnvironmentVariables("%TEMP%");
            long stemps = FolderSizeCalculation(stemp);
            int secondtempsize = Convert.ToInt32(stemps.ToString());
            String srecent = Environment.ExpandEnvironmentVariables("%appdata%\\Microsoft\\Windows") + ("\\Recent");
            long srecents = FolderSizeCalculation(srecent);
            int secondrecentsize = Convert.ToInt32(srecents.ToString());
            String sprefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%") + ("\\Prefetch");
            long sprefetchs = FolderSizeCalculation(sprefetch);
            int secondprefetchsize = Convert.ToInt32(sprefetchs.ToString());
            int b = secondtempsize + secondrecentsize + secondprefetchsize;
            int sonuc = a - b;
            double kbcevirme = sonuc / 1024;
            double mbcevirme = sonuc / 1048576;
            richTextBox2.ResetText();
            richTextBox2.Visible = true;
            richTextBox2.Text = sonuc.ToString() + " Byte Temizlendi." + Environment.NewLine+ "Kısacası Diğer Türler Olarak:"+ Environment.NewLine + kbcevirme.ToString() + " KB Temizlendi." + Environment.NewLine + "Yani " + mbcevirme.ToString()+" MB Temizlendi." + Environment.NewLine + Environment.NewLine + "Bu Ekranı Bu Alana Çift Tıklayarak veya CTRL+K Kısayolu Tuşundan Kapatabilirsiniz!";
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into islemler(islem_saati,islem_tarihi,geridonusumkutusu,tempklasoru,recentklasoru,prefetchklasoru,silinenveriboyutu) values ('" + islemsaati.ToString() + "','" + islemtarihi.ToString()+ "',"+recyclebox.ToString()+ "," + tempfolder.ToString() + "," + recentfolder.ToString() + "," + prefetchboxa.ToString() + ",'" + mbcevirme.ToString()+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //Siteye Yönlendirme
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://gematriga.blogspot.com");
        }
        //Butonun aktifleşmesini sorgulama
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (recyclebinbox.Checked==true || tempfolderbox.Checked==true || recentfolderbox.Checked== true || prefetchbox.Checked == true)
            {
                clean.Enabled = true;
            }
            else
            {
                clean.Enabled = false;
            }
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (recyclebinbox.Checked == true || tempfolderbox.Checked == true || recentfolderbox.Checked == true || prefetchbox.Checked == true)
            {
                clean.Enabled = true;
            }
            else
            {
                clean.Enabled = false;
            }
        }
        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (recyclebinbox.Checked == true || tempfolderbox.Checked == true || recentfolderbox.Checked == true || prefetchbox.Checked==true)
            {
                clean.Enabled = true;
            }
            else
            {
                clean.Enabled = false;
            }
        }
        private void Prefetchbox_CheckedChanged(object sender, EventArgs e)
        {
            if (recyclebinbox.Checked == true || tempfolderbox.Checked == true || recentfolderbox.Checked == true || prefetchbox.Checked == true)
            {
                clean.Enabled = true;
            }
            else
            {
                clean.Enabled = false;
            }
        }
        //Regedit'e değeri kaydetme
        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (runonstartup.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
            }
            else
            {  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
            }
        }
        //Görünüm Türleri
        private void Normal()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            macviewbar.Visible = false;
            systemfeatures.Location = new Point(11,25);
            settingsandfunctions.Location = new Point(11, 250);
            programnametabcleaner.Location = new Point(231,229);
            this.Height = 413;
        }
        private void Macview()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            macviewbar.Visible = true;
            this.Height = 400;
            systemfeatures.Location = new Point(11, 40);
            settingsandfunctions.Location = new Point(11, 270);
            programnametabcleaner.Location = new Point(231, 246);
        }
        //Tema Seçici ve Kaydedici
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appearanceselection.SelectedIndex == 0)
            {
                TabCleaner.Properties.Settings.Default.thememw = 0;
                TabCleaner.Properties.Settings.Default.Save();
                Normal();
            }
            if (appearanceselection.SelectedIndex == 1)
            {
                TabCleaner.Properties.Settings.Default.thememw = 1;
                TabCleaner.Properties.Settings.Default.Save();
                Macview();
            }
        }
        //Mac Görünümü Buton Kodları
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ToolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }
        private void ToolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }
        private void ToolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //logo yönlendirici
        private void Logob_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gematriga.blogspot.com");
        }
        //Kısayol Tuşları
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                if (darkandwhitemode.Checked == false)
                {
                    darkandwhitemode.Checked = true;
                }
                else
                {
                    darkandwhitemode.Checked = false;
                }
            }
            if (e.KeyCode == Keys.F6)
            {
                if (runonstartup.Checked == false)
                {
                    runonstartup.Checked = true;
                }
                else
                {
                    runonstartup.Checked = false;
                }
            }
            if (e.KeyCode == Keys.F7)
            {
                if (appearanceselection.SelectedIndex == 0)
                {
                    appearanceselection.SelectedIndex = 1;
                }
                else
                {
                    appearanceselection.SelectedIndex = 0;
                } 
            }
            if (e.KeyCode == Keys.F1)
            {
                if (recyclebinbox.Checked == false)
                {
                    recyclebinbox.Checked = true;
                }
                else
                {
                    recyclebinbox.Checked = false;
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                if (tempfolderbox.Checked == false)
                {
                    tempfolderbox.Checked = true;
                }
                else
                {
                    tempfolderbox.Checked = false;
                }
            }
            if (e.KeyCode == Keys.F3)
            {
                if (recentfolderbox.Checked == false)
                {
                    recentfolderbox.Checked = true;
                }
                else
                {
                    recentfolderbox.Checked = false;
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                if (prefetchbox.Checked == false)
                {
                    prefetchbox.Checked = true;
                }
                else
                {
                    prefetchbox.Checked = false;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                clean.PerformClick();
            }
            if (e.KeyCode == Keys.F12)
            {
                System.Diagnostics.Process.Start("http://gematriga.blogspot.com");
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                if (richTextBox1.Visible == true)
                {
                    richTextBox1.Visible = false;
                }
                else
                {
                    richTextBox1.Visible = true;
                }
            }
            if (e.Control == true && e.KeyCode == Keys.K)
            {
                if (richTextBox2.Visible == true)
                {
                    richTextBox2.Visible = false;
                }
                else
                {
                    richTextBox2.Visible = true;
                }
            }
        }

        private void Programnametabcleaner_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == false)
            {
                richTextBox1.Visible = true;
                richTextBox1.Select(0, richTextBox1.Lines[0].Length);
                richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            }
            else
            {
                richTextBox1.Visible = false;
            }
        }

        private void RichTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void richTextBox2_DoubleClick(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transactions islemler = new Transactions();
            islemler.ShowDialog();
        }
    }
}
