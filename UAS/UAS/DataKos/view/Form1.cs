using DataKos.controller;
using DataKos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKos
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        Penghuni_m penghuni = new Penghuni_m();
        string id;

        public void Tampil()
        {   
            //Query database
            DataTable.DataSource = koneksi.ShowData("SELECT * FROM penghuni");

            //Mengubah Nama Kolo,
            DataTable.Columns[0].HeaderText = "ID";
            DataTable.Columns[1].HeaderText = "Nama Penghuni";
            DataTable.Columns[2].HeaderText = "Nomor Kos";
            DataTable.Columns[3].HeaderText = "Alamat Asal";
            DataTable.Columns[4].HeaderText = "Nomor HP";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // memanggil mehthod tampil()
            Tampil();
        }

        private void Tombol_Simpan_Click(object sender, EventArgs e)
        {
            if (Nama.Text == "" || NoKos.Text == "" || Alamat.Text == "" || NoHp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Penghuni pg = new Penghuni();
                penghuni.Nama = Nama.Text;
                penghuni.Nokos = NoKos.Text;
                penghuni.Alamat= Alamat.Text;
                penghuni.Nohp= NoHp.Text;

                //masukkan data ke database
                pg.Insert(penghuni);

                // setelah insert, hapus data di form
                Nama.Text = "";
                NoKos.Text = "";
                Alamat.Text = "";
                NoHp.Text = "";

                Tampil();


            }
        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            Nama.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            NoKos.Text = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            Alamat.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            NoHp.Text = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Tombol_Ubah_Click(object sender, EventArgs e)
        {
            if (Nama.Text == "" || NoKos.Text == "" || Alamat.Text == "" || NoHp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Penghuni pg = new Penghuni();
                penghuni.Nama = Nama.Text;
                penghuni.Nokos = NoKos.Text;
                penghuni.Alamat = Alamat.Text;
                penghuni.Nohp = NoHp.Text;

                //masukkan data ke database
                pg.Update(penghuni, id);

                // setelah update, hapus data di form
                Nama.Text = "";
                NoKos.Text = "";
                Alamat.Text = "";
                NoHp.Text = "";

                Tampil();


            }

        }

        private void Tombol_Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin mau menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(pesan == DialogResult.Yes)
            {
                Penghuni pg = new Penghuni();
                pg.Delete(id);
                //setelah di Delete, maka form di kosongkan
                Nama.Text = "";
                NoKos.Text = "";
                Alamat.Text = "";
                NoHp.Text = "";
                Tampil();
            }
        }

        private void CariData_TextChanged(object sender, EventArgs e)
        {
            //Query Search Data
            DataTable.DataSource = koneksi.ShowData("SELECT * FROM penghuni WHERE nama LIKE '%' '"+ CariData.Text + "' '%' OR nokos LIKE '%' '" + CariData.Text+"' '%'");
        }

  
    }
}
