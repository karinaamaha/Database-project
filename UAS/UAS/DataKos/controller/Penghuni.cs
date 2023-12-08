using DataKos.model;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKos.controller
{
     class Penghuni
    {
        //Memangguk class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method Insert
        public bool Insert(Penghuni_m penghuni)
        {

            Boolean status = false;
            try
            {
                koneksi.OpenConection();
                koneksi.ExecuteQuery("INSERT INTO penghuni(nama,nokos,alamat,nohp) VALUES('"+penghuni.Nama + "','"+penghuni.Nokos+"','"+penghuni.Alamat+"','"+penghuni.Nohp+"')");     
                status= true;
                MessageBox.Show("Data berhasil ditambahkan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


        public bool Update(Penghuni_m penghuni, string id)
        {

            Boolean status = false;
            try
            {
                koneksi.OpenConection();
                koneksi.ExecuteQuery("UPDATE penghuni SET nama='" + penghuni.Nama + "'," +"nokos='"+ penghuni.Nokos + "',"+ "alamat='"+penghuni.Alamat +"',"+"nohp='"+penghuni.Nohp + "'WHERE id='"+id+"'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


        public bool Delete( string id)
        {

            Boolean status = false;
            try
            {
                koneksi.OpenConection();
                koneksi.ExecuteQuery("DELETE FROM penghuni WHERE id='"+ id + "'" );
                status = true;
                MessageBox.Show("Data berhasil dihapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
