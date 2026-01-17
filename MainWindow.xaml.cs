using System;
using System.Windows;
using System.Windows.Threading;

namespace UnionLauncher
{
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
            
            // Dots animation - fixed width prevents pushing
            _timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(300) };
            int dotCount = 0;
            _timer.Tick += (s, e) =>
            {
                dotCount = (dotCount + 1) % 4;
                LoadingTextBlock.Text = $"Loading{new string('.', dotCount)}";
            };
            _timer.Start();
        }
    }
}
