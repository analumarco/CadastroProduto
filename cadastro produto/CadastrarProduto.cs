public class CadastrarProduto
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }  
    public double PrecoAquisicao { get; set; }
    public double Lucro { get; set; }
    public double ValorVenda { get; set; }  

    public CadastrarProduto()
    {

    }
    public CadastrarProduto(string codigo, string descricao, double precoAquisicao, double lucro, double valorVenda)
    {
        this.Codigo = codigo;
        this.Descricao = descricao;
        this.PrecoAquisicao = precoAquisicao;
        this.Lucro = lucro;
        this.ValorVenda = valorVenda;
    }
}
