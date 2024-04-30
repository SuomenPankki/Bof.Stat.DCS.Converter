using Bof.Stat.DCS.Converter.Model.CSV;
using CsvHelper.Configuration;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class MAPE_SERVMap : ClassMap<MAPE_SERV>
    {
        public MAPE_SERVMap()
        {
            Map(m => m.Service).Index(3);
            Map(m => m.Amount).Index(4);
        }
    }
}
