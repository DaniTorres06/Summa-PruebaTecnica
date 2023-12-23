// See https://aka.ms/new-console-template for more information
using Summa_PruebaTecnica;
Console.WriteLine("**************************");
Console.WriteLine("* SUMMA - Prueba Tecnica *");
Console.WriteLine("**************************");
Console.WriteLine(" ");


List<double> vLstNumbers = new List<double> { 10, 6, 15, 4 };
int vIntEscaler = 4;

Media vObjMedia = new Media();
Staircase vObjStaircase = new Staircase();

Console.WriteLine("* Funcionalidad 1 *");
Console.WriteLine(" ");

if (vLstNumbers.Count == 0)
{
    Console.WriteLine("The number list is empty");
}
else
{
    Console.WriteLine("The Media is: " + vObjMedia.AgentA(vLstNumbers));
    Console.WriteLine("The Media armonica is : " + vObjMedia.AgentB(vLstNumbers));
    Console.WriteLine("The Mediana is : " + vObjMedia.AgentC(vLstNumbers));
}

Console.WriteLine(" ");
Console.WriteLine("* Funcionalidad 2 *");
Console.WriteLine(" ");

if (vIntEscaler == 0 || vIntEscaler == 1)
{
    Console.WriteLine("A number greater than zero or one is required to display the result");
}
else
{
    if (vIntEscaler > 100)
    {
        Console.WriteLine("No se permite valores mayores a 100");
    }
    else
    {
        Console.WriteLine("Reply agent A: ");
        Console.WriteLine("" + vObjStaircase.AgentA(vIntEscaler));
        Console.WriteLine(" ");
        Console.WriteLine("Reply agent B: ");
        Console.WriteLine("" + vObjStaircase.AgentB(vIntEscaler));
        Console.WriteLine(" ");
        Console.WriteLine("Reply agent C: ");
        Console.WriteLine("" + vObjStaircase.AgentC(vIntEscaler));
        vObjStaircase.AgentC(vIntEscaler);
        Console.WriteLine(" ");
    }
}
