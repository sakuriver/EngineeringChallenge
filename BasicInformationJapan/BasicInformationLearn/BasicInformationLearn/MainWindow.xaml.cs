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

namespace BasicInformationLearn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<int> drawLines;
        public MainWindow()
        {
            InitializeComponent();

            SettingTextArea.Visibility = Visibility.Hidden;
        }
        private void SettingTextArea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SettingViewButton_Click(object sender, RoutedEventArgs e)
        {
            if (SettingTextArea.Visibility == Visibility.Hidden)
            {
                SettingTextArea.Visibility = Visibility.Visible;
            }
            else
            {
                SettingTextArea.Visibility = Visibility.Hidden;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CalcStartButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
