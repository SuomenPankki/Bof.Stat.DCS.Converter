using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.XML.RATI;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class RATIAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<RATI_BS, BsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<RATI_BS, BsType>()));

            cfg.CreateMap<RATI_IL, IlType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<RATI_IL, IlType>()));

            cfg.CreateMap<RATI_LD, LdType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<RATI_LD, LdType>()));

            cfg.CreateMap<RATI_SBS, SbsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<RATI_SBS, SbsType>()));

            cfg.CreateMap<RATI_REST, RestType>()
             .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<RATI_REST, RestType>()));
        }
    }
}
