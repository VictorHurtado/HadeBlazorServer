using System;

namespace CititorServer.Data.Model
{
    public class Article
    {
        public Article(){
            
        }
        public Article(int idArticulo,string descripcionArticulo, int cantArticulosDispo, int valor )
        {
            this.idArticulo=idArticulo;
            this.descripcionArticulo=descripcionArticulo;
            this.cantArticulosDispo=cantArticulosDispo;
            this.valor=valor;
        }

        public int idArticulo { get; set; }

        public String descripcionArticulo { get; set; }

        public int cantArticulosDispo { get; set;}

        public int valor { get; set;}

    }
}
