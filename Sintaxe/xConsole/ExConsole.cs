
using System;
namespace Sintaxe.xConsole;


public class ExConsole
{
    public void ExemploConsole()
    {
        //Console.Write: Escreve texto no console sem pular para a linha seguinte.
        Console.Write("Digite seu nome: ");
        
        //Console.WriteLine: Escreve texto no console e pula para a linha seguinte.
        Console.WriteLine("Olá, mundo!");
        
        //Console.WriteLine com formatação: Usado para formatação avançada de strings
        double numero = 3.1415;
        Console.WriteLine("Número formatado: {0:F2}", numero); // Saída: "Número formatado: 3.14"

        //Console.ReadLine: Lê uma linha de entrada como uma string.
        
       // Console.Write("Digite seu nome: ");
   //string nome = Console.ReadLine();
       // Console.WriteLine($"Olá, {nome}!");

       // Console.ReadKey: Lê uma única tecla pressionada pelo usuário, sem precisar pressionar Enter. Útil para esperar uma ação antes de fechar o programa.
       //Console.WriteLine("Pressione qualquer tecla para sair...");
     //  Console.ReadKey();

       
       //Exemplo de alinhamento de texto à esquerda e à direita
       string nomePessoa = "João";
       // Alinhando à esquerda com 10 caracteres
       Console.WriteLine("Nome alinhado à esquerda: |{0,-10}|", nomePessoa);  // Saída: "|João      |"
       // Alinhando à direita com 10 caracteres
       Console.WriteLine("Nome alinhado à direita: |{0,10}|", nomePessoa);   // Saída: "| 
       
       
        
       // 2. Exemplo de formatação com número de ponto flutuante
       //O {0:F2} especifica que queremos 2 casas decimais
       Console.WriteLine("Formatação de número: {0:F2}", numero); 
       
       
       // // O {0:N0} mostra o número com separadores de milhar, sem casas decimais
       Console.WriteLine("Número com separador de milhar: {0:N0}", numero);
       
       DateTime data = DateTime.Now;  // Data e hora atuais
       
       
       // 4. Exemplo de formatação de data com formato curto
       // O {0:d} exibe a data no formato curto (dd/MM/yyyy)
       Console.WriteLine("Data curta: {0:d}", data);  
        
       // 5. Exemplo de formatação de data com formato longo
       // O {0:D} exibe a data no formato longo, incluindo o dia da semana
       Console.WriteLine("Data longa: {0:D}", data); 
    }
}