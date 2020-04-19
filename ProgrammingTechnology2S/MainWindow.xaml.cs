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

namespace ProgrammingTechnology2S
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainVM();
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            errorBlock.Text = string.Empty;
            string path = string.Empty;
            try
            {
                path = projectsBox.SelectedItem.ToString() + ".exe";
                
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                errorBlock.Text = ex.Message;
            }           
        }
    }
}
