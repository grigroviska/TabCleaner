using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Point = System.Drawing.Point;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace TabCleaner
{
    public partial class Transactions : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=islemveritabani.mdb");
        DataTable tablo = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand kmt = new OleDbCommand();
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        public Transactions()
        {
            InitializeComponent();
        }
        private void Transactions_Load(object sender, EventArgs e)
        {
            Verilerigoruntule();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "İşlem Saati";
            dataGridView1.Columns[2].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns[3].HeaderText = "Geri Dönüşüm Kutusu";
            dataGridView1.Columns[4].HeaderText = "Temp Klasörü";
            dataGridView1.Columns[5].HeaderText = "Recent Klasörü";
            dataGridView1.Columns[6].HeaderText = "Prefetch Klasörü";
            dataGridView1.Columns[7].HeaderText = "Silinen Veri Boyutu (MB)";
            dataGridView1.AllowUserToAddRows = false;
            if (Properties.Settings.Default.mode == 1)
            {
                Darktheme();
            }
            else
            {
                WhiteTheme();
            }
            if (Properties.Settings.Default.thememw == 0)
            {
                Normal();
            }
            else if (Properties.Settings.Default.thememw == 1)
            {
                Macview();
            }
        }
        private void Verilerigoruntule()
        {
            con.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From islemler", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            con.Close();
        }
        private void Normal()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            macviewbar.Visible = false;
        }
        private void Macview()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            macviewbar.Visible = true;
        }
        //Temaların Güvenli İstemleri
        private void Darktheme()
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");
            macviewbar.BackColor = System.Drawing.Color.Black;
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");
            programname.ForeColor = Color.White;
            TabCleaner.Properties.Settings.Default.mode = 1;
            TabCleaner.Properties.Settings.Default.Save();
            dataGridView1.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#232323");
        }
        private void WhiteTheme()
        {
            this.BackColor = Color.White;
            macviewbar.BackColor = System.Drawing.Color.White;
            panel1.BackColor = Color.White;
            TabCleaner.Properties.Settings.Default.mode = 0;
            TabCleaner.Properties.Settings.Default.Save();
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
        }
        private void Macviewbar_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }
        private void Macviewbar_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }
        private void Macviewbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Logob_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    progressBar1.Maximum = 100;
                    for (int i = 0; i <= 100; i += 5)
                    {
                        progressBar1.Value = i;
                        TaskbarManager.Instance.SetProgressValue(i, 100);
                        System.Threading.Thread.Sleep(200);
                    }
                    string sql = "DELETE * FROM islemler";
                    kmt = new OleDbCommand(sql, con);
                    con.Open();
                    kmt.ExecuteNonQuery();
                    con.Close();
                    tablo.Clear();
                    Verilerigoruntule();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi", "İptal Edildi!");
                }
            }
            catch (Exception hop)
            {
                MessageBox.Show(hop.Message);
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    progressBar1.Maximum = 100;

                    for (int i = 0; i <= 100; i += 5)
                    {
                        progressBar1.Value = i;
                        TaskbarManager.Instance.SetProgressValue(i, 100);
                        System.Threading.Thread.Sleep(100);
                    }
                    con.Open();
                    kmt.Connection = con;
                    kmt.CommandText = "DELETE FROM islemler WHERE id=@aid";
                    kmt.Parameters.AddWithValue("@aid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmt.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablo.Clear();
                    Verilerigoruntule();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi", "İptal Edildi!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Kayıt Edilecek Veri Yok!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    progressBar1.Maximum = 100;
                    for (int i = 0; i <= 100; i += 5)
                    {
                        progressBar1.Value = i;
                        TaskbarManager.Instance.SetProgressValue(i, 100);
                        System.Threading.Thread.Sleep(200);
                    }
                    Excel.Application excel = new Excel.Application();
                    excel.Visible = true;
                    object Missing = Type.Missing;
                    Workbook workbook = excel.Workbooks.Add(Missing);
                    Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                    int StartCol = 1;
                    int StartRow = 1;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                        myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                    }
                    StartRow++;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                            myRange.Select();
                        }
                    }
                }
                catch (Exception oww)
                {
                    MessageBox.Show(oww.Message);
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == false && panel1.Visible == false)
            {
                panel1.Visible = true;
                dateTimePicker1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                dateTimePicker1.Visible = false;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            con.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From islemler where islem_tarihi=@tarih", con);
            adtr.SelectCommand.Parameters.AddWithValue("tarih", dateTimePicker1.Value.ToShortDateString());
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
            panel1.Visible = false;
            dateTimePicker1.Visible = false;
        }
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dateTimePicker1.Visible = false;
        }
        private void Transactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Kayıt Edilecek Veri Yok!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        progressBar1.Maximum = 100;
                        for (int i = 0; i <= 100; i += 5)
                        {
                            progressBar1.Value = i;
                            TaskbarManager.Instance.SetProgressValue(i, 100);
                            System.Threading.Thread.Sleep(200);
                        }
                        Excel.Application excel = new Excel.Application();
                        excel.Visible = true;
                        object Missing = Type.Missing;
                        Workbook workbook = excel.Workbooks.Add(Missing);
                        Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                        int StartCol = 1;
                        int StartRow = 1;
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                            myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                        }
                        StartRow++;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                                myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                                myRange.Select();
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                if (dateTimePicker1.Visible == false && panel1.Visible == false)
                {
                    panel1.Visible = true;
                    dateTimePicker1.Visible = true;
                }
                else
                {
                    panel1.Visible = false;
                    dateTimePicker1.Visible = false;
                }
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                try
                {
                    if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        progressBar1.Maximum = 100;
                        for (int i = 0; i <= 100; i += 5)
                        {
                            progressBar1.Value = i;
                            TaskbarManager.Instance.SetProgressValue(i, 100);
                            System.Threading.Thread.Sleep(200);
                        }
                        string sql = "DELETE * FROM islemler";
                        kmt = new OleDbCommand(sql, con);
                        con.Open();
                        kmt.ExecuteNonQuery();
                        con.Close();
                        tablo.Clear();
                        Verilerigoruntule();
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi İptal Edildi", "İptal Edildi!");
                    }
                }
                catch (Exception hop)
                {
                    MessageBox.Show(hop.Message);
                }
            }
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                try
                {
                    if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        progressBar1.Maximum = 100;

                        for (int i = 0; i <= 100; i += 5)
                        {
                            progressBar1.Value = i;
                            TaskbarManager.Instance.SetProgressValue(i, 100);
                            System.Threading.Thread.Sleep(100);
                        }
                        con.Open();
                        kmt.Connection = con;
                        kmt.CommandText = "DELETE FROM islemler WHERE id=@aid";
                        kmt.Parameters.AddWithValue("@aid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        kmt.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tablo.Clear();
                        Verilerigoruntule();
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi İptal Edildi", "İptal Edildi!");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
