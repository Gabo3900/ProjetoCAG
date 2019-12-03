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
    /// Lógica interna para CadastrarTurmaWindow.xaml
    /// </summary>
    public partial class CadastrarTurmaWindow : Window
    {
        NTurma n = new NTurma(); 
        public CadastrarTurmaWindow()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Turma c = new Turma();
            c.Nome = txtTurma.Text;
            n.Inserir(c);
        }
    }
}
