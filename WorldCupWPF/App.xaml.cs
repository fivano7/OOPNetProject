using PodatkovniSloj;
using PodatkovniSloj.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WorldCupWPF;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            if (!Repository.DaLiPostojePostavke())
            {
                new PocPostavke().Show();
            }
            else if (Repository.DaLiPostojePostavke() && Repository.DohvacanjePostavki().Count < 4)
            {
                new PocPostavke().Show();
            }
            else
            {
                new PregledReprezentacije().Show();
            }
        }

    }
}
