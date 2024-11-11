using Newtonsoft.Json;
namespace Sintaxe.Http;


/*O JsonConvert é uma classe da biblioteca Newtonsoft.Json,
 uma das bibliotecas mais populares para manipulação de JSON no C#. 
 Ela fornece métodos para serializar objetos em JSON e desserializar 
 JSON de volta para objetos*/

public class EXJson
{
    public void convert()
    {
        //. Serialização (de objeto para JSON): A serialização é o processo de converter um objeto C# em uma string JSON. O JsonConvert.SerializeObject() é usado para isso.
        
        var pessoa = new { Nome = "Lucas", Idade = 30 };
        string json = JsonConvert.SerializeObject(pessoa);
        Console.WriteLine(json);  // Exibe: {"Nome":"Lucas","Idade":30}
        
        //Personalizando a serialização: Você pode personalizar a serialização, por exemplo, controlando a formatação (compacta ou com indentação), excluindo propriedades nulas, etc.
        json = JsonConvert.SerializeObject(pessoa, Formatting.Indented);
        Console.WriteLine(json);
        
        // Desserialização método JsonConvert.DeserializeObject() é para desserialização é o processo de converter uma string JSON de volta para um objeto C#.
        string jsonx = "{\"Nome\":\"Lucas\",\"Idade\":30}";
        var pessoaa = JsonConvert.DeserializeObject<dynamic>(jsonx);
        Console.WriteLine(pessoaa.Nome);  // Exibe: Lucas
        Console.WriteLine(pessoaa.Idade); // Exibe: 30
        
        /*Usando tipos fortes (não dinâmicos):
         Você também pode desserializar para um tipo específico 
         (por exemplo, uma classe definida):
         
         
             public class Pessoa
               {
        public string Nome { get; set; }
        public int Idade { get; set; }
               }       

            string json = "{\"Nome\":\"Lucas\",\"Idade\":30}";
            Pessoa pessoa = JsonConvert.DeserializeObject<Pessoa>(json);
            Console.WriteLine(pessoa.Nome);  // Exibe: Lucas
            Console.WriteLine(pessoa.Idade); // Exibe: 30

         
            
         */
        
       //O JsonConvert também pode serializar e desserializar listas ou arrays de objetos. 
      /* var pessoas = new List<Pessoa>
       {
           new Pessoa { Nome = "Lucas", Idade = 30 },
           new Pessoa { Nome = "Maria", Idade = 25 }
       };

       string json = JsonConvert.SerializeObject(pessoas);
       Console.WriteLine(json);  // Exibe: [{"Nome":"Lucas","Idade":30},{"Nome":"Maria","Idade":25}]
        */
       
    }
}