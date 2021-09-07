using Jogos.DIO.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jogos.DIO.Domain.Interfaces.Services
{
    public interface IJogoService
    {
        Task<IEnumerable<JogoModel>> Listar();
        Task<JogoModel> ConsultarPorId(int id);
        Task Excluir(int id);
        Task Inserir(JogoModel jogo);
        Task Atualizar(JogoModel jogo);
    }
}
