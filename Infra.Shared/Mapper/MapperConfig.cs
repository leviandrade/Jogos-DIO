using AutoMapper;
using Jogos.DIO.Domain.Entities;
using Jogos.DIO.Domain.Models;

namespace Infra.Shared.Mapper
{
    public class MapperConfig
    {
        public static IMapper RegisterMappers()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JogoEntity, JogoModel>().ReverseMap();
            });

            return config.CreateMapper();
        }
    }
}
