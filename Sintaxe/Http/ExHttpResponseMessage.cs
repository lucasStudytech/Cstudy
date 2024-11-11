using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Sintaxe.Http;

/*O HttpResponseMessage no C# é uma classe usada para representar a
 resposta de uma requisição HTTP.
 
 Ele representa uma resposta HTTP, com a qual você pode obter 
 detalhes sobre a resposta de um servidor após realizar uma requisição.
 
Pode conter dados como o código de status HTTP (ex.: 200 OK, 404 Not Found),
 cabeçalhos e o conteúdo (corpo da resposta).*/

public class ExHttpResponseMessage
{
    public  async void ExHttepResponse()
    {
        //Criação de um HttpResponseMessage
        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

        //Definindo o conteúdo da resposta: ocê pode adicionar o conteúdo da resposta HTTP, por exemplo, um objeto JSON ou texto.
   //    response.Content = new StringContent("Conteúdo da resposta", Encoding.UTF8, "text/plain");

        
        //Acessando o código de status O código de status HTTP indica o resultado da solicitação (sucesso, erro, etc.). Ele pode ser acessado usando a propriedade StatusCode
        HttpStatusCode statusCode = response.StatusCode;
        Console.WriteLine(statusCode);  // Exibe "OK" (código 200)
        
        
        //A resposta pode incluir cabeçalhos HTTP, que podem ser acessados através da propriedade Headers.
        response.Headers.Add("X-Custom-Header", "Valor");

        
    }   
    
    // Enviando a resposta em um método de API: Em uma API, o HttpResponseMessage é frequentemente retornado de um método de controlador. Um exemplo básico de uso no contexto de uma API:
    public HttpResponseMessage GetData()
    {
        var data = new { Name = "Lucas", Age = 30 };
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
        };
        return response;
    }
}