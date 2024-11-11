using System.Text;

namespace Sintaxe.Http;
/*O StringContent é uma classe no C# usada para encapsular conteúdo
 textual em uma requisição ou resposta HTTP. Ela é geralmente utilizada 
 quando você precisa enviar ou receber texto em uma requisição HTTP,
  como no caso de JSON, XML ou simples texto.
  
  StringContent é uma classe que deriva de HttpContent e é usada para 
  representar conteúdo de texto que será enviado em uma requisição ou 
  incluído em uma resposta HTTP.
 Ela permite enviar texto (como uma string) como o corpo de uma requisição HTTP, especificando também o tipo de mídia (MIME type) e a codificação.
  
  */

public class ExStringContet
{
    public async void ExStringContent()
    {
        //Criando um StringContent:Para criar um StringContent, você precisa passar a string que deseja enviar, a codificação (opcional) e o tipo de mídia (também opcional) como parâmetros:
        StringContent content = new StringContent("Texto de exemplo", Encoding.UTF8, "text/plain");

       
        // Uso com HttpClient:  O StringContent é frequentemente utilizado com o HttpClient para enviar dados em uma requisição HTTP, como um corpo de POST ou PUT. Exemplo:
        HttpClient client = new HttpClient();
        StringContent contenta = new StringContent("Dados para enviar", Encoding.UTF8, "text/plain");

        HttpResponseMessage response = await client.PostAsync("https://api.exemplo.com/endpoint", content);

        
        //Uso com JSON: É muito comum usar StringContent para enviar dados JSON. Exemplo:
     
        
        var jsonData = "{\"nome\": \"Lucas\", \"idade\": 30}";
        StringContent contentt = new StringContent(jsonData, Encoding.UTF8, "application/json");

        
     //  Lendo o conteúdo de StringContent: Você também pode acessar e ler o conteúdo de uma instância de StringContent, embora geralmente isso não seja comum, já que o StringContent é usado principalmente para enviar dados.
     string data = await content.ReadAsStringAsync();
     Console.WriteLine(data); // Exibe o texto "Texto de exemplo"

     //Descarte e limpeza Como o StringContent deriva de HttpContent, você deve liberar os recursos de forma apropriada. Normalmente, isso é feito automaticamente quando você usa o using ou quando o objeto é descartado, mas se precisar, pode chamar o método Dispose() explicitamente:
     content.Dispose();

     
     //Exemplo: Enviar JSON em uma requisição POST com StringContent:
     var json = "{\"username\":\"user\",\"password\":\"pass\"}";
     StringContent contentx = new StringContent(json, Encoding.UTF8, "application/json");
     HttpResponseMessage responsee = await client.PostAsync("https://api.exemplo.com/login", contentx);

    } 
}