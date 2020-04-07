using SuperFlange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SuperFlange.ViewModel
{
    public class MainViewModel : ViewModel
    {
        public Flange FirstFlange { get; set; }
        public Flange SecondFlange { get; set; }

        public PointCollection DefaultFlangePoints
        {
            get
            {
                PointCollection flangePolygon = new PointCollection();

                flangePolygon.Add(new Point(0, 0));
                flangePolygon.Add(new Point(0, 10));
                flangePolygon.Add(new Point(15, 50));
                flangePolygon.Add(new Point(65, 50));
                flangePolygon.Add(new Point(65, 80));
                flangePolygon.Add(new Point(0, 80));

                return flangePolygon;
            }
        }

        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MaximizeRestoreCommand { get; set; }
        public ICommand CloseWindowCommand { get; set; }
        public ICommand SetDarkThemeCommand { get; set; }
        public ICommand SetLightThemeCommand { get; set; }

        public MainViewModel()
        {
            FirstFlange = new Flange();
            SecondFlange = new Flange();

            MinimizeWindowCommand = new Command(Minimize);
            MaximizeRestoreCommand = new Command(MaximizeRestore);
            CloseWindowCommand = new Command(CloseWindow);
            SetDarkThemeCommand = new Command(() => SetTheme(Theme.Dark));
            SetLightThemeCommand = new Command(() => SetTheme(Theme.Light));
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

        public enum Theme
        {
            Dark, Light
        }
    }
}
