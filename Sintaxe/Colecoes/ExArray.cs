namespace Sintaxe.Colecoes;

public class ExArray
{
    public void ExemploArray()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        
        // Length - Retorna o número de elementos no array
        Console.WriteLine($"O array tem {arr.Length} elementos.");
        
        // GetValue - Obtém o valor de um índice específico
        int valor = (int)arr.GetValue(2);
        Console.WriteLine($"Valor no índice 2: {valor}");

        //SetValue - Atribui um valor a uma posição específica
        arr.SetValue(100, 3); // Modifica o valor na posição 3 para 100
        Console.WriteLine($"Valor no índice 3 após modificação: {arr[3]}");
        
        
      //Clone - Cria uma cópia do array
        int[] arrCopia = (int[])arr.Clone();
        Console.WriteLine("Array copiado:");
        foreach (var item in arrCopia)
        {
            Console.WriteLine(item);
        }
        
        
        //Reverse - Inverte os elementos do array
        Array.Reverse(arr);
        Console.WriteLine("Array invertido:");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        
      //IndexOf - Retorna o índice de um valor no array
        int index = Array.IndexOf(arr, 2);
        Console.WriteLine($"Índice do valor : {index}");

        
        
        
        
    }
}