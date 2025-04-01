using Logica;

namespace ExamenP3
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
        }

        Cliente c = new Cliente();
        private List<string> names;
        private List<string> sname;

        private void VentasForm_Load(object sender, EventArgs e)
        {
            fechaEntrega.MinDate = DateTime.Now;
            fechaRetiro.MinDate = DateTime.Now;

            foreach (string n in c.getNombres())
            {
                if (!nameClient.Items.Contains(n)) nameClient.Items.Add(n);
            }
            foreach (string a in c.getApellidos())
            {
                if (!apellidoClient.Items.Contains(a)) apellidoClient.Items.Add(a);
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            string nombre = nameClient.Text;
            string apellido = apellidoClient.Text;
            DateTime fechaVenta = ventaFecha.Value;
            int producVendidos = (int)cantProductoVendidos.Value;
            int productosCantidad = (int)cantProductos.Value;
            decimal priceTotal = Convert.ToDecimal(precioTotal.Text);
            string methodPago = metodoPago.Text;
            string statePago = estadoPago.Text;
            string documentoBack = docRespaldo.Text;
            DateTime dateEntrega = fechaEntrega.Value;
            DateTime dateRetiro = fechaRetiro.Value;

            MessageBox.Show(statePago);

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(methodPago) || string.IsNullOrEmpty(statePago) || string.IsNullOrEmpty(documentoBack))
            {
                errorLabel.Text = "llene las entradas";
                return;
            }

            try
            {
                int id = c.getIdCliente(nombre, apellido);
                Venta v = new Venta(id, fechaVenta, producVendidos, productosCantidad, priceTotal, methodPago, statePago, documentoBack, dateEntrega, dateRetiro);
                v.agregarVenta();
                MessageBox.Show("Venta Agregada Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                principal f = new();
                f.Show();
            }
            catch (Exception) {
                errorLabel.Text = "Verifique las credenciales ingresadas";
            }
        }


        private void VentasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            principal f = new();
            f.Show();
        }
    }
}
