using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.XML.MURA;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MURAAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<MURA_BS, BsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MURA_BS, BsType>()));

            cfg.CreateMap<MURA_LD, LdType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MURA_LD, LdType>()));

            cfg.CreateMap<MURA_SBS, SbsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MURA_SBS, SbsType>()));

            cfg.CreateMap<MURA_REST, RestType>()
             .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MURA_REST, RestType>()));
        }
    }
}
