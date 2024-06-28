using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.CSV.SIRA;
using Bof.Stat.DCS.Converter.Model.XML.SIRA;

namespace Bof.Stat.DCS.Converter.Model.Mappings.SIRA
{
    public class SIRAAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<SIRA_IF, IfType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<SIRA_IF, IfType>()));

            cfg.CreateMap<SIRA_ITEM, ItemType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<SIRA_ITEM, ItemType>()));

            cfg.CreateMap<SIRA_SBS, SbsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<SIRA_SBS, SbsType>()));
        }
    }
}
