tnUpdate_Click(object sender, EventArgs e)
{
    // Cek dulu apakah textbox hasil sudah ada isinya atau belum (contoh validasi simpel)
    if (string.IsNullOrEmpty(txtHasil.Text))
    {
        MessageBox.Show("Hasil harus dihitung dulu sebelum update!");
        return;
    }
    // Lanjut ke query update...
}