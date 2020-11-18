using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UNITPAC.LTPV.Data.Context;
using UNITPAC.LTPV.Data.Interfaces;
using UNITPAC.LTPV.Dominio.AlunosRoot;

namespace UNITPAC.LTPV.Data.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private LTPVContext _context;

        public AlunoRepositorio()
        {
            _context = new LTPVContext();
        }

        public List<Aluno> ObterTodos()
        {
            return _context.Alunos.AsNoTracking().ToList();
        }

        public void Adicionar(Aluno model)
        {
            _context.Alunos.Add(model);
            _context.SaveChanges();
        }

        public void Atualizar(Aluno model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            Aluno model = _context.Alunos.Where(a => a.Id == id).First();

            _context.Alunos.Remove(model);

            _context.SaveChanges();
        }

        public Aluno ObterPorId(int id)
        {
            return _context.Alunos.Where(a => a.Id == id).AsNoTracking().First();
        }
    }
}
