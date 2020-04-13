using SuperFlange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SuperFlange.ViewModel
{
    public class MainViewModel : ViewModel
    {
        public Flange FirstFlange { get; set; }
        public Flange SecondFlange { get; set; }
        public Bolt Bolt { get; set; }
        public Gasket Gasket { get; set; }
        public OperatingConditions OperatingConditions { get; set; }

        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MaximizeRestoreCommand { get; set; }
        public ICommand CloseWindowCommand { get; set; }
        public ICommand SetDarkThemeCommand { get; set; }
        public ICommand SetLightThemeCommand { get; set; }

        public ICommand SelectCommand { get; set; }
        public ICommand SolveCommand { get; set; }

        public MainViewModel()
        {
            FirstFlange = new Flange();
            SecondFlange = new Flange();
            Bolt = new Bolt();
            Gasket = new Gasket();
            OperatingConditions = new OperatingConditions();

            MinimizeWindowCommand = new Command(Minimize);
            MaximizeRestoreCommand = new Command(MaximizeRestore);
            CloseWindowCommand = new Command(CloseWindow);
            SetDarkThemeCommand = new Command(() => SetTheme(Theme.Dark));
            SetLightThemeCommand = new Command(() => SetTheme(Theme.Light));
            SolveCommand = new Command(() => Solve());
        }

        public void CloseWindow()
        {
            Application.Current.MainWindow.Close();
        }

        public void MaximizeRestore()
        {
            Window mainWindow = Application.Current.MainWindow;

            if (mainWindow.WindowState == WindowState.Maximized)
                mainWindow.WindowState = WindowState.Normal;
            else if (mainWindow.WindowState == WindowState.Normal)
                mainWindow.WindowState = WindowState.Maximized;
        }

        public void Minimize()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        public void SetTheme(Theme theme)
        {
            ((App)Application.Current).SetTheme(theme);
        }

        public void Solve()
        {
            using (SuperFlangeSolverNative.SuperFlangeSolver solver = new SuperFlangeSolverNative.SuperFlangeSolver())
            {
                //solver.superflangeNaim(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
                solver.superflange();
            }
        }
    }

    public enum Theme
    {
        Dark, 
        Light
    }
}
