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
    /// Lógica interna para CadastrarMatrizWindow.xaml
    /// </summary>
    public partial class CadastrarMatrizWindow : Window
    {
        NMatrizCurricular n = new NMatrizCurricular();
        public CadastrarMatrizWindow()
        {
            InitializeComponent();
            NCurso nc = new NCurso();
            boxCurso.ItemsSource = nc.Listar();
            NDisciplina nd = new NDisciplina();
            boxDisciplina.ItemsSource = nd.Listar();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            MatrizCurricular mc = new MatrizCurricular();
            Curso c = boxCurso.SelectedItem as Curso;
            if (c != null) { mc.CursoId = c.Id;
                Disciplina d = boxDisciplina.SelectedItem as Disciplina;
                if (d != null) { mc.DisciplinaId = d.Id; }
                else { MessageBox.Show("Nenhum item foi selecionado"); }
                n.Inserir(mc);
            }
            else { MessageBox.Show("Nenhum item foi selecionado"); }
            grid.ItemsSource = n.Listar();
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.Listar();
        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            MatrizCurricular mc = grid.SelectedItem as MatrizCurricular;
            Curso c = boxCurso.SelectedItem as Curso;
            if (c != null)
            {
                mc.CursoId = c.Id;
                Disciplina d = boxDisciplina.SelectedItem as Disciplina;
                if (d != null) { mc.DisciplinaId = d.Id; }
                else { MessageBox.Show("Nenhum item foi selecionado"); }
                n.Atualizar(mc);
            }
            else { MessageBox.Show("Nenhum item foi selecionado"); }
            grid.ItemsSource = n.Listar();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            MatrizCurricular mc = grid.SelectedItem as MatrizCurricular;
            if (mc != null)
            {
                n.Excluir(mc);
            }
            else MessageBox.Show("Nenhum item foi selecionado!");
            grid.ItemsSource = n.Listar();
        }
    }
}
