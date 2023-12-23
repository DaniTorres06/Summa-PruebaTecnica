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
    Console.WriteLine("La lista de numeros esta vacia");
}
else
{
    Console.WriteLine("La Media es: " + vObjMedia.AgentA(numeros));
    Console.WriteLine("La Media armonica es de : " + vObjMedia.AgentB(numeros));
    Console.WriteLine("La Mediana es de : " + vObjMedia.AgentC(numeros));
}

Console.WriteLine(" ");
Console.WriteLine("* Funcionalidad 2 *");
Console.WriteLine(" ");

if (escaler == 0 || escaler == 1)
{
    Console.WriteLine("Se requiere un numero mayor a cero o uno para visualizar el resultado");
}
else
{
    if(escaler > 100)
    {
        Console.WriteLine("No se permite valores mayores a 100");
    }
    else
    {
        Console.WriteLine("Respuesta agente A: ");
        vObjStaircase.AgentA(escaler);
        Console.WriteLine(" ");
        Console.WriteLine("Respuesta agente B: ");
        vObjStaircase.AgentB(escaler);
        Console.WriteLine(" ");
        Console.WriteLine("Respuesta agente C: ");
        vObjStaircase.AgentC(escaler);
        Console.WriteLine(" ");
    }
}
    