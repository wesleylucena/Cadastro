using System.Collections.Generic;
using UNITPAC.LTPV.Dominio.AlunosRoot;

namespace UNITPAC.LTPV.Data.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> ObterTodos();
        void Adicionar(Aluno model);
        void Atualizar(Aluno model);
        void Excluir(int id);
        Aluno ObterPorId(int id);
    }
}
