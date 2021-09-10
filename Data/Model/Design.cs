using System;

namespace CititorServer.Data.Model
{
    public class Design
    {
        public Design(){
            
        }
        public Design(int idDiseño,string imagenDiseño, String fechaCarga, String Tamaño )
        {
            this.idDiseño=idDiseño;
            this.imagenDiseño=imagenDiseño;
            this.fechaCarga=fechaCarga;
            this.Tamaño=Tamaño;
        }

        public int idDiseño { get; set; }

        public String imagenDiseño { get; set; }

        public String fechaCarga { get; set; }

        public String Tamaño { get; set;}

    }
}
