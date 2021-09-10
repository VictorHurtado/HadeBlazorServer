using System;

namespace CititorServer.Data.Model
{
    public class Cliente
    {
        public Cliente(){
            
        }
        public Cliente(int dnicliente,string nombreCliente, string apellidoCliente, string correoCliente , string direccionCliente )
        {
            this.dnicliente=dnicliente;
            this.nombreCliente=nombreCliente;
            this.apellidoCliente=apellidoCliente;
            this.correoCliente=correoCliente;
            this.direccionCliente=direccionCliente;
        }

        public int dnicliente { get; set; }

        public String nombreCliente { get; set; }

        public String apellidoCliente { get; set;}

        public String correoCliente { get; set;}

        public String direccionCliente { get; set;}

    }
}
