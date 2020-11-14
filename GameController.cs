﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Damakonzole
{
    class GameController
    {
        private Board board = new Board();
        private Rules rules;
        private UI ui;
        public GameController()
        {
            rules = new Rules(board);
            ui = new UI(board);
        }

        /// <summary>
        /// Hlavní herní smyčka
        /// </summary>
        public void Game()
        {
            rules.InitBoard();
            rules.InitPlayer();

            while (true)
            {
                ui.PrintBoard();
                int[] vstup = null;
                int[] plnyVstup;
                bool platnyVstup = false;
                while (!platnyVstup)
                {
                    ui.WhoMove(rules.PlayerOnMove()); //vypisuje kdo je na tahu
                    vstup = ui.InputUser(); //pokud -1 tak se podmínka neprovede protože -1 >= 0, pokud 0 tak se provede 0=0 a zkontroluje se platnost tahu
                    if (vstup[0] >= 0) //pokud je zadán správný pohyb tj A2-B3
                    {
                        platnyVstup = rules.IsCheckMove(vstup); //ověření zda je táhnuto dle pravidel
                        if (!platnyVstup) //pokud není vypíše uživately chybu
                        {
                            ui.Mistake(); //chyba
                        }
                    }
                }
                plnyVstup = rules.FullMove(vstup);
                board.Move(plnyVstup); //pokud je zadáno správně, metoda nastaví pohyb na desce
                rules.ChangePlayer(); //změna hráče na tahu
            }

        }
        /// <summary>
        /// Nastavení hodnoty políčka
        /// </summary>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <param name="hodnota"></param>
        public void SetValueOnBoard(int posX, int posY, int value)
        {
            board.SetValue(posX, posY, value);
        }
    }
}