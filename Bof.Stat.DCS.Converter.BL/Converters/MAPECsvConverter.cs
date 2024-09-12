using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.Mappings;
using Bof.Stat.DCS.Converter.Model.XML;
using Bof.Stat.DCS.Converter.Model.XML.MAPE;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Bof.Stat.DCS.Converter.BL
{
    public class MAPECsvConverter : CsvConverterBase
    {
        public MAPECsvConverter(CsvFile csvFile) : base(csvFile)
        {

        }

        protected override AutoMappingBase GetAutoMapping()
        {
            return new MAPEAutoMapping();
        }

        protected override string GetFilename(IXmlReport report)
        {
            return $"{csvFile.Header.ReporterIdentifier}_{csvFile.Header.TypeOfReporterIdentifier}_{csvFile.Header.Frequency}_{csvFile.Survey + csvFile.Header.Frequency}_{csvFile.Header.ReportingPeriodEnd.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}_{csvFile.Header.CreationDate.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture)}000.XML";
        }

        protected override List<IXmlReport> GetXmlReports(CsvFile csvFile, IMapper mapper)
        {
            var report = new MapeReport
            {
                SchemaVersion = "1.0",
                Header = mapper.Map<HeaderType>(csvFile.Header),
                AccoRecords = mapper.Map<Collection<AccoType>>(csvFile.DataRows.OfType<MAPE_ACCO>().ToList()) is Collection<AccoType> acco && acco.Count > 0 ? acco : null,
                ApayRecords = mapper.Map<Collection<ApayType>>(csvFile.DataRows.OfType<MAPE_APAY>().ToList()) is Collection<ApayType> apay && apay.Count > 0 ? apay : null,
                HpayRecords = mapper.Map<Collection<HpayType>>(csvFile.DataRows.OfType<MAPE_HPAY>().ToList()) is Collection<HpayType> hpay && hpay.Count > 0 ? hpay : null,
                QpayRecords = mapper.Map<Collection<QpayType>>(csvFile.DataRows.OfType<MAPE_QPAY>().ToList()) is Collection<QpayType> qpay && qpay.Count > 0 ? qpay : null,
                CardRecords = mapper.Map<Collection<CardType>>(csvFile.DataRows.OfType<MAPE_CARD>().ToList()) is Collection<CardType> card && card.Count > 0 ? card : null,
                ServRecords = mapper.Map<Collection<ServType>>(csvFile.DataRows.OfType<MAPE_SERV>().ToList()) is Collection<ServType> serv && serv.Count > 0 ? serv : null,
                TermRecords = mapper.Map<Collection<TermType>>(csvFile.DataRows.OfType<MAPE_TERM>().ToList()) is Collection<TermType> term && term.Count > 0 ? term : null
            };

            return new List<IXmlReport>() { report };
        }
    }
}
