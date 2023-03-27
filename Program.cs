using Torta;

Tortaa torta1 = new Tortaa();
torta1.nombre = "Torta de oreo";
torta1.tamaño = "Grande";
torta1.AgregarIngrediente("Azucar", 4,15000);
torta1.AgregarIngrediente("Cacao", 10,51000);
torta1.AgregarIngrediente("Harina", 10,60000);

Console.WriteLine("Ingredientes : ");
torta1.ListaIngrediente();
Console.WriteLine("Total cantidad : {0} ", torta1.CantidadTotal());
Console.WriteLine("Cuesta un total de  : ${0} ", torta1.CalcularCosto());





