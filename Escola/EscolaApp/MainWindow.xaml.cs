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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EscolaApp
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

        private void Button_Entrar(object sender, RoutedEventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Password;
            bool logou = false;
            if (nome == "Admin" && senha == "123")
            {
                logou = true;
                AdministradorWindow w = new AdministradorWindow();
                w.Show();
                Close();
            }
            NAluno n = new NAluno();
            foreach (Aluno a in n.Listar())
            {
                if (nome == a.Nome && senha == Criptografia.Descriptografar(a.Senha))
                {
                    logou = true;
                    AlunoWindow w = new AlunoWindow(a);
                    w.Show();
                    Close();
                }
            }
            if (!logou) MessageBox.Show("Senha ou usuário inválido");
        }
    }
}
