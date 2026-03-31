private void btnUpdate_Click(object sender, EventArgs e)
{
    try
    {
        Koneksi();
        conn.Open();
        string query = "UPDATE Mahasiswa SET Alamat = 'Yogyakarta' WHERE NIM = '23110100001'";
        cmd = new SqlCommand(query, conn);
        int hasil = cmd.ExecuteNonQuery();
        MessageBox.Show("Jumlah baris terpengaruh : " + hasil);
        conn.Close();
    }
    catch (Exception ex) { MessageBox.Show(ex.Message); }
}