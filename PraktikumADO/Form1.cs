private void Koneksi()
{
    // Pastikan pakai @ agar backslash terbaca benar
    conn = new SqlConnection(@"Data Source=DESKTOP-DDDRHRS\RIDHOFAIQAHMAD;Initial Catalog=DBAkademiADO;Integrated Security=True");
}