using AutoMapper;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public abstract class AutoMappingBase
    {
        protected abstract void GetMappings(IMapperConfigurationExpression cfg);

        public MapperConfiguration GetMapperConfigurations()
        {
            return new MapperConfiguration(cfg =>
            {
                GetMappings(cfg);
            });
        }

        protected static Func<TSource, TTarget, object, bool> GetNotNullOrEmptyCondition<TSource, TTarget>()
        {
            return (src, dest, srcMember) => srcMember != null && ((srcMember is string && !String.IsNullOrEmpty(srcMember as string)) || srcMember is not string);
        }
    }
}
