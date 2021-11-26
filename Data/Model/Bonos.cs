using System;

namespace CititorServer.Data.Model
{
    public class Bono
    {
        public Bono(){

        }
        public Bono(int idBono, String co_alpha, double  porcentaje)
        {
            this.idBono = idBono;
            this.co_alpha =co_alpha;
            this.porcentaje=porcentaje;

        }
       
        
        public int idBono { get; set; }

        public String co_alpha { get; set; }

        public double porcentaje { get; set; }


    }
}