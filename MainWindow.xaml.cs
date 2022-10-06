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

namespace WpfApp1_Практическая_2_Гуляева_Кристина_402
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Window2 window2 = new Window2();
            window2.Show();
            Window3 window3 = new Window3();
            window3.Show();
            Window4 window4 = new Window4();
            window4.Show();
            Window5 window5 = new Window5();
            window5.Show();
            Window6 window6 = new Window6();
            window6.Show();
            Window7 window7 = new Window7();
            window7.Show();
            Window8 window8 = new Window8();
            window8.Show();
            Window9 window9 = new Window9();
            window9.Show();
            Window10 window10 = new Window10();
            window10.Show();
            Window11 window11 = new Window11();
            window11.Show();
            Window12 window12 = new Window12();
            window12.Show();

        }
    }
    }

