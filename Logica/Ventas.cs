using Datos;

namespace Logica
{
    public class Venta
    {
        public int IdCliente;
        public DateTime fechaVenta;
        public int productosVendidos;
        public int cantidadProductos;
        public decimal precioTotal;
        public string metodoPago;
        public string estadoVenta;
        public string documentoResplado;
        public DateTime fechaEntrega;
        public DateTime fechaRetiro;

        public Venta(int idCliente, DateTime fechaVenta, int productosVendidos, int cantidadProductos, decimal precioTotal, string metodoPago, string estadoVenta, string documentoResplado, DateTime fechaEntrega, DateTime fechaRetiro)
        {
            IdCliente = idCliente;
            this.fechaVenta = fechaVenta;
            this.productosVendidos = productosVendidos;
            this.cantidadProductos = cantidadProductos;
            this.precioTotal = precioTotal;
            this.metodoPago = metodoPago;
            this.estadoVenta = estadoVenta;
            this.documentoResplado = documentoResplado;
            this.fechaEntrega = fechaEntrega;
            this.fechaRetiro = fechaRetiro;
        }

        ~Venta() { }

        conn conn = new();
        public void agregarVenta() => conn.addVenta(IdCliente, fechaVenta, productosVendidos, cantidadProductos, precioTotal, metodoPago, estadoVenta, documentoResplado, fechaEntrega, fechaRetiro); 
    }
}
