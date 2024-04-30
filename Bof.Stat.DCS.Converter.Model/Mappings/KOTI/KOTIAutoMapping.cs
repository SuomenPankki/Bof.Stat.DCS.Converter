using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.XML.KOTI;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class KOTIAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<KOTI_BS, BsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<KOTI_BS, BsType>()));

            cfg.CreateMap<KOTI_BSIA, BsiaType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<KOTI_BSIA, BsiaType>()));
            cfg.CreateMap<KOTI_CS, CsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<KOTI_CS, CsType>()));

            cfg.CreateMap<KOTI_CSIA, CsiaType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<KOTI_CSIA, CsiaType>()));

            cfg.CreateMap<KOTI_CSDR, CsdrType>()
             .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<KOTI_CSDR, CsdrType>()));

        }
    }
}
