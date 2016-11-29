﻿using System;

namespace TranslatorBankXML
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                RabbitMQConnectionHandling conn = new RabbitMQConnectionHandling();
                conn.StartReadQueue();
                Console.WriteLine("exit? {yes/[no]}: ");
                string exitkeys = Console.ReadLine();
                if (exitkeys.Equals("yes"))
                {
                    running = false;
                }
            }
        }
    }
}