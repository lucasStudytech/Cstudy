using Newtonsoft.Json;
using static System.Text.Encoding;

namespace Sintaxe.Http;

public class ExOpenAI
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<string> ChatGptRequest(string prompt)
    {
        string apiUrl = "https://api.openai.com/v1/chat/completions";

        
        
        // Estrutura do payload conforme exigido pela API de chat
        var payload = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "user", content = prompt }
            },
            max_tokens = 50,
            temperature = 0.7
        };
            
        string jsonPayload = JsonConvert.SerializeObject(payload);

        var content = new StringContent(jsonPayload, UTF8, "application/json");
        
        //  Definir o cabeçalho de autenticação com a chave da API.
        string apiKey = "";
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        
        
        //Criar a requisição usando HttpRequestMessage.
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiUrl)
            {
                Content = content
            };
        
            try{
            // Enviar a requisição com `SendAsync` e aguardar a resposta.
            HttpResponseMessage response = await client.SendAsync(requestMessage);
            
            //  Validar o status da resposta.
            response.EnsureSuccessStatusCode();

            //  Ler o conteúdo da resposta.
            string responseContent = await response.Content.ReadAsStringAsync();

            
            Console.WriteLine(responseContent);
            return responseContent; // Retornar a resposta em JSON.
    }
            catch (HttpRequestException ex) 
            {
                if (ex.Message.Contains("429"))
                {
                    Console.WriteLine("Too many requests. Retrying in 10 seconds...");
                    await Task.Delay(10000); // Espera de 10 segundos
                    return await ChatGptRequest(prompt); // Tenta novamente a requisição
                }
                else
                {
                    Console.WriteLine($"Erro ao fazer a requisição: {ex.Message}");
                    return null;
                }
            }

    }
}