using Newtonsoft.Json;

namespace NACHAParser
{
    public class BatchHeaderRecord
    {
        #region Properties

        [JsonProperty("bchHeaderId")]
        public string BchHeaderId { get; set; } = string.Empty;

        [JsonProperty("recType")]
        public RecordTypes RecType { get; set; }

        [JsonProperty("serviceClassCode")]
        public ServiceClass ServiceClassCode { get; set; }

        [JsonProperty("coName")]
        public string CoName { get; set; } = string.Empty;

        [JsonProperty("coDiscretionaryData")]
        public string? CoDiscretionaryData { get; set; }

        [JsonProperty("coId")]
        public string CoId { get; set; } = string.Empty;

        [JsonProperty("standardEntryClass")]
        public StandardEntryClassCode StandardEntryClass { get; set; }

        [JsonProperty("coEntDescription")]
        public string? CoEntDescription { get; set; }

        [JsonProperty("coDescriptiveDate")]
        public string? CoDescriptiveDate { get; set; }

        [JsonProperty("effectiveEntDate")]
        public string EffectiveEntDate { get; set; } = string.Empty;

        [JsonProperty("settlementDate")]
        public string? SettlementDate { get; set; }

        [JsonProperty("originatorStatusCode")]
        public char OriginatorStatusCode { get; set; }

        [JsonProperty("originatingDFIId")]
        public string OriginatingDFIId { get; set; } = string.Empty;

        [JsonProperty("bchNum")]
        public string BchNum { get; set; } = string.Empty;

        #endregion

        #region Methods

        public static BatchHeaderRecord ParseBatchHeader(string line)
        {
            return new BatchHeaderRecord
            {
                BchHeaderId = Guid.NewGuid().ToString(),
                RecType = (RecordTypes)int.Parse(line.Substring(0, 1)),
                ServiceClassCode = (ServiceClass)int.Parse(line.Substring(1, 3)),
                CoName = line.Substring(4, 16),
                CoDiscretionaryData = line.Substring(20, 20),
                CoId = line.Substring(40, 10),
                StandardEntryClass = ParseSEC(line.Substring(50, 3)),
                CoDescriptiveDate = line.Substring(63, 6),
                EffectiveEntDate = line.Substring(71, 6),
                SettlementDate = line.Substring(75, 3),
                OriginatorStatusCode = line[78],
                OriginatingDFIId = line.Substring(78, 8),
                BchNum = line.Substring(87, 7)
            };
        }
        private static StandardEntryClassCode ParseSEC(string value)
        {
            return value switch
            {
                "CCD" => StandardEntryClassCode.CCD,
                "PPD" => StandardEntryClassCode.PPD,
                "WEB" => StandardEntryClassCode.WEB,
                "TEL" => StandardEntryClassCode.TEL,
                "COR" => StandardEntryClassCode.COR,
                _ => throw new ArgumentException($"'{value}' is not a valid StandardEntryClassCode."),
            };
        }

        #endregion
    }
}