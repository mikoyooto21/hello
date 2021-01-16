using System;
using System.Collections.Generic;
using System.Text;

namespace hello
{

    class tutorial
    {
        public static void tut()
        {
            Console.WriteLine("Привет!\n");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Это моя вторая игра, но, мне кажется, она лучше первой.\n");
            System.Threading.Thread.Sleep(400); 
            Console.WriteLine("Ну что, давай я расскажу тебе что тут и как работает.");
            System.Threading.Thread.Sleep(400);
            difficulty.tutor1();
            Console.WriteLine("Хах, ну, если ты со всем разобрался - удачи тебе'^^'");
        }
    }
    class difficulty
    {
        public static void tutor1()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Ну что, давай попробуем");
                int s;
                
                Random rand = new Random();
                Console.WriteLine("Введи число от 1 до 3");
                int an = Int32.Parse(Console.ReadLine());
                if (an > 3) { Console.WriteLine("Не верно введено число. Не шали тут '>.<'"); }
                if (an <= 3)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine(s = rand.Next(3));
                        if (an == s)
                        {
                            
                            Console.WriteLine("Хаха, а ты везунчик! Хочешь попробовать еще? Если нет, то нажимай Esc");
                            
                        }
                    }
                }
                

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
        public static void light()
        {
            do
            {
                Console.Clear();
                int s;
                int cnt = 0;
                Random rand = new Random();
                Console.WriteLine("Введите число от 1 до 10");
                int an = Int32.Parse(Console.ReadLine());
                if (an > 10) { Console.WriteLine("Не верно введено число."); }
                if (an <= 10)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(s = rand.Next(10));
                        if (an == s)
                        {
                            cnt++;
                            Console.WriteLine("Число {0} есть в доступных числах(x{1})!", an, cnt);
                            System.Threading.Thread.Sleep(400);
                        }
                    }
                }
                Console.WriteLine("Нажмите любую клавишу...");
            
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }


        public static void normal()
        {
            do
            {
                Console.Clear();
                int s;
                int cnt = 0;
                Random rand = new Random();
                Console.WriteLine("Введите число от 1 до 20");
                int an = Int32.Parse(Console.ReadLine());
                if (an > 20) { Console.WriteLine("Не верно введено число."); }
                if (an <= 20)
                {
                    for (int i = 0; i < 5; i++)
                
                    {
                    Console.WriteLine(s = rand.Next(20));
                    if (an == s)
                    {
                        cnt++;
                        Console.WriteLine("Число {0} есть в доступных числах(x{1})!", an, cnt);
                        System.Threading.Thread.Sleep(400);
                    }
                }
            }
                Console.WriteLine("Нажмите любую клавишу...");

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }


        public static void hard()
        {
            do
            {
                Console.Clear();
                int s;
                int cnt = 0;
                Random rand = new Random();
                Console.WriteLine("Введите число от 1 до 50");
                int an = Int32.Parse(Console.ReadLine());
                if (an > 50) { Console.WriteLine("Не верно введено число."); }
                if (an <= 50)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(s = rand.Next(50));
                        if (an == s)
                        {
                            cnt++;
                            Console.WriteLine("Число {0} есть в доступных числах(x{1})!", an, cnt);
                            System.Threading.Thread.Sleep(400);
                        }
                    }
                }
                    Console.WriteLine("Нажмите любую клавишу...");
                
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
    class random
    {



        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню\n\n" + "1.Новая игра\n" +
                    "2.Загрузка игры\n" + "3.Выход\n");
                int answ = Int32.Parse(Console.ReadLine());
                if (answ != 1 & answ != 2 & answ != 3) { Console.WriteLine("Неверно введен номер пункта меню."); }
                else
                {
                    switch (answ)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("1.Новая игра\n" + "2.Обучение\n\n\n3.Вернутся\n");
                                int answer = Int32.Parse(Console.ReadLine());
                                if (answer != 1 || answer != 2) { Console.WriteLine("Неверно введен номер пункта меню."); }
                                switch (answer)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Выберите сложность:\n\n" + "1.Легкая\n2.Нормальная\n3.Сложная\n\n\n4.Вернутся\n");
                                        int ans = Int32.Parse(Console.ReadLine());
                                        if (ans != 1 || ans != 2 || ans != 3 || ans != 4) { Console.WriteLine("Неверно введен номер пункта меню."); };
                                        switch (ans)
                                        {
                                            case 1: difficulty.light(); break;
                                            case 2: difficulty.normal(); break;
                                            case 3: difficulty.hard(); break;
                                            case 4: break;
                                        }
                                        break;

                                    case 2: Console.Clear(); difficulty.tutor1(); break;
                                    case 3: Console.Clear(); break;

                                }
                                break;
                            }
                        case 2: { Console.Clear(); Console.WriteLine("Сорь, но загрузка пока недоступна *>*'\n"); Console.WriteLine("Нажмите любую клавишу..."); Console.ReadKey(); break; }

                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("Ты точно хочешь выйти из СУППЕРПУППЕРМЕГАКАЗИНЫЧ Simulator?"); int answe = Int32.Parse(Console.ReadLine());
                                switch (answe)
                                {
                                    case 1: { return; }
                                    case 2: { break; }
                                }
                                break;

                            }
                    }
                }

            }
        }
    }
}
