namespace Sintaxe.Colecoes;

public class ExList
{
    public void ExemploList()
    {
        List<int>lista = new List<int>{1,2,3,4,5,6};
        
        //Add - Adiciona um elemento ao final da lista
        lista.Add(60);
        imprimirLista(lista);
      
       // AddRange - Adiciona uma coleção de elementos à lista
        lista.AddRange(new List<int> { 70, 80 });
        imprimirLista(lista);
      
       // Insert - Insere um elemento em uma posição específica
        lista.Insert(2, 25); // Insere 25 no índice 2
        imprimirLista(lista);
        
       // Remove - Remove a primeira ocorrência de um elemento
        lista.Remove(60); // Remove o valor 40
        imprimirLista(lista);
        
        //RemoveAt - Remove o elemento em um índice específico
        lista.RemoveAt(3);
        imprimirLista(lista);
        
         //Clear - Remove todos os elementos da lista
        // lista.Clear();
        // imprimirLista(lista);
    }

    public void imprimirLista(List<int> lista)
    {
        Console.WriteLine(string.Join(" , ", lista));
    }
}