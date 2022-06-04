// See https://aka.ms/new-console-template for more information
Console.WriteLine("Modelagem de Vendas");

//Modelagem Lógica do Sistema de Vendas

//Cliente(codCliente, nome, rua, numero, complemento, cep, cidade, estado, fone)

//Vendedor(codVendedor, nome, fone, senha)

//Prateleira(codPrateleira, localizacao)

//Produto(codProduto, codigoBarras, descricao, codPrateleira)
//    codPrateleira referencia Prateleira

//Venda(dataNotafiscal, numeroNotaFiscal, codProduto, codVendedor, codCliente)
//    codProduto referencia Produto
//    codVendedor referencia Vendedor
//    codCliente referencia Cliente


//Entidade = classe
//Atributo/Coluna se for uma chave estrangeira, no diagrama fica subentendido
//Relacionamento indica quem visita quem (chave primária visita outra entidade  
//                                        como chave estrangeira)
//    -Uma chave estrangeira deve ser uma chave primária na sua entidade/classe
//    de origem
//Cardinalidade: mostra como se dará a visita (quem terá a chave estrangeira)

public class Cliente
{
    int codCliente;
    string nomeCliente;
    string rua;
    int numero;
    string complemento;
    int cep;
    string cidade;
    string estado;
    int fone;

    public Cliente(int codCliente, string nomeCliente, string rua, int numero, string complemento, int cep, string cidade, string estado, int fone)
    {
        this.codCliente = codCliente;
        this.nomeCliente = nomeCliente;
        this.rua = rua;
        this.numero = numero;
        this.complemento = complemento;
        this.cep = cep;
        this.cidade = cidade;
        this.estado = estado;
        this.fone = fone;
    }

    public int CodCliente { get => codCliente; set => codCliente = value; }
    public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
    public string Rua { get => rua; set => rua = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Complemento { get => complemento; set => complemento = value; }
    public int Cep { get => cep; set => cep = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Estado { get => estado; set => estado = value; }
    public int Fone { get => fone; set => fone = value; }
}