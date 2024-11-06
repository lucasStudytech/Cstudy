namespace Sintaxe.ExInterface;

public class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }


    public string getNome()
    {
        return nome;
        
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public int getidade()
    {
        return idade;
    }

    public void setIdade(int idade)
    {
        this.idade = idade;
    }
}