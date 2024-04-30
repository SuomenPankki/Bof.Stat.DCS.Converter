using Bof.Stat.DCS.Converter.Model;

namespace Bof.Stat.DCS.Converter.BL.Converters
{
    public interface IConverter
    {
        public List<ConversionResult> Convert();
    }
}
