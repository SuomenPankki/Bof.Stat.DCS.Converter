using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.XML.MAPE;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPEAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<MAPE_ACCO, AccoType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MAPE_ACCO, AccoType>()));

            cfg.CreateMap<MAPE_APAY, ApayType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MAPE_APAY, ApayType>()));

            cfg.CreateMap<MAPE_HPAY, HpayType>()
                 .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MAPE_HPAY, HpayType>()));

            cfg.CreateMap<MAPE_QPAY, QpayType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MAPE_QPAY, QpayType>()));

            cfg.CreateMap<MAPE_CARD, CardType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MAPE_CARD, CardType>()));

            cfg.CreateMap<MAPE_SERV, ServType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MAPE_SERV, ServType>()));

            cfg.CreateMap<MAPE_TERM, TermType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<MAPE_TERM, TermType>()));
        }
    }
}
