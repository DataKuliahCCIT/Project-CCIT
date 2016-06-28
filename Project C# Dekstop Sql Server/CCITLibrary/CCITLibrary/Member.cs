﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CCITLibrary
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
            cmbkjrsan.Items.Add("--- PILIH JURUSAN ---");
            cmbkjrsan.Items.Add("TI REGULER");
            cmbkjrsan.Items.Add("TIPS");
            cmbkjrsan.Items.Add("CCIT PNJ");

            cmbkjrsan_edit.Items.Add("TI REGULER");
            cmbkjrsan_edit.Items.Add("TIPS");
            cmbkjrsan_edit.Items.Add("CCIT PNJ");

            txtnim_hapus.Enabled = false;
            txtnama_hapus.Enabled = false;
        }
        Koneksi conn = new Koneksi();
        SqlConnection koneksi;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string sql = null;
        DataView dv;

        private void Form1_Load(object sender, EventArgs e)
        {
            hapus_edit();
            hapus_member();

            cmbkjrsan.SelectedIndex = 0;

            AutoGeneratedID autoid = new AutoGeneratedID();
            string id_member = autoid.AutoIDMember();
            txtidmember.Text = id_member;
            txtidmember.ReadOnly = true;
            try
            {
                koneksi = conn.con();
                koneksi.Open();
                sql = "Select * from tb_Member order by id_member desc";
                adapter.SelectCommand = new SqlCommand(sql, koneksi);
                adapter.Fill(ds, "Member");
                dv = new DataView();
                dv.Table = ds.Tables[0];
                dataGridView1.DataSource = dv;
                dataGridView2.DataSource = dv;
                dataGridView3.DataSource = dv;
                dataGridView4.DataSource = dv;
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    public void hapus()
    {
        txtnama.Text = "";
        txtnim.Text = "";
        txtkelas.Text = "";
        txttlpn.Text = "";
        riscalmt.Text = "";
        cmbkjrsan.SelectedIndex = 0;
        radioButton1.Checked = false;
        radioButton2.Checked = false;
    }
    public void hapus_edit()
    {
        txtnama_edit.Enabled = false;
        txtnim_edit.Enabled = false;
        txtkelas_edit.Enabled = false;
        txttelp_edit.Enabled = false;
        richalmt_edit.Enabled = false;
        cmbkjrsan_edit.SelectedIndex = 0;
        cmbkjrsan_edit.Enabled = false;
        radioButton3.Enabled = false;
        radioButton4.Enabled = false;
        button4.Enabled = false;
        button3.Enabled = false;
        txtidmember_edit.Enabled = true;
        button5.Enabled = true;

        txtnama_edit.Text = "";
        txtnim_edit.Text = "";
        txtkelas_edit.Text = "";
        txttelp_edit.Text = "";
        richalmt_edit.Text = "";
        cmbkjrsan_edit.SelectedIndex = 0;
        radioButton3.Checked = false;
        radioButton4.Checked = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        try
        {
            String nama = txtnama.Text;
            String nim = txtnim.Text;
            String kelas = txtkelas.Text;
            String alamat = riscalmt.Text;
            String no_telp = txttlpn.Text;

            Regex reg = new Regex(@"^[A-Z a-z]+$");
            Match match_huruf = reg.Match(nama);
            Regex reg1 = new Regex(@"^[0-9]+$");
            Match match_angka = reg1.Match(nim);
            Match match_angka1 = reg1.Match(no_telp);

            if (nim == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnim, "Nim Tidak Boleh Kosong!");
                var warning = MessageBox.Show("Nim Tidak Boleh Kosong!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (!match_angka.Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnim, "Nim Harus Berupa Angka!");
                var warning = MessageBox.Show("Nim Harus Berupa Angka!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (nim.Length < 9)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnim, "Nim Minimal Harus 9 Digit Angka!");
                var warning = MessageBox.Show("Nim Minimal Harus 9 Digit Angka!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (nim.Length > 11)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnim, "Nim Maksimal Harus 11 Digit Angka!");
                var warning = MessageBox.Show("Nim Maksimal Harus 11 Digit Angka!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (nama == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnama, "Nama Tidak Boleh Kosong!");
                var warning = MessageBox.Show("Nama Tidak Boleh Kosong!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (!match_huruf.Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnama, "Nama Harus Berupa Huruf!");
                var warning = MessageBox.Show("Nama Harus Berupa Huruf!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (nama.Length < 3)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnama, "Nama Minimal 3 Huruf!");
                var warning = MessageBox.Show("Nama Minimal 3 Huruf!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (nama.Length > 30)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnama, "Nama Maksimal 30 Huruf!");
                var warning = MessageBox.Show("Nama Maksimal 30 Huruf!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (kelas == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtkelas, "Kelas Tidak Boleh Kosong!");
                var warning = MessageBox.Show("Kelas Tidak Boleh Kosong!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (kelas.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtkelas, "Kelas Minimal 4 Character!");
                var warning = MessageBox.Show("Kelas Minimal 4 Character!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (kelas.Length > 6)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtkelas, "Kelas Maksimal 5 Character!");
                var warning = MessageBox.Show("Kelas Maksimal 5 Character!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (cmbkjrsan.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbkjrsan, "Jurusan Harus Dipilih!");
                var warning = MessageBox.Show("Jurusan Harus Dipilih!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (alamat == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(riscalmt, "Alamat Tidak Boleh Kosong!");
                var warning = MessageBox.Show("Alamat Tidak Boleh Kosong!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (alamat.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(riscalmt, "Alamat Minimal 4 Huruf!");
                var warning = MessageBox.Show("Alamat Minimal 4 Huruf!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (alamat.Length > 50)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(riscalmt, "Alamat Maksimal 50 Character!");
                var warning = MessageBox.Show("Alamat Maksimal 50 Character!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (no_telp == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txttlpn, "No Telp/Hp Tidak Boleh Kosong!");
                var warning = MessageBox.Show("No Telp/Hp Tidak Boleh Kosong!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (!match_angka1.Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txttlpn, "No Telp/Hp Harus Berupa Angka!");
                var warning = MessageBox.Show("No Telp/Hp Harus Berupa Angka!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (no_telp.Length < 3)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txttlpn, "No Telp/Hp Minimal 3 Digit Angka!");
                var warning = MessageBox.Show("No Telp/Hp Minimal 3 Digit Angka!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else if (no_telp.Length > 13)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txttlpn, "No Telp/Hp Maksimal 13 Digit Angka!");
                var warning = MessageBox.Show("No Telp/Hp Maksimal 13 Digit Angka!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (warning == DialogResult.Cancel)
                {
                    hapus();
                    errorProvider1.Clear();
                }
            }
            else
            {
                string jk = "";
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        jk = "Pria";
                    }
                    else
                    {
                        jk = "Wanita";
                    }
                    koneksi = conn.con();
                    SqlCommand command = new SqlCommand("insert into tb_Member (id_member, NIM, nama, kelas, jurusan, alamat, no_telp, jenis_kelamin) values ('" + txtidmember.Text + "','" + txtnim.Text + "','" + txtnama.Text + "','" + txtkelas.Text + "','" + cmbkjrsan.SelectedItem + "','" + riscalmt.Text + "','" + txttlpn.Text + "','" + jk + "');", koneksi);
                    adapter = new SqlDataAdapter("select * from tb_Member order by id_member desc", koneksi);
                    koneksi.Open();
                    DataTable dtMember = new DataTable();
                    command.ExecuteNonQuery();
                    dataGridView1.DataSource = dtMember;
                    dataGridView2.DataSource = dtMember;
                    dataGridView3.DataSource = dtMember;
                    adapter.SelectCommand.ExecuteNonQuery();
                    adapter.Fill(dtMember);
                    MessageBox.Show("Data success ditambah");
                 
                    AutoGeneratedID autoid = new AutoGeneratedID();
                    string id_member = autoid.AutoIDMember();
                    txtidmember.Text = id_member;
                    txtidmember.ReadOnly = true;
                    //dataGridView1.DataSource = dtMember;
                    errorProvider1.Clear();
                    hapus();
                    koneksi.Close();
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(radioButton2, "Jenis Kelamin Harus Dipilih!");
                    var warning = MessageBox.Show("Jenis Kelamin Harus Dipilih!", "Perhatian", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (warning == DialogResult.Cancel)
                    {
                        hapus();
                        errorProvider1.Clear();
                    }
                }
            }
        }
        catch (SqlException se)
        {
            MessageBox.Show(se.Message);
        }
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        hapus();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    public bool BindRadio(string gender)
    {

        bool result = false;
        if (gender == "Pria")
        {
            result = true;
        }
        return result;
    }
    public void edit()
    {
        txtnama_edit.Enabled = true;
        txtnim_edit.Enabled = true;
        txtkelas_edit.Enabled = true;
        txttelp_edit.Enabled = true;
        richalmt_edit.Enabled = true;
        cmbkjrsan_edit.Enabled = true;
        radioButton3.Enabled = true;
        radioButton4.Enabled = true;
        button4.Enabled = true;
        button3.Enabled = true;
        txtidmember_edit.Enabled = false;
        button5.Enabled = false;
    }
    private void button5_Click(object sender, EventArgs e)
    {
        SqlParameter sqlP;

        koneksi = conn.con();
        koneksi.Open();
        String id_member = txtidmember_edit.Text;
        SqlCommand command = new SqlCommand("SELECT * FROM tb_Member WHERE id_member = @id_member", koneksi); 
        sqlP = command.Parameters.Add("@id_member", SqlDbType.VarChar, 15);
        sqlP.Value = id_member;
        try
        {
            SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtnim_edit.Text = reader[1].ToString();
                    txtnama_edit.Text = reader[2].ToString();
                    txtkelas_edit.Text = reader[3].ToString();
                    cmbkjrsan_edit.SelectedItem = reader[4].ToString();
                    richalmt_edit.Text = reader[5].ToString();
                    txttelp_edit.Text = reader[6].ToString();
                    bool result = BindRadio(reader[7].ToString());
                    if (result)
                    {
                        radioButton3.Select();
                    }
                    else
                    {
                        radioButton4.Select();
                    }
                    edit();
                }
        }
        catch (Exception )
        {
            MessageBox.Show("Gagal");
        }
        finally
        {
            koneksi.Close();
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        hapus_edit();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        string id = txtidmember_edit.Text;
        string nim = txtnim_edit.Text;
        string nama = txtnama_edit.Text;
        string kelas = txtkelas_edit.Text;
        string jurusan = cmbkjrsan_edit.SelectedItem.ToString();
        string alamat = richalmt_edit.Text;
        string telp = txttelp_edit.Text;
        String jk = null;
        if (radioButton3.Checked)
        {
            jk = "Pria";
        }
        if (radioButton4.Checked)
        {
            jk = "Wanita";
        }
        koneksi = conn.con();
        koneksi.Open();
        var peringatan = MessageBox.Show("Apakah Anda Ingin Benar-Benar Mengubah Data Ini!", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (peringatan == DialogResult.Yes)
        {
            try
            {
                SqlCommand sqlupdate = new SqlCommand("update tb_Member set NIM = @nim,  nama = @nama, kelas = @kelas, jurusan = @jurusan, alamat = @alamat, no_telp = @telp, jenis_kelamin = @jk where id_member = @id", koneksi);
                using (sqlupdate)
                {
                    sqlupdate.Parameters.AddWithValue("@nim", nim);
                    sqlupdate.Parameters.AddWithValue("@nama", nama);
                    sqlupdate.Parameters.AddWithValue("@kelas", kelas);
                    sqlupdate.Parameters.AddWithValue("@jurusan", jurusan);
                    sqlupdate.Parameters.AddWithValue("@alamat", alamat);
                    sqlupdate.Parameters.AddWithValue("@telp", telp);
                    sqlupdate.Parameters.AddWithValue("@jk", jk);
                    sqlupdate.Parameters.AddWithValue("@id", id);
                    int result = sqlupdate.ExecuteNonQuery();
                    if (result != 0)
                    {
                        adapter = new SqlDataAdapter("select * from tb_Member order by id_member desc", koneksi);
                        DataTable dtMember = new DataTable();
                        sqlupdate.ExecuteNonQuery();
                        dataGridView1.DataSource = dtMember;
                        dataGridView2.DataSource = dtMember;
                        dataGridView3.DataSource = dtMember;
                        adapter.SelectCommand.ExecuteNonQuery();
                        adapter.Fill(dtMember);
                        MessageBox.Show("Data Sukses Diupdate");
                        hapus_edit();
                        koneksi.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data Member Gagal Diubah!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal");
            }
            finally
            {
                koneksi.Close();
            }
        }
    }

    public void hapus_member()
    {
        button7.Enabled = false;
        button8.Enabled = false;
        txtidmember_hapus.Enabled = true;
        button6.Enabled = true;
        txtnama_hapus.Text = "";
        txtidmember_hapus.Text = "";
        txtnim_hapus.Text = "";
    }
    public void hapus_member1()
    {
        button6.Enabled = false;
        txtidmember_hapus.Enabled = false;
        button7.Enabled = true;
        button8.Enabled = true;
    }
    private void button6_Click(object sender, EventArgs e)
    {
        SqlParameter sqlP;

        koneksi = conn.con();
        koneksi.Open();
        String id_member = txtidmember_hapus.Text;
        SqlCommand command = new SqlCommand("SELECT * FROM tb_Member WHERE NIM = @id_member", koneksi);
        sqlP = command.Parameters.Add("@id_member", SqlDbType.VarChar, 15);
        sqlP.Value = id_member;
        try
        {
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtnim_hapus.Text = reader[1].ToString();
                txtnama_hapus.Text = reader[2].ToString();
                hapus_member1(); 
                try
                {
                    koneksi = conn.con();
                    koneksi.Open();
                    SqlCommand sqlcari = new SqlCommand("select * from tb_Member", koneksi);
                    sqlcari = new SqlCommand(sql, koneksi);
                    if (sqlcari != null)
                    {
                        adapter.SelectCommand = sqlcari;
                        adapter.Fill(ds, "Sort DataView");
                        adapter.Dispose();
                        sqlcari.Dispose();
                        koneksi.Close();

                        dv = new DataView(ds.Tables[0], "NIM = '" + id_member + "'", "id_member Desc", DataViewRowState.CurrentRows);

                        dataGridView3.DataSource = dv;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ditemukan!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    koneksi.Close();
                }
            }
            else
            {
                MessageBox.Show("Tidak Ditemukan!");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Gagal");
        }
        finally
        {
            koneksi.Close();
        }
    }

    private void button8_Click(object sender, EventArgs e)
    {
        koneksi = conn.con();
        koneksi.Open();
        String id_member = txtidmember_hapus.Text;
        string nim = txtnim_hapus.Text;
        string nama = txtnama_hapus.Text;
        var peringatan = MessageBox.Show("Apakah Anda Ingin Benar-Benar Menghapus Data Ini!", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (peringatan == DialogResult.Yes)
        {
            SqlCommand sqldelete = new SqlCommand("delete from tb_Member WHERE id_member = @id_member", koneksi);
            using (sqldelete)
            {
                sqldelete.Parameters.AddWithValue("@nim", nim);
                sqldelete.Parameters.AddWithValue("@nama", nama);
                sqldelete.Parameters.AddWithValue("@id_member", id_member);
                int result = sqldelete.ExecuteNonQuery();
                if (result != 0)
                {
                    adapter = new SqlDataAdapter("select * from tb_Member order by id_member desc", koneksi);
                    DataTable dtMember = new DataTable();
                    sqldelete.ExecuteNonQuery();
                    dataGridView1.DataSource = dtMember;
                    dataGridView2.DataSource = dtMember;
                    dataGridView3.DataSource = dtMember;
                    adapter.SelectCommand.ExecuteNonQuery();
                    adapter.Fill(dtMember);
                    MessageBox.Show("Data Member Berhasil Dihapus!");
                    hapus_member();
                    koneksi.Close();
                }
                else
                {
                    MessageBox.Show("Data Member Gagal Dihapus!");
                }
            }
        }

    }

    private void button7_Click(object sender, EventArgs e)
    {
        string sql1 = null;
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        DataView dv1;
        hapus_member();
        koneksi = conn.con();
        koneksi.Open();
        sql1 = "Select * from tb_Member order by id_member desc";
        adapter1.SelectCommand = new SqlCommand(sql1, koneksi);
        adapter1.Fill(ds1, "Member");
        dv1 = new DataView();
        dv1.Table = ds1.Tables[0];
        dataGridView3.DataSource = dv1;
        koneksi.Close();
    }

    private void button9_Click(object sender, EventArgs e)
    {
        try
        {
            string nim = txtnim_cari.Text;
            koneksi = conn.con();
            koneksi.Open();
            SqlCommand sqlcari = new SqlCommand("select * from tb_Member", koneksi);
            sqlcari = new SqlCommand(sql, koneksi);
            if (sqlcari != null)
            {
                adapter.SelectCommand = sqlcari;
                adapter.Fill(ds, "Sort DataView");
                adapter.Dispose();
                sqlcari.Dispose();
                koneksi.Close();

                dv = new DataView(ds.Tables[0], "NIM = '" + nim + "'", "id_member Desc", DataViewRowState.CurrentRows);

                dataGridView4.DataSource = dv;
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
            finally
            {
                koneksi.Close();
            }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        MenuUtama mu = new MenuUtama();
        mu.Show();
        this.Hide();
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void button10_Click(object sender, EventArgs e)
    {
        string sql1 = null;
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        DataView dv1;
        hapus_member();
        koneksi = conn.con();
        koneksi.Open();
        sql1 = "Select * from tb_Member order by id_member desc";
        adapter1.SelectCommand = new SqlCommand(sql1, koneksi);
        adapter1.Fill(ds1, "Member");
        dv1 = new DataView();
        dv1.Table = ds1.Tables[0];
        dataGridView4.DataSource = dv1;
    }
    }
}
