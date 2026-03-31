private void btnHitungMhs_Click(object sender, EventArgs e)
{
    try
    {
        Koneksi();
        conn.Open();
        string query = "SELECT COUNT(*) FROM Mahasiswa";
        cmd = new SqlCommand(query, conn);
        int jumlah = (int)cmd.ExecuteScalar();
        txtHasil.Text = jumlah.ToString();
        conn.Close();
    }
    catch (Exception ex) { MessageBox.Show(ex.Message); }
}