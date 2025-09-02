    namespace project_hitung_kalori_snack
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            // Event ini boleh tetap kosong atau dihapus jika tidak digunakan
            private void textBox1_TextChanged(object sender, EventArgs e)
            {
            }

            private void button1_Click(object sender, EventArgs e)
            {
                // Validasi input: pastikan semua input bisa di-parse
                if (!int.TryParse(textBoxJumlah.Text, out int jumlah) ||
                    !double.TryParse(textBoxKalori.Text, out double kaloriPerSnack) ||
                    !double.TryParse(textBoxTarget.Text, out double targetKalori))
                {
                    MessageBox.Show("Mohon masukkan angka yang valid di semua kolom.",
                                    "Input tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hitung total kalori
                double totalKalori = jumlah * kaloriPerSnack;

                // Tampilkan hasil di label dalam GroupBox
                if (totalKalori > targetKalori)
                {
                    labelHasil.Text = "NAY! Kalorimu berlebih";
                }
                else
                {
                    labelHasil.Text = "YAY! Selamat Makan";
                }
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }