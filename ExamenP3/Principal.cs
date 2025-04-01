namespace ExamenP3
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Hide();
            ClientForm f = new();
            f.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Hide();
            VentasForm f = new();
            f.Show();
        }

        private void principalform_closing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
