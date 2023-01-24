using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OGRENCIMASASII
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; Database=veritabani; UId=root; Pwd='123456';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt,st;

        public Form1()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ogrenci", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        void rowVeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ders", conn);
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string selected = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select s.ogr_kimligi, o.ogr_ad ,  o.ogr_soyad, d.dersAd, s.puan from sinavsonuctablosu as s inner join ogrenci as o on o.ogr_kimlik = s.ogr_kimligi inner join ders as d on d.dersid = s.kurs_kimligi where s.ogr_kimligi = '"+selected+"' AND puan >= 3", conn);
            adapter.Fill(st);
            dataGridView2.DataSource = st;
            conn.Close();
            

            kimlikText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            AdText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SoyadText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            epostaText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            gsmText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
       

        private void AraText_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "ogr_ad LIKE '" + AraText.Text + "%'";
            dataGridView1.DataSource = dv;
            
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ogrenci(ogr_kimlik,ogr_ad,ogr_soyad,ogr_eposta,ogr_gsmno)" +
                "VALUES (@ogr_kimlik,@ogr_ad,@ogr_soyad,@ogr_eposta,@ogr_gsmno)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ogr_kimlik", kimlikText.Text);
            cmd.Parameters.AddWithValue("ogr_ad", AdText.Text);
            cmd.Parameters.AddWithValue("ogr_soyad", SoyadText.Text);
            cmd.Parameters.AddWithValue("ogr_eposta", epostaText.Text);
            cmd.Parameters.AddWithValue("ogr_gsmno", gsmText.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM ogrenci WHERE ogr_kimlik=@kimlik";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kimlik", kimlikText.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt silindi.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rowVeriGetir();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlikText.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            AdText.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            SoyadText.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            epostaText.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            gsmText.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();


        }

        private void dersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
