
namespace TaxiCALC.Data
{
    public enum vognType
    {
        Almindelig,
        AlmindeligAften,
        Stor,
        StorSpecial
    }

    public class TaxiData
    {
        public vognType ?vognNavn;

        public decimal startPris = 0;

        public double Kilometerpris = 0;

        public double minutPris = 0;

        internal decimal TotalPris;
    }

    
        public class CustomerChoices
        {
            public vognType SelectedVognType { get; set; }

            public bool TransportAfCykel { get; set; } = false;
            public bool Opbaering { get; set; } = false;
            public bool HjaelpTilOpbaering { get; set; } = false;
            public bool Lufthavn { get; set; } = false;
            public bool AfhentningILufthavn { get; set; } = false;
            public bool FemPersonerEllerOver { get; set; } = false;
            public bool Liftvogn { get; set; } = false;
            public bool Oeresundsbro { get; set; } = false;
            public bool Storebaeltsbroen { get; set; } = false;

            //Customer Input Data Holders. Uint insures that the user can not input negative numbers.
            public uint EstimatedTime { get; set; } 
            public uint DistanceInKm { get; set; }

            public decimal? TotalPris { get; set; }

            // Additional fee amounts
            public decimal CykelTillaeg { get; set; } = 30.00m;
            public decimal OpbaeringTillaeg { get; set; } = 30.00m;
            public decimal LufthavnTillaeg { get; set; } = 15.00m;
            public decimal FemPersonerEllerOverTillaeg { get; set; } = 40.00m;
            public decimal LiftvognTillaeg { get; set; } = 350.00m;
            public decimal OeresundsbroTillaeg { get; set; } = 350.00m;
            public decimal StorebaeltsbroenTillaeg { get; set; } = 540.00m;
        }
    
        

}