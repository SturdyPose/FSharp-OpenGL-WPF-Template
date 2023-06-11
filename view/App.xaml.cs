using System;
using System.Windows;
using static FSharpCore.MainWindow;

namespace View{

    public partial class MainApp: Application
    {
        public MainApp()
        {
            this.Activated += StartElmish;
        }

        private void StartElmish(object sender, EventArgs e)
        {
            this.Activated -= StartElmish;
            // This is where you pass the control from c# to f#
            InitFSharpWPF(MainWindow);
        }
    }
}