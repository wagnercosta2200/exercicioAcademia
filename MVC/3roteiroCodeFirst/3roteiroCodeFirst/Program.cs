using _3roteiroCodeFirst;

//string nome = "170";

//Modelo tmp = new Modelo() { Nome = nome };
//tmp.Salvar();



//var listaModelos = Modelo.Todos();

//Console.WriteLine("Lista de modelos");
//foreach (var item in listaModelos) 


//{
//    Console.WriteLine(item.Id);
//   Console.WriteLine(item.Nome);

//}

//var listaModelos = Modelo.Todos();

//var primeiroModelo = listaModelos.First();
//Veiculo tmp2 = new Veiculo() { Nome="Honda",Modelo=listaModelos.First()};
//tmp2.Salvar();

//Console.WriteLine("Lista de Veiculos");
//foreach(var item in Veiculo.Todos())
//{
//    Console.WriteLine(item.Id);
//    Console.WriteLine(item.Nome);
//    Console.WriteLine(item.Modelo.Nome) ;
//}

//BaseContext contexto = new BaseContext();
//var resultado = contexto.Modelos.Where(m => m.Nome.Contains("Honda")).ToList();
//while (resultado.Count > 0)
//{
//    contexto.Modelos.Remove(resultado[0]);
//    contexto.SaveChanges();
//}


BaseContext contexto= new BaseContext();
var resultado = contexto.Modelos.Where(n=>n.Nome.Contains("XTZ")).ToList();

Console.WriteLine(resultado[0].Id);
Console.WriteLine(resultado[0].Nome);

contexto.Modelos.Remove(resultado[0]);

contexto.SaveChanges();

Console.WriteLine("total de modelos: " + Modelo.Todos().Count);

