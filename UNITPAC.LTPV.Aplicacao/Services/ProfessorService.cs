using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Aplicacao.Services.Base;
using UNITPAC.LTPV.Aplicacao.Validation;
using UNITPAC.LTPV.Data.Interfaces;
using UNITPAC.LTPV.Dominio.AlunosRoot;

namespace UNITPAC.LTPV.Aplicacao.Services
{
    public class ProfessorService : BaseService, IProfessorService
    {
        private readonly IAlunoRepositorio _repository;

        public ProfessorService(INotificador notificador,
                                IAlunoRepositorio repository) : base(notificador)
        {
            _repository = repository;
        }

        public bool Adicionar(Aluno model)
        {
            if (!ExecutarValidacao(new ProfessorValidation(), model))
                return false;

            try
            {
                _repository.Adicionar(model);
                return true;
            }
            catch(Exception ex)
            {
                Notificar("ERRO! Nao foi possivel realizar o cadastro do professor!" + ex.Message);
                return false;
            }
        }

        public bool Atualizar(Aluno model)
        {
            if (!ExecutarValidacao(new ProfessorValidation(), model))
                return false;

            try
            {
                _repository.Atualizar(model);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("ERRO! Nao foi possivel realizar a atualização do professor!" + ex.Message);
                return false;
            }
        }

        public bool Excluir(int id)
        {
            Aluno model = _repository.ObterPorId(id);

            if(model.DataNascimento.Year < 1999)
            {
                Notificar("Nao é possivel excluir um professor antes de 1999!");
                return false;
            }

            try
            {
                _repository.Excluir(id);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("ERRO! Nao foi possivel excluir!" + ex.Message);
                return false;
            }
        }
    }
}
