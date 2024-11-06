namespace Sintaxe.Loop;
using System.Collections.Generic;

public class ExLoop
{
    public void exloop()
    {
        
        //FOR
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("loop for:" + i);
        }


        //Whille
        int y = 0;
        while (y < 10)
        {
            Console.WriteLine("loop while:"+ y);
            y++;
        }

    //doWhille

    int x = 0;
    do
    {
        Console.WriteLine("loop do Whille:" + x);
        x++;
    }while(x < 10);

    
        //foreach
        List<string> names = new List<string> { "lucas", "Bob" };

        foreach (String name in names)
        {
            Console.WriteLine("foreach loop" + name);
        }


    }
}