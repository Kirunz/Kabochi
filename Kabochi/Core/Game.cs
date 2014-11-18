using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
namespace Kabochi
{
    namespace Core
    {
        //Базовый класс игры который инициализирует всё родное и дорогое нам
        class Game
        {
            public GameForm gameForm; //окошечко
            public InputManager inputManager;//Менеджер мыши\клавы
            public DrawManager drawManager;//Менеджер отрисовки
            public GameLogic gameLogic; //Вся обработка игровой логики
            public System.Windows.Forms.Timer timer; //внутриигровой таймер
            bool init;

            public Game()
            {
                gameForm = new GameForm(this);


                inputManager = new InputManager(this);
                drawManager = new DrawManager(this);
                gameLogic = new GameLogic(this);

                //System.Threading.TimerCallback tcb = this.GameFlow; //Инициализация и запуск таймера
                MediaPlayer player = new MediaPlayer();
                player.Open(new Uri(@"Haddaway-What is love.mp3", UriKind.Relative));
                //player.Play();
                init = true;
                Application.Run(gameForm);
                Console.WriteLine("Closing");
            }

            public void GameFlow(object sender, EventArgs e)   //Метод, запускаемый таймером
            {                   
                // Запускает методы отрисовки и обновления состояния игры
                if (!init) return;
                //Visual a = new Visual();
                gameLogic.GameStep();
                drawManager.DrawFrame();
                
            }

        }
    }
}
