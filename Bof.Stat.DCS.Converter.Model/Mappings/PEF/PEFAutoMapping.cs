using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.CSV.PEF;
using Bof.Stat.DCS.Converter.Model.XML.PEF;

namespace Bof.Stat.DCS.Converter.Model.Mappings.PEF
{
    public class PEFAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<PEF_IF, IfType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<PEF_IF, IfType>()));

            cfg.CreateMap<PEF_PEF, PefType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<PEF_PEF, PefType>()));
        }
    }
}
