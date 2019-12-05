using Modelo;
using Negocio;
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
using System.Windows.Shapes;

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        private Aluno aluno;   
        public AlunoWindow(Aluno a)
        {
            InitializeComponent();
            aluno = a;
        }

        private void Perfil_Button(object sender, RoutedEventArgs e)
        {
            PerfilWindow w = new PerfilWindow(aluno);
            w.Show();
        }

        private void ListarAluno_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = (new NAluno()).ColegasDeClasse(aluno);
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            Close();
        }
    }
}
