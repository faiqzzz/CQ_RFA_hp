private void btnConnect_Click(object sender, EventArgs e)
{
    try
    {
        Koneksi();
        conn.Open();
        MessageBox.Show("Koneksi ke database berhasil");
        conn.Close();
    }
    catch (Exception ex) { MessageBox.Show(ex.Message); }
}