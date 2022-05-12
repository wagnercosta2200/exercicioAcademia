// See https://aka.ms/new-console-template for more information
Console.WriteLine("tabuada");


    int i, n,r;

Console.WriteLine( "Digite a tabuada do numero que deseja apresentar : " );
n = int.Parse( Console.ReadLine() );

for ( i = 0; i <= 10; i++)
{
    //r = i * n;
    //Console.WriteLine(i + " x " + n +" = " +r);
   // Console.WriteLine(i + " x " + n + " = " + i*n);

    Console.WriteLine($"{n} x {i} = {i*n}");
}

