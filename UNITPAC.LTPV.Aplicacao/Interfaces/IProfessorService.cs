using UNITPAC.LTPV.Dominio.AlunosRoot;

namespace UNITPAC.LTPV.Aplicacao.Interfaces
{
    public interface IProfessorService : IBaseService
    {
        bool Adicionar(Aluno model);
        bool Atualizar(Aluno model);
        bool Excluir(int id);
    }
}
