using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Aplicacao.Notificacoes;
using UNITPAC.LTPV.Aplicacao.Services;
using UNITPAC.LTPV.Data.Interfaces;
using UNITPAC.LTPV.Data.Repositorios;

namespace UNITPAC.LTPV.Aula03
{
    static class Program
    {
        public static Container container;

        public static void Bootstrap()
        {
            container = new Container();

            container.Register<IAlunoRepositorio, AlunoRepositorio>();

            container.Register<INotificador, Notificador>();
            container.Register<IProfessorService, ProfessorService>();

            container.Verify();
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new FrmPrincipal());
        }
    }
}
