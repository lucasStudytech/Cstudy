using Sintaxe.Colecoes;
using Sintaxe.Condicionais;
using Sintaxe.xConsole;
using Sintaxe.ExInterface;
using Sintaxe.Loop;
using Sintaxe.Variavel;

namespace Sintaxe;

public class main
{
    public static void Main(string[] args)
    {
        
        //loop
       // ExLoop  loop = new ExLoop();
       // loop.exloop();

        //ExCondicional exCondicional = new ExCondicional();
      //  exCondicional.condicional();

        //ExVariavel variavel = new ExVariavel();
        //variavel.variavel();

       // Pessoa pessoa = new Pessoa("lucas", 23);
       //   InterfacePessoa Ipessoa = new ExApresentar();
        //   Ipessoa.Apresentar(pessoa);

        
       // ExDictionary dictionary = new ExDictionary();
       // dictionary.exemplosDictionary();
       
     //  ExArray exArray = new ExArray();
      // exArray.ExemploArray();

      
      //  ExList exList = new ExList();
       // exList.ExemploList();
      
   //ExString exString = new ExString();
  // exString.exemploString();
  
  ExConsole console = new ExConsole();
  console.ExemploConsole();
   
    }
}