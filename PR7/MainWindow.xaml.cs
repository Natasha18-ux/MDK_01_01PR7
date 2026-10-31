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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Canvas myCanvas = new Canvas();
            myCanvas.Width = 300;
            myCanvas.Height = 300;

            Rectangle rect = new Rectangle();
            rect.Width = 100;
            rect.Height = 60;
            rect.Fill = Brushes.LightCoral;
           

            myCanvas.Children.Add(rect);

            // Показываем Canvas как содержимое окна
            this.Content = myCanvas;
        }
    }
}
