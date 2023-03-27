namespace Torta;

    public class Ingrediente
    {
        public string nombre{get;set;}

        public int cantidad{get;set;}
        public int precio{get;set;}

        public Ingrediente(string nombre, int cantidad, int precio){
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }
        
    }
