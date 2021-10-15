using System;

namespace CititorServer.Data.Model
{
    public class Listde 
    {
        public Listde(){

        }
        public Listde(int id, int idArticulo, int cantArticulo, int subtotal, int idDiseño)
        {   
            this.id=id;
            this.idArticulo=idArticulo;
            this.cantArticulo=cantArticulo;
            this.subtotal=subtotal;
            this.idDiseño = idDiseño;
        }

        public int id{get; set;}
        public int idArticulo { get; set; }

        public int cantArticulo { get; set; }

        public int subtotal { get; set; }
        public int idDiseño {get; set;}
    }
}