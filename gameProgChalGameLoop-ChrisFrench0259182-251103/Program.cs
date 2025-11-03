using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gameProgChalGameLoop_ChrisFrench0259182_251103
{
    internal class Program
    {

        static int horImpPlayer = 0;
        static int vertImpPlayer = 0;
        static int horPosPlayer = 0;
        static int vertPosPlayer = 0;

        static int horImpShark = 0;
        static int vertImpShark = 0;
        static int horPosShark = 0;
        static int vertPosShark = 0;

        static int refreshMS = 20;
        static bool isPlaying = true;



        static void Main(string[] args)
        {
            while (isPlaying)
            {

                playerInputs();
                swimShark();
                Update();
                Draw();

                Thread.Sleep(refreshMS);
            }

        }

        //m1
        static void playerInputs()
        {
            horImpPlayer = 0;
            vertImpPlayer = 0;

            if (!Console.KeyAvailable)
            {
                return;
            }

            ConsoleKeyInfo inputKey = Console.ReadKey(true);

            if (inputKey.Key == ConsoleKey.A) horImpPlayer -= 1;

            if (inputKey.Key == ConsoleKey.D) horImpPlayer += 1;

            if (inputKey.Key == ConsoleKey.W) vertImpPlayer += 1;

            if (inputKey.Key == ConsoleKey.S) vertImpPlayer -= 1;

            if (inputKey.Key == ConsoleKey.Q) isPlaying = false;






        }

        //m1B

        static void swimShark()
        {

            horImpPlayer = 100;
            vertImpPlayer = 50;


            if (horPosShark > horPosPlayer)
            {
                horImpShark -= 1;
            }
            if (horPosShark < horPosPlayer)
            {
                horImpShark += 1;
            }
            if (horPosShark > horPosPlayer)
            {
                horImpShark -= 1;
            }
            if (horPosShark < horPosPlayer)
            {
                horImpShark += 1;
            }
        }




        //m2
        static void Update()
        {         
           horPosPlayer += horImpPlayer;
           vertPosPlayer += vertImpPlayer;

            horPosShark += horImpShark;
            vertPosShark += vertImpShark;

        }


        //m3
        static void Draw()
        {
            playerDraw();

            sharkDraw();

        }
        //m3B
        static void playerDraw()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("O");



        }

        //m3c
        static void sharkDraw()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("^");



        }




    }
}
