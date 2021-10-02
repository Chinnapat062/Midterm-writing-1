using System;
using System.Collections.Generic;
namespace ข้อ_1_กลางภาค_Hangman
{
    //ข้อสอบข้อ 1 Hangman //
    enum Menu
    {
        Playgame = 1,
        Exit,
    }

     class Program
    {
        static void Main(string[] args)
        {

            PrintMenuScreen();
             Inputmenuselected();
        }
        static void PrintMenuScreen()   //หน้าเมนู
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.Write("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Playgame");
            Console.WriteLine("2. Exit");
            Console.WriteLine("");

        }
         static void Inputmenuselected()  //ผู้ใช้เลือกเมนู
         {
             Console.WriteLine("Please selecet Menu");
             Menu menu = (Menu)(int.Parse(Console.ReadLine()));

             selectedmenu(menu);
         }
         static void selectedmenu(Menu menu) //ฟังก์ชั่นเมนู
         {
             if (menu == Menu.Playgame)
             {
                 Playgamescreen();
             }else if (menu == Menu.Exit)
             {
                 Console.Clear();
                 Console.WriteLine("Exit");
             }else
             {
                 Console.Clear();
                 Console.WriteLine("Menu Incorrect Please try again.");
                 Inputmenuselected();
             }
         }
         static void Playgamescreen() //หน้าเกม
         {

             Console.WriteLine("Play Game Hangman");
             Console.WriteLine("---------------------");
           Console.WriteLine("Incorrect score : 0");
           Hangmangamestart();

         }
       static void Hangmangamestart() //ฟังก์ชั่นเกม
       {
           string[] listwords = new string[3];
           listwords[0] = "Tennis";
           listwords[1] = "Football";
           listwords[2] = "Badminton";
           Random random = new Random();
           int resultrandom = random.Next(0, 2);
           string hangmanwords = listwords[resultrandom];
           char[] playerguess = new char[hangmanwords.Length];

           Console.Clear();
           Console.WriteLine("Play Game Hangman");
           Console.WriteLine("---------------------");
           Console.WriteLine("Incorrect score : 0");
           Console.WriteLine("");



           for (int a = 0; a < hangmanwords.Length; a++)
               playerguess[a] = '-';


           Console.WriteLine("input any key to play");
           while (true)
           {
               char playerinputguess = char.Parse(Console.ReadLine());
               for (int j = 0; j < hangmanwords.Length; j++)
               {
                   if (playerinputguess == hangmanwords[j])
                       playerguess[j] = playerinputguess;
               }
               Console.WriteLine(playerguess); 



           }

       }


    }

    
}

     

    



