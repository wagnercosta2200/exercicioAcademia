// See https://aka.ms/new-console-template for more information
Console.WriteLine("13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. \n" +"Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida)";
/// <summary>
/// Variaveis do exercicio
/// </summary>

double salarioMinimo,salarioEmpregado, custo, qtdbicicleta,precoVenda,comissao;

/// <summary>
/// Digita o salario minimo
/// </summary>

Console.WriteLine("Digite o valor do salario minimo: ");
salarioMinimo =double.Parse(Console.ReadLine());


Console.WriteLine("Preço de custo de cada bicicleta:  ");
custo = double.Parse(Console.ReadLine());


Console.WriteLine("Digite o numer de bicicleta vendidas pelo vendedor: ");
qtdbicicleta = double.Parse(Console.ReadLine());
/// <summary>
/// calculo da comissão do vendedor
/// </summary>
precoVenda = custo*1.5;
salarioEmpregado = (salarioMinimo * 2) + (custo * 0.15 *qtdbicicleta);

Console.WriteLine("O salário final do vendedor é + "+salarioEmpregado);
