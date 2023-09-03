// See https://aka.ms/new-console-template for more information

Console.WriteLine("calculador de indicie de imc");

Console.WriteLine("Digite seu peso");
    
    double p = Int32.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura");
   
   double a = Int32.Parse(Console.ReadLine());


double imc = (a * a) / p;


if (imc == 18)
{
    Console.WriteLine("seu peso esta otimo");
}


else if (imc < 11)
{
    Console.WriteLine("seu peso esta baixo");
}

else if (imc < 24)
{
    Console.WriteLine("esta acima do peso");
}
Console.WriteLine(imc);