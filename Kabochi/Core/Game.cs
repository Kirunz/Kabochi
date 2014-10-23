using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace Kabochi
{
    namespace Core
    {
        //Базовый класс игры который инициализирует всё родное и дорогое нам
        class Game
        {
            public Form gameForm; //окошечко
            public InputManager inputManager;//Менеджер мыши\клавы
            public DrawManager drawManager;//Менеджер отрисовки
            public GameLogic gameLogic; //Вся обработка игровой логики
            private System.Threading.Timer timer; //внутриигровой таймер

            public Game()
            {
                gameForm = new Form();
                gameForm.Width = 640;
                gameForm.Height = 480;
                gameForm.StartPosition = FormStartPosition.CenterScreen;
                Console.WriteLine("Window is created");

                inputManager = new InputManager(this);
                drawManager = new DrawManager(this);
                gameLogic = new GameLogic(this);

                System.Threading.TimerCallback tcb = this.GameFlow; //Инициализация и запуск таймера
                timer = new System.Threading.Timer(tcb, null, 0, 20);

                Application.Run(gameForm);
                Console.WriteLine("Closing");
            }

            public void GameFlow(Object stateInfo)   //Метод, запускаемый таймером
            {                                       // Запускает методы отрисовки и обновления состояния игры
                drawManager.DrawFrame();
                gameLogic.GameStep();
            }

        }
    }
}
