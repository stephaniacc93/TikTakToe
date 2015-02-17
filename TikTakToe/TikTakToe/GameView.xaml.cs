using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using TikTakToe.Controls;
using TikTakToe.Logic;

namespace TikTakToe
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : MetroContentControl
    {
        private bool _computerTurn = false;
        private Factory _factory;
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();


        public GameView(string level)
        {
            InitializeComponent();
            _factory = new Factory(level);
            TurnLabel.Content = "Turno: Jugador";
            _factory.GameView = this;
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (_computerTurn)
            {
                SpaceControl space;
                do
                {
                    space = GetString(_factory.NewTurn());
                    _factory.GameView = this;
                    if (AllAreUsed())
                    {
                        AppearGameOverMessage();
                    }

                } while (space.IsUsed == true);
                if (!space.IsUsed)
                {
                    space.SetDecisionComputer();
                    _computerTurn = false;
                    TurnLabel.Content = "Turno: Jugador";
                    CheckIfAnyWinner();
                }
                else if (AllAreUsed())
                {
                    AppearGameOverMessage();
                }


            }
        }

        public async void AppearGameOverMessage()
        {
            dispatcherTimer.Stop();
            var metroWindow = (MetroWindow)System.Windows.Application.Current.MainWindow;
            metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;

            await metroWindow.ShowMessageAsync("Game Over", "No hay mas espacios por seleccionar", MessageDialogStyle.Affirmative, metroWindow.MetroDialogOptions);
            OnGoToMenuClicked();
        }

        private async void SpaceControl_OnSpaceClicked(object o)
        {
            if (!_computerTurn)
            {
                SpaceControl space = (SpaceControl)o;

                if (!space.IsUsed)
                {
                    space.SetDecisionPlayer();
                    _computerTurn = true;
                    TurnLabel.Content = "Turno: Computadora";
                    CheckIfAnyWinner();
                }
                else if (AllAreUsed())
                {
                    AppearGameOverMessage();
                }
            }
        }


        public bool CheckIfAnyWinner()
        {

            if (SpaceControl1.Owner == "PC" && SpaceControl2.Owner == "PC" && SpaceControl3.Owner == "PC")
            {
                WinnerNotification("PC");
                return true;
            }
            else if (SpaceControl1.Owner == "Player" && SpaceControl2.Owner == "Player" &&
                     SpaceControl3.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }
            else if (SpaceControl4.Owner == "PC" && SpaceControl5.Owner == "PC" && SpaceControl6.Owner == "PC")
            {
                WinnerNotification("Player");
                return true;
            }
            else if (SpaceControl4.Owner == "Player" && SpaceControl5.Owner == "Player" &&
                     SpaceControl6.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }

            else if (SpaceControl7.Owner == "PC" && SpaceControl8.Owner == "PC" && SpaceControl9.Owner == "PC")
            {
                WinnerNotification("PC");
                return true;
            }
            else if (SpaceControl7.Owner == "Player" && SpaceControl8.Owner == "Player" &&
                     SpaceControl9.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }
            else if (SpaceControl1.Owner == "PC" && SpaceControl4.Owner == "PC" && SpaceControl7.Owner == "PC")
            {
                WinnerNotification("PC");
                return true;
            }
            else if (SpaceControl1.Owner == "Player" && SpaceControl4.Owner == "Player" &&
                     SpaceControl7.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }
            else if (SpaceControl2.Owner == "PC" && SpaceControl5.Owner == "PC" && SpaceControl8.Owner == "PC")
            {
                WinnerNotification("PC");
                return true;
            }
            else if (SpaceControl2.Owner == "Player" && SpaceControl5.Owner == "Player" &&
                     SpaceControl8.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }
            else if (SpaceControl3.Owner == "PC" && SpaceControl6.Owner == "PC" && SpaceControl9.Owner == "PC")
            {
                WinnerNotification("PC");
                return true;
            }
            else if (SpaceControl3.Owner == "Player" && SpaceControl6.Owner == "Player" &&
                     SpaceControl9.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }
            else if (SpaceControl1.Owner == "PC" && SpaceControl5.Owner == "PC" && SpaceControl9.Owner == "PC")
            {
                WinnerNotification("PC");
                return true;
            }
            else if (SpaceControl1.Owner == "Player" && SpaceControl5.Owner == "Player" &&
                     SpaceControl9.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }
            else if (SpaceControl7.Owner == "PC" && SpaceControl5.Owner == "PC" && SpaceControl3.Owner == "PC")
            {
                WinnerNotification("PC");
                return true;
            }
            else if (SpaceControl7.Owner == "Player" && SpaceControl5.Owner == "Player" &&
                     SpaceControl3.Owner == "Player")
            {
                WinnerNotification("Player");
                return true;
            }
            return false;
        }

        public SpaceControl GetString(int space)
        {
            if (space == 1)
            {
                return SpaceControl1;
            }
            else if (space == 2)
            {
                return SpaceControl2;
            }
            else if (space == 3)
            {
                return SpaceControl3;
            }
            else if (space == 4)
            {
                return SpaceControl4;
            }
            else if (space == 5)
            {
                return SpaceControl5;
            }
            else if (space == 6)
            {
                return SpaceControl6;
            }
            else if (space == 7)
            {
                return SpaceControl7;
            }
            else if (space == 8)
            {
                return SpaceControl8;
            }
            else
            {
                return SpaceControl9;
            }
        }

        public bool AllAreUsed()
        {
            if (SpaceControl1.IsUsed == false)
                return false;
            else if (SpaceControl2.IsUsed == false)
                return false;
            else if (SpaceControl3.IsUsed == false)
                return false;
            else if (SpaceControl4.IsUsed == false)
                return false;
            else if (SpaceControl5.IsUsed == false)
                return false;
            else if (SpaceControl6.IsUsed == false)
                return false;
            else if (SpaceControl7.IsUsed == false)
                return false;
            else if (SpaceControl8.IsUsed == false)
                return false;
            else if (SpaceControl9.IsUsed == false)
                return false;
            else
                return true;
        }

        public async void WinnerNotification(string winner)
        {
            dispatcherTimer.Stop();
            if (winner == "Player")
            {
                var metroWindow = (MetroWindow)System.Windows.Application.Current.MainWindow;
                metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;

                var response = await metroWindow.ShowMessageAsync("Felicidades!", "Haz Ganado la Partida!",
                    MessageDialogStyle.Affirmative, metroWindow.MetroDialogOptions);
                if (response == MessageDialogResult.Affirmative)
                {
                    OnGoToMenuClicked();
                }
            }
            else
            {
                var metroWindow = (MetroWindow)System.Windows.Application.Current.MainWindow;
                metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;

                var response = await metroWindow.ShowMessageAsync("Boo!", "Perdiste, para la proxima!",
                    MessageDialogStyle.Affirmative, metroWindow.MetroDialogOptions);

                if (response == MessageDialogResult.Affirmative)
                {
                    OnGoToMenuClicked();
                }
            }
        }

        public List<SpaceControl> GetSpaceControls()
        {
            List<SpaceControl> spaceControls = new List<SpaceControl>();
            spaceControls.Add(SpaceControl1);
            spaceControls.Add(SpaceControl2);
            spaceControls.Add(SpaceControl3);
            spaceControls.Add(SpaceControl4);
            spaceControls.Add(SpaceControl5);
            spaceControls.Add(SpaceControl6);
            spaceControls.Add(SpaceControl7);
            spaceControls.Add(SpaceControl8);
            spaceControls.Add(SpaceControl9);
            return spaceControls;
        }
        public delegate void GoToMenulickedHandler();
        public event GoToMenulickedHandler MenuClicked;
        public void OnGoToMenuClicked()
        {
            if (MenuClicked != null)
            {
                MenuClicked();
            }
        }
    }
}
