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
using PR7.classes;

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
            myCanvas.Width = 450;
            myCanvas.Height = 450;

            var round = new Round(Color: Brushes.DarkKhaki, radiys: 50, myCanvas);
            round.Draw();

            var trangl = new Trangl(Color: Brushes.Brown, myCanvas,
                p1: new Point(50, 150), p2: new Point(150, 50), p3: new Point(250, 150));
            trangl.Draw();
            // Показываем Canvas как содержимое окна
            this.Content = myCanvas;



        }

        
        private void getFigur(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
