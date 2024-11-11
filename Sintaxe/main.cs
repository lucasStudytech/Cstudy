using Sintaxe.Excel;
using Sintaxe.Pdf;
using Sintaxe.Http;

namespace Sintaxe;

public class main
{
    public static async Task Main(string[] args)
    {
        
        
        
        
        
        
        
        // Instância da classe OpenAI
        ExOpenAI openAI = new ExOpenAI();

        // Prompt para enviar ao ChatGPT
        string prompt = "Me conte sobre a história da inteligência artificial.";

        // Chamar o método assíncrono e capturar a resposta
        string response =  await openAI.ChatGptRequest(prompt);

        // Exibir a resposta no console
        Console.WriteLine("Resposta do ChatGPT:");
        Console.WriteLine(response);
        
        
        
        
        
        
        
        
        
        
        //ExLerPdf leitura = new ExLerPdf();
        //leitura.PdfEx();


     //   ExExcel excel = new ExExcel();
       // excel.escreverExcel();

      // PdfParaExcel pdfParaExcel = new PdfParaExcel();
      // pdfParaExcel.Conversor();


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

      //ExConsole console = new ExConsole();
//  console.ExemploConsole();

    }
}