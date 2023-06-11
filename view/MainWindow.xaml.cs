using System;
using System.Windows;
using OpenTK.Wpf;
using static FSharpCore.OpenGL;

namespace View{
    public partial class MainWindow : Window
    {
        bool m_init = false;
        public MainWindow()
        {
            InitializeComponent();

            // Initialize OpenGL context
            // Check in MainWindow.xaml glWpfControl tag
            OpenTkControl.Start(new GLWpfControlSettings()
            {
                MajorVersion = 4,
                MinorVersion = 5
            });
        }

        private void OpenTkControl_OnRender(TimeSpan delta) {
            if(!m_init)
            {
                m_init = true;
                OnLoad();
            }
            OnRenderFrame((float) 1.0);
        }
    }
}