﻿using System;

namespace Damakonzole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"

             ██████╗  ██████╗ ████████╗██╗ ██████╗██╗  ██╗ █████╗     ██████╗  █████╗ ███╗   ███╗ █████╗ 
            ██╔════╝ ██╔═══██╗╚══██╔══╝██║██╔════╝██║ ██╔╝██╔══██╗    ██╔══██╗██╔══██╗████╗ ████║██╔══██╗
            ██║  ███╗██║   ██║   ██║   ██║██║     █████╔╝ ███████║    ██║  ██║███████║██╔████╔██║███████║
            ██║   ██║██║   ██║   ██║   ██║██║     ██╔═██╗ ██╔══██║    ██║  ██║██╔══██║██║╚██╔╝██║██╔══██║
            ╚██████╔╝╚██████╔╝   ██║   ██║╚██████╗██║  ██╗██║  ██║    ██████╔╝██║  ██║██║ ╚═╝ ██║██║  ██║
             ╚═════╝  ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝                                                                             
            ");
            GameController gameController = new GameController();
            gameController.Start();
            gameController.Game();


            //Console.WriteLine("Stiskni ENTER pro ukonceni");
            //Console.ReadLine();
        }
    }
}
