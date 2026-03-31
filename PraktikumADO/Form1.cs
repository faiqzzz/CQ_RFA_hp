private void btnUpdateSKS_Click(object sender, EventArgs e)
{
    try
    {
        Koneksi();
        if (conn.State == ConnectionState.Closed) conn.Open();
        string query = "UPDATE MataKuliah SET SKS = 4 WHERE KodeMK = 'IF210101'";
        cmd = new SqlCommand(query, conn);
        int hasil = cmd.ExecuteNonQuery();
        MessageBox.Show("SKS berhasil diupdate! Baris: " + hasil);
    }
    catch (Exception ex) { MessageBox.Show(ex.Message); }
    finally { conn.Close(); }
}