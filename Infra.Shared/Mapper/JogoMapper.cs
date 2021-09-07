using AutoMapper;
using Jogos.DIO.Domain.Entities;
using Jogos.DIO.Domain.Models;
using System.Collections.Generic;

namespace Infra.Shared.Mapper
{
    public static class JogoMapper
    {
        private readonly static IMapper _mapper;
        static JogoMapper()
        {
            _mapper = MapperConfig.RegisterMappers();
        }
        public static JogoEntity ConverterParaJogoEntity(this JogoModel jogoModel) =>
            _mapper.Map<JogoEntity>(jogoModel);
        public static IEnumerable<JogoEntity> ConverterParaJogosEntity(this IEnumerable<JogoModel> jogoModel) =>
            _mapper.Map<IEnumerable<JogoEntity>>(jogoModel);

        public static JogoModel ConverterParaJogoModel(this JogoEntity jogoEntity) =>
           _mapper.Map<JogoModel>(jogoEntity);
        public static IEnumerable<JogoModel> ConverterParaJogosModel(this IEnumerable<JogoEntity> jogoEntity) =>
            _mapper.Map<IEnumerable<JogoModel>>(jogoEntity);

    }
}
