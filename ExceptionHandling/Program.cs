﻿using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        
    }
}
