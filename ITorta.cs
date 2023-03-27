namespace Torta;
using System.Collections.Generic;

interface IPastel{

    public string nombre{get;set;}
    public string tamaño{get;set;}

    public List<Ingrediente> ingredientes{get;set;} 

    public void AgregarIngrediente(string nombre, int cantidad, int precio);

    public int CalcularCosto();
    
    

}