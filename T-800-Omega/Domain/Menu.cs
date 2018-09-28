using System;
using System.Collections.Generic;
using System.Text;

namespace T800.Domain
{
    class Menu
    {
        BaseObject baseobject = new BaseObject();

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
                Console.Write(">> ");

                try
                {
                    usersChoice = int.Parse(Console.ReadLine());
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("Wrong answer!!!:( You have to press a digit between 1-5");
                }
            } while (loop);

           switch (usersChoice)
            {
                case 1:
                    BaseObject.Activate();
                    break;

                case 2:
                    BaseObject.Deactivate();
                    break;

                case 3:
                    BaseObject.SelfDestruct();
                    break;

                case 4:
                    BaseObject.ShowStatus();
                    break;

                case 5:
                    BaseObject.ChooseTarget();
                    break;

                case 6:
                    BaseObject.Attack();
                    break;

                default:
                    RunningMenu();
                    break;
            }
        }
    }
}
