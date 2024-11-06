
using System;
namespace Sintaxe.Condicionais;

public class ExCondicional
{
    public void condicional()
    {

        
        //if e else
        int x = 10;

        if (x > 0)
        {
            Console.WriteLine( x + ": e um numero posito");
            
        }else if(x < 0)
        {
            Console.WriteLine(x + " : e um numero negativo");
        }
        
        
        // switch
        
        int day = 3;
        
        switch (day) {
            case 1:
                Console.WriteLine("segunda");
                break;
            case 2:
                Console.WriteLine(" terça ");
                break;
            case 3:
                Console.WriteLine(" quarta");
                break;
            default:
                Console.WriteLine("Quinta");
                break;
        }
        
        
        
    }
}