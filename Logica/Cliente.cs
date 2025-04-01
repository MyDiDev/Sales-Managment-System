using Datos;

namespace Logica
{
    public class Cliente
    {
        public string Nombre;
        public string Apellido;
        public string Correo;
        public string Telefono;

        public Cliente(string nombre, string apellido, string correo, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
        }

        public Cliente(){}

        ~Cliente(){}

        conn conn = new();

        public void agregrarCliente() => conn.addClient(Nombre, Apellido, Correo, Telefono);
        public int getIdCliente(string Nombre, string Apellido) => conn.getId(Nombre, Apellido);
        public List<string> getNombres() => conn.getClientsName();
        public List<string> getApellidos() => conn.getClientsSname();
    }
}
