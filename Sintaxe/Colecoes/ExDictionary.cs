namespace Sintaxe.Colecoes;

public class ExDictionary
{
    public void exemplosDictionary()
    {
        Dictionary <int,string> dict = new Dictionary<int, string>();
        
        // add - Adiciona um novo par chave-valor ao dicionário
       dict.Add(0, "Lucas");
        dict.Add(1, "Fernanda");

        //  ContainsKey - Verifica se uma chave existe no dicionário
        bool hasKey = dict.ContainsKey(1); // Retorna true
        
        // ContainsValue - Verifica se um valor existe no dicionário
        bool hasValue = dict.ContainsValue("Banana");
        
        //  Remove - Remove um item do dicionário pela chave
       // dict.Remove(1);

        // Clear - Remove todos os itens do dicionário
       // dict.Clear();
   
        //Keys - Retorna todas as chaves do dicionário
        var keys = dict.Keys; 
        
        // Values - Retorna todos os valores do dicionário
        var values = dict.Values; 
        
        foreach (var result in dict)
        {
            Console.WriteLine(result);

        }
    }
}