// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaGrowData", columnHash: 0xd870e208 )]
    public class EurekaGrowData : IExcelRow
    {
        
        public ushort BaseResistance;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BaseResistance = parser.ReadColumn< ushort >( 0 );
        }
    }
}