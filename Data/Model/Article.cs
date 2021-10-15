using System;

namespace CititorServer.Data.Model
{
    public class Article
    {
        public Article(){

        }
        public Article(int idArticulo,string tipoArticulo ,string descripcionArticulo, int cantArticulosDispo, int valor, string imagenArticulo, string tallaArticulo )
        {
            this.idArticulo=idArticulo;
            this.tipoArticulo = tipoArticulo;
            this.descripcionArticulo=descripcionArticulo;
            this.cantArticulosDispo=cantArticulosDispo;
            this.valor=valor;
            this.imagenArticulo = imagenArticulo;
            this.tallaArticulo = tallaArticulo;
        }

        public int idArticulo { get; set; }

        public String tipoArticulo { get; set; }

        public String descripcionArticulo { get; set; }

        public int cantArticulosDispo { get; set;}

        public int valor { get; set;}

        public String imagenArticulo { get; set; }

        public String tallaArticulo { get; set; }

    }
}