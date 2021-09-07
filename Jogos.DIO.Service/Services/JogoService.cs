using Infra.Shared.Mapper;
using Jogos.DIO.Domain.Interfaces;
using Jogos.DIO.Domain.Interfaces.Repositories;
using Jogos.DIO.Domain.Interfaces.Services;
using Jogos.DIO.Domain.Models;
using Jogos.DIO.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jogos.DIO.Service.Services
{
    public sealed class JogoService : IJogoService
    {
        private readonly IJogoRepository _jogoRepository;
        private readonly IUnitOfWork<JogoContext> _unitOfWork;

        public JogoService(IJogoRepository jogoRepository, IUnitOfWork<JogoContext> unitOfWork)
        {
            _jogoRepository = jogoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Atualizar(JogoModel jogo)
        {
            var oJogoEntity = jogo.ConverterParaJogoEntity();
            _jogoRepository.Atualizar(oJogoEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<JogoModel> ConsultarPorId(int id)
        {
            var oJogoEntity = await _jogoRepository.ConsultarPorId(id);
            return oJogoEntity.ConverterParaJogoModel();
        }

        public async Task Excluir(int id)
        {
            _jogoRepository.Excluir(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task Inserir(JogoModel jogo)
        {
            var oJogoEntity = jogo.ConverterParaJogoEntity();
            await _jogoRepository.Incluir(oJogoEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<JogoModel>> Listar()
        {
            var lstJogoEntity = await _jogoRepository.Listar();
            return lstJogoEntity.ConverterParaJogosModel();
        }
    }
}
