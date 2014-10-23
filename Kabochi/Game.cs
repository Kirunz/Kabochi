using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Kabochi
{
    namespace Core
    {
        class Game
        {
            public Form gameForm;
            public Input input;
            public DrawManager drawManager;

            public Game()
            {
                gameForm = new Form();
                input = new Input(this);
                drawManager = new DrawManager(this);
                gameForm.Width = 640;
                gameForm.Height = 480;
                gameForm.StartPosition = FormStartPosition.CenterScreen;
                Console.WriteLine("Window is created");
                Application.Run(gameForm);
                Console.WriteLine("Closing");
            }


        }
    }
}
