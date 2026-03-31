private void btnInsertProdi_Click(object sender, EventArgs e)
{
    try
    {
        Koneksi();
        if (conn.State == ConnectionState.Closed) conn.Open();
        string query = "INSERT INTO ProgramStudi VALUES ('MI01','Manajemen Informatika')";
        cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Data Prodi berhasil ditambahkan!");
    }
    catch (Exception ex) { MessageBox.Show(ex.Message); }
    finally { conn.Close(); }
}