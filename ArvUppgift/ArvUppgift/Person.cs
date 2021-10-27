using System;
using System.Collections.Generic;
using System.Text;

namespace ArvUppgift
{
    class Person
    {

        public Person()
        {
            Console.WriteLine("Hej vad heter du?");
            string Namn = Console.ReadLine();
            Console.WriteLine("Godmorgon " + Namn + ", Hur gammal är du?");
            int Ålder = int.Parse(Console.ReadLine());
            

        }
    }
}
