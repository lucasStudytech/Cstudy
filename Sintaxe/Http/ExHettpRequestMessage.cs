using System.Text;

namespace Sintaxe.Http;

/*A classe HttpRequestMessage em C# é usada para representar
 uma requisição HTTP, permitindo maior controle sobre o conteúdo,
  cabeçalhos, método HTTP e outros detalhes da requisição. 
  Ao contrário de métodos simples como GetAsync, PostAsync,
   entre outros, o HttpRequestMessage oferece mais flexibilidade,
    pois você pode definir todos os parâmetros da requisição.*/

public class ExHettpRequestMessage
{
    public void ExRequest()
    {
        
        //HttpRequestMessage  Define o método HTTP (GET, POST, PUT, DELETE, etc.) para a requisição
        var requestMetodo = new HttpRequestMessage(HttpMethod.Get, "http://exemplo.com");

        
        //RequestUri Representa a URI de destino da requisição.
        var requestUri = new HttpRequestMessage(HttpMethod.Get, "http://exemplo.com/api/endpoint");

        
        //Content Permite definir o conteúdo (body) da requisição, que pode ser útil para métodos como POST e PUT, onde você precisa enviar dados ao servido
        var content = new StringContent("{ \"nome\": \"Lucas\" }", Encoding.UTF8, "application/json");
        var request = new HttpRequestMessage(HttpMethod.Post, "http://exemplo.com/api")
        {
            Content = content
        };

      //  Headers Permite adicionar cabeçalhos personalizados à requisição.
      var requestHeader = new HttpRequestMessage(HttpMethod.Get, "http://exemplo.com/api/endpoint");
      request.Headers.Add("Authorization", "Bearer token_aqui");

    }
}