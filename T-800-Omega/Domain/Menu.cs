using System;
using System.Collections.Generic;
using System.Text;


namespace T800.Domain
{
    class Menu
    {
        T800 t800 = new T800(0, true, true, true, null);
        T800Collection t800s = new T800Collection();
        BaseObject b1 = new BaseObject(1, true);
        BaseObject b2 = new BaseObject(2, true);
        BaseObject b3 = new BaseObject(3, true);


        public Menu()
        {
            Console.WriteLine(t800);
            t800s.GetNumberOne().ChooseTarget(b3);
        }


        public void RunningMenu()
        {
            int usersChoice = 0;
            bool loop = true;
            do
            {
                Console.WriteLine("======MENU======");
                Console.WriteLine(" ");

                Console.WriteLine("1. Activate");
                Console.WriteLine("2. Deactivate");
                Console.WriteLine("3. Self-Destruct");
                Console.WriteLine("4. Show Status");
                Console.WriteLine("5. Choose Target");
                Console.WriteLine("6. Attack");
                Console.WriteLine("7. Attack All targets");
                Console.Write(">> ");

                try
                {
                    usersChoice = int.Parse(Console.ReadLine());
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("Wrong answer!!!:( You have to press a digit between 1-7");
                }
            } while (loop);
            Console.Clear();

            switch (usersChoice)
            {
                case 1:
                    t800.Activate();
                    break;

                case 2:
                    t800.Deactivate();
                    break;

                case 3:
                    t800.SelfDestruct();
                    break;

                case 4:
                    t800.ShowStatus();
                    break;

                case 5:
                    t800.ChooseTarget(b2);
                    break;

                case 6:
                    t800.Attack();
                    break;

                case 7:
                    t800s.AttackAllTargets();
                    break;
                default:
                    RunningMenu();
                    break;

            }
            
            if(Console.ReadKey().Key!=ConsoleKey.Escape)
            {
                RunningMenu();
            }
            
        }

    }

  
}
