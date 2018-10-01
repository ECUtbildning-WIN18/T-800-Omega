using System;


namespace T800.Domain        //Ska det stå .Domain här? Det blir dock inga röda streck undertill!! Eller ska det stå "using T-800-Omega.Domain" ovan?
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.RunningMenu();
        }
    }
}
