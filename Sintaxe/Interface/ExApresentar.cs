namespace Sintaxe.ExInterface;

public class ExApresentar : InterfacePessoa
{
        public void Apresentar(Pessoa pessoa)
        {
                
                Console.WriteLine($"meu nome e {pessoa.getNome()}, e a idade e {pessoa.getidade()}");
        }
}