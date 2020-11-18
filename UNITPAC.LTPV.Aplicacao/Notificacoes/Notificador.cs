using System.Collections.Generic;
using System.Linq;
using UNITPAC.LTPV.Aplicacao.Interfaces;

namespace UNITPAC.LTPV.Aplicacao.Notificacoes
{
    public class Notificador : INotificador
    {
        //lista de notificaçoes 

        private List<Notificacao> _notificacoes { get; set; }

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
