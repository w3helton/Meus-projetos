﻿using System;

namespace desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
          int A = int.Parse(Console.ReadLine());
          int B = int.Parse(Console.ReadLine());
          int C = int.Parse(Console.ReadLine());
          int D = int.Parse(Console.ReadLine());
          int diff = (A*B-C*D);
         
        //Declare suas variáveis nos espaços em branco
            Console.WriteLine("DIFERENCA = {0}",diff);
            Console.ReadKey();
           
           
        }
 
       
    }
   
}
