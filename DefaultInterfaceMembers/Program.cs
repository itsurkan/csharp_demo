﻿using System;
using System.Linq;

namespace DefaultInterfaceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            SampleCustomer c = new SampleCustomer("customer one", new DateTime(2010, 5, 31))
            {
                Reminders =
                {
                    { new DateTime(2010, 08, 12), "childs's birthday" },
                    { new DateTime(1012, 11, 15), "anniversary" }
                }
            };

            SampleOrder o = new SampleOrder(new DateTime(2012, 6, 1), 5m);
            c.AddOrder(o);

            o = new SampleOrder(new DateTime(2103, 7, 4), 25m);
            c.AddOrder(o);

            // Check the discount:
            ICustomer.SetLoyaltyThresholds(new TimeSpan(30, 0, 0, 0), 1, 0.25m);
            Console.WriteLine($"Current discount: {c.ComputeLoyaltyDiscount()}");

            Console.ForegroundColor = ConsoleColor.White;

            //var light = new Light();
            //IWave wave = light;
            //IParticle particle = light;

            //wave.Interact();
            //particle.Interact();
        }
    }
}
