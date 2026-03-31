private void btnHitungDosen_Click(object sender, EventArgs e)
{
    try
    {
        Koneksi();
        if (conn.State == ConnectionState.Closed) conn.Open();
        cmd = new SqlCommand("SELECT COUNT(*) FROM Dosen", conn);
        int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
        txtHasil.Text = "Jumlah Dosen: " + jumlah.ToString();
    }
    catch (Exception ex) { MessageBox.Show(ex.Message); }
    finally { conn.Close(); }
}