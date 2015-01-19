using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kabochi
{
    class Program
    {
        [STAThread] //Такой типа (?) потока нужен для работы Input.Keyboard как минимум
        static void Main(string[] args)
        {
            //if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftShift) == true)
            //    MessageBox.Show("Got it!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Processing...");
            Core.Game game = new Core.Game();
            //Console.ReadLine();
        }
    }
}
