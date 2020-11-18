using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Data.Interfaces;
using UNITPAC.LTPV.Dominio.AlunosRoot;

namespace UNITPAC.LTPV.Aula03
{
    public partial class FrmCadastroAluno : Form
    {
        private IAlunoRepositorio _repositorio;

        public FrmCadastroAluno()
        {
            InitializeComponent();
            _repositorio = Program.container.GetInstance<IAlunoRepositorio>();
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            GridAlunos.DataSource = _repositorio.ObterTodos();
        }

        ///
        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private Aluno MapearDominio()
        {
            Aluno model = new Aluno();

            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                model.Id = Convert.ToInt32(TxtId.Text);
            }

            model.Nome = TxtNome.Text;
            model.SobreNome = TxtSobrenome.Text;

            if (string.IsNullOrEmpty(TxtNascimento.Text.Replace(" ", "").Replace("/", ""))) 
            {
                model.DataNascimento = DateTime.Now.AddDays(1).Date;
            }
            else
            {
                model.DataNascimento = Convert.ToDateTime(TxtNascimento.Text);
            }
            model.Matricula = TxtMatricula.Text;
            model.Observacoes = TxtObservacoes.Text;

            return model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno model = MapearDominio();

            IProfessorService service = Program.container.GetInstance<IProfessorService>();

            if (service.Adicionar(model))
            {
                PreencherGrid();

                MessageBox.Show(this, "Professor cadastrado com sucesso, certifique-se dos dados informados!", "LTP5", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparComponentes();

                TxtNome.Focus();
            }
            else
            {
                TxtNome.Focus();
                MessageBox.Show(this, "Não foi possivel adicionar o professor! \n\n " + service.ObterNotificacoes(), "LTP5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparComponentes()
        {
            TxtId.Text = string.Empty;
            TxtNome.Text = string.Empty;
            TxtSobrenome.Text = string.Empty;
            TxtNascimento.Text = string.Empty;
            TxtMatricula.Text = string.Empty;
            TxtObservacoes.Text = string.Empty;

            BtAdicionar.Enabled = true;
            BtAtualizar.Enabled = false;
            BtExcluir.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GridAlunos_DoubleClick(object sender, EventArgs e)
        {
            if(GridAlunos.Rows.Count == 0)
            {
                return;
            }

            int id = Convert.ToInt32(GridAlunos.SelectedRows[0].Cells[ColumnId.Index].Value);

            Aluno model = _repositorio.ObterPorId(id);

            TxtId.Text = model.Id.ToString();
            TxtNome.Text = model.Nome;
            TxtSobrenome.Text = model.SobreNome;
            TxtNascimento.Text = model.DataNascimento.ToString("dd/MM/yyyy");
            TxtMatricula.Text = model.Matricula;
            TxtObservacoes.Text = model.Observacoes;

            TxtNome.Focus();

            BtAdicionar.Enabled = false;
            BtAtualizar.Enabled = true;
            BtExcluir.Enabled = true;
        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            Aluno model = MapearDominio();

            IProfessorService service = Program.container.GetInstance<IProfessorService>();

            if (service.Atualizar(model))
            {
                PreencherGrid();

                MessageBox.Show(this, "Professor atualizado com sucesso, certifique-se dos dados informados!", "LTP5", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparComponentes();

                TxtNome.Focus();
            }
            else
            {
                TxtNome.Focus();
                MessageBox.Show(this, "Não foi possivel atualizar as informações! \n\n " + service.ObterNotificacoes(), "LTP5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(this, "Tem certeza que deseja excluir este registo" 
                + TxtId.Text + " - " + TxtNome.Text + " ? ", "LTPV",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if(resultado == DialogResult.No)
            {
                return;
            }

            IProfessorService service = Program.container.GetInstance<IProfessorService>();

            int id = Convert.ToInt32(TxtId.Text);

            if (service.Excluir(id))
            {
                PreencherGrid();

                MessageBox.Show(this, "Professor excluido com sucesso!",
                    "LTPV", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                LimparComponentes();
            }
            else
            {
                TxtNome.Focus();
                MessageBox.Show(this, "Não foi possivel excluir as informações! \n\n " + service.ObterNotificacoes(), "LTP5", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
