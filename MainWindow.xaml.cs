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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tela_adm
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/escolas.xaml", UriKind.Relative);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/Cursos.xaml", UriKind.Relative);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/Turmas.xaml", UriKind.Relative);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/Professores.xaml", UriKind.Relative);
        }

        private void framePage_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/Alunos.xaml", UriKind.Relative);
        }
    }
}
