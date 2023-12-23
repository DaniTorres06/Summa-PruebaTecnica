// See https://aka.ms/new-console-template for more information
using Summa_PruebaTecnica;
Console.WriteLine("**************************");
Console.WriteLine("* SUMMA - Prueba Tecnica *");
Console.WriteLine("**************************");
Console.WriteLine(" ");


List<double> numeros = new List<double> { 10, 6, 15, 4 };
int escaler = 30;

Media vObjMedia = new Media();
Staircase vObjStaircase = new Staircase();

Console.WriteLine("* Funcionalidad 1 *");
Console.WriteLine(" ");

if (numeros.Count == 0)
{
    Console.WriteLine("The number list is empty");
}
else
{
    Console.WriteLine("The Media is: " + vObjMedia.AgentA(numeros));
    Console.WriteLine("The Media armonica is : " + vObjMedia.AgentB(numeros));
    Console.WriteLine("The Mediana is : " + vObjMedia.AgentC(numeros));
}

Console.WriteLine(" ");
Console.WriteLine("* Funcionalidad 2 *");
Console.WriteLine(" ");

if (escaler == 0 || escaler == 1)
{
    Console.WriteLine("A number greater than zero or one is required to display the result");
}
else
{
    if(escaler > 100)
    {
        Console.WriteLine("No se permite valores mayores a 100");
    }
    else
    {
        Console.WriteLine("Reply agent A: ");
        vObjStaircase.AgentA(escaler);
        Console.WriteLine(" ");
        Console.WriteLine("Reply agent B: ");
        vObjStaircase.AgentB(escaler);
        Console.WriteLine(" ");
        Console.WriteLine("Reply agent C: ");
        vObjStaircase.AgentC(escaler);
        Console.WriteLine(" ");
    }
}
    