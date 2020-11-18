using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNITPAC.LTPV.Aula03
{
    public partial class FrmPrincipal : Form //Classe
    {
        public FrmPrincipal() //Construtor
        {
            InitializeComponent(); //Método do Form
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void GrbPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovo frm = new FrmNovo();
            frm.ShowDialog();
        }


        private void Click_nubank(object sender, EventArgs e)
        {
            var nubank = new Nubank();
            nubank.ShowDialog();
        }

        private void Click_bb(object sender, EventArgs e)
        {
            var bb = new BB();
            bb.ShowDialog();
        }

        private void Click_caixa(object sender, EventArgs e)
        {
            var bcaixa = new Caixa();
            bcaixa.ShowDialog();
        }

        private void Click_agiota(object sender, EventArgs e)
        {
            var agiota = new Agiotas();
            agiota.ShowDialog();
        }

        private void CadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastrar = new FrmCadastroAluno();
            cadastrar.ShowDialog();
        }
    }
}
