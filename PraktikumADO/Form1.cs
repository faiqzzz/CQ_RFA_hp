private void btnHitungMK_Click(object sender, EventArgs e)
{
    try
    {
        Koneksi();
        conn.Open();
        cmd = new SqlCommand("SELECT COUNT(*) FROM MataKuliah", conn);
        int jumlah = (int)cmd.ExecuteScalar();
        txtHasil.Text = jumlah.ToString();
        conn.Close();
    }
    catch (Exception ex) { MessageBox.Show(ex.Message); }
}