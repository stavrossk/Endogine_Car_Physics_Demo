using System;
using System.Windows.Forms;
using Endogine;

namespace DriverApp
{
    class Program
    {


        [STAThread]
        static void Main(string[] args)
        {
            EndogineHub endogine = new EndogineHub(Application.ExecutablePath);

            Main main = new Main();
            main.Show();

            //endogine.Init(main, null, null);
            endogine.Init(main, main, main);
            

            main.EndogineInitDone();

            Driver.Game game = new Driver.Game();

            while (endogine.MainLoop())
                Application.DoEvents();

        }


    }
}
