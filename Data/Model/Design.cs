using System;

namespace CititorServer.Data.Model
{
    public class Design
    {
        public Design(){
            
        }
        public Design(int idDiseño,string imagenDiseño,String descripcion, DateTime fechaCarga, String Tamaño, int status)
        {
            this.idDiseño=idDiseño;
            this.descripcion=descripcion;
            this.imagenDiseño=imagenDiseño;
            this.fechaCarga=fechaCarga;
            this.Tamaño=Tamaño;
            this.status=status;
        }

        public int idDiseño { get; set; }

        public String imagenDiseño { get; set; }
        public String descripcion { get; set; }


        public DateTime fechaCarga { get; set; }

        public String Tamaño { get; set;}
        public int status { get; set;}

    }
}
