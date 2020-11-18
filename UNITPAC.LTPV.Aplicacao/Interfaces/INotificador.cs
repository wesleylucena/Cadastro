using System.Collections.Generic;
using UNITPAC.LTPV.Aplicacao.Notificacoes;

namespace UNITPAC.LTPV.Aplicacao.Interfaces
{
    public interface INotificador
    {
        void Handle(Notificacao notificacao);
        List<Notificacao> ObterNotificacoes();
        bool TemNotificacao();
    }
}
