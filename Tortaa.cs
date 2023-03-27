namespace Torta{
    
    public class Tortaa : IPastel
     {
        public string nombre {get;set;}
        public string tamaño{get;set;}

        public List<Ingrediente> ingredientes{get;set;} = new List<Ingrediente>();


        public void AgregarIngrediente(string nombre, int cantidad, int precio)
        {
            ingredientes.Add(new Ingrediente(nombre, cantidad, precio));

        }

        public int CantidadTotal(){
            int total = 0;
            foreach(Ingrediente i in ingredientes){
                total+=i.cantidad;
            }
            return total;
        }

        public void ListaIngrediente(){
            foreach(Ingrediente i in ingredientes){
                Console.WriteLine("{0} x {1} (${2})", i.nombre, i.cantidad, i.precio);
            }
        }

        public int CalcularCosto(){
            int total=0;
            foreach (Ingrediente i in ingredientes) {
            total += i.precio * i.cantidad;
        }
        return total;

        }

    }
}