using SuperFlange.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SuperFlange
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void SetTheme(Theme theme)
        {
            this.Resources.MergedDictionaries[0].Source = new Uri($"/{theme}.xaml", UriKind.Relative);
        }
    }
}
