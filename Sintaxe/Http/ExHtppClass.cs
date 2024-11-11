using System.Net.Http;
using System.Text;

namespace Sintaxe.Http;

/*A classe HttpClient em C# é uma das principais utilizadas para fazer 
requisições HTTP. Ela faz parte do namespace System.Net.Http e oferece 
uma maneira simples e eficaz de enviar requisições e receber respostas 
de servidores web

O HttpClient é projetado para ser reutilizado e não instanciado
 repetidamente. Criar uma nova instância a cada requisição pode
  causar problemas de desempenho devido ao gerenciamento de conexões.
Uma boa prática é manter uma instância única e reutilizá-la para várias 
requisições.
*/

public class ExHtppClass
{
    
    private static readonly HttpClient client = new HttpClient();

    public async void httpRequisicion()
    {
        //GetAsync  : Envia uma requisição HTTP GET de forma assíncrona. É usado para obter dados de um servidor
        var responseget = await client.GetAsync("http://exemplo.com");
        var content = await responseget.Content.ReadAsStringAsync();
        
        //PostAsync Envia uma requisição HTTP POST de forma assíncrona. Usado quando se precisa enviar dados (por exemplo, em formulários ou APIs RESTful)
        var data = new StringContent("{ \"nome\": \"Lucas\" }", Encoding.UTF8, "application/json");
        var responsepost = await client.PostAsync("http://exemplo.com/api", data);
        
        //PutAsync Envia uma requisição HTTP PUT de forma assíncrona. Usado para atualizar recursos no servidor.
        var dataPut = new StringContent("{ \"nome\": \"Lucas Atualizado\" }", Encoding.UTF8, "application/json");
        var responseput = await client.PutAsync("http://exemplo.com/api/1", dataPut);

        
        
        // DeleteAsync Envia uma requisição HTTP DELETE de forma assíncrona. Usado para excluir recursos no servidor.
        var responseDelete = await client.DeleteAsync("http://exemplo.com/api/1");

        //SendAsync Envia uma requisição HTTP personalizada de forma assíncrona, podendo ser configurada com diferentes métodos HTTP (GET, POST, etc.), cabeçalhos, corpo da requisição, etc.
        var request = new HttpRequestMessage(HttpMethod.Post, "http://exemplo.com/api");
        request.Content = new StringContent("{ \"nome\": \"Lucas\" }", Encoding.UTF8, "application/json");
        var response = await client.SendAsync(request);
        
        
        //BaseAddress Define a URL base para as requisições feitas pelo HttpClient. Isso ajuda a evitar repetição de URL completa em cada requisição.
        client.BaseAddress = new Uri("http://exemplo.com/");
        var responseRepeticao = await client.GetAsync("api/endpoint");

        //DefaultRequestHeaders Permite definir cabeçalhos padrão para todas as requisições feitas com o HttpClient.
        client.DefaultRequestHeaders.Add("Authorization", "Bearer token_aqui");

        
        
        //Cancelar requisições É possível cancelar requisições usando o CancellationToken, o que pode ser útil em cenários onde o tempo de resposta é crítico ou em casos de timeout.
        var cts = new CancellationTokenSource();
        var responseCanelar = await client.GetAsync("http://exemplo.com", cts.Token);

    }
}