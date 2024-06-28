using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.XML.TIHA;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class TIHAAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<TIHA_SBS, SbsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<TIHA_SBS, SbsType>()));
        }
    }
}
