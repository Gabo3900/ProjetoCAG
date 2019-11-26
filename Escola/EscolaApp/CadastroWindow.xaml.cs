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
using Modelo;

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para CadastroWindow.xaml
    /// </summary>
    public partial class CadastroWindow : Window
    {
        private Administrador a;

        public CadastroWindow()
        {
            InitializeComponent();
        }

        private void CadastroClick(object sender, RoutedEventArgs e)
        {
            string n = txtNome.Text;
            string em = txtEmail.Text;
            a = new Administrador(n, "123", em);
        }
    }
}
