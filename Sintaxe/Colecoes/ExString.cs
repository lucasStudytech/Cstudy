namespace Sintaxe.Colecoes;

public class ExString
{
    public void exemploString()
    {
        string texto = "Hello, World!";
        
        //Length - Obtém o comprimento da string
        Console.WriteLine($"Comprimento: {texto.Length}");
        
        //Contains - Verifica se a string contém uma sequência específica
        bool contemWorld = texto.Contains("World");
        Console.WriteLine($"Contém 'World'? {contemWorld}");
        
      //  IndexOf - Encontra o índice da primeira ocorrência de um caractere ou substring
        int indiceO = texto.IndexOf('o');
        Console.WriteLine($"Índice de 'o': {indiceO}");
        
        //Substring - Extrai uma substring a partir de um índice
        string subTexto = texto.Substring(7, 5); // "World"
        Console.WriteLine($"Substring: {subTexto}");
        
        //Replace - Substitui uma sequência específica por outra
        string textoAlterado = texto.Replace("World", "C#");
        Console.WriteLine($"Texto alterado: {textoAlterado}");
        
        //ToLower - Converte para letras minúsculas
        Console.WriteLine($"Minúsculas: {texto.ToLower()}");
        
        //ToLower - Converte para letras minúsculas
        Console.WriteLine($"Minúsculas: {texto.ToLower()}");
        
        //Split - Divide a string em partes com base em um delimitador
        string[] partes = texto.Split(',');
        Console.WriteLine("Partes da string:");
        foreach (string parte in partes)
        {
            Console.WriteLine(parte);
        }
        
        // Join - Junta elementos de uma coleção em uma única string
        string[] palavras = { "Hello", "World" };
        string frase = string.Join(" kkk ", palavras);
        Console.WriteLine($"Frase: {frase}");
    }
}