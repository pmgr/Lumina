// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WarpLogic", columnHash: 0x4684fa1c )]
    public class WarpLogic : IExcelRow
    {
        public struct UnkStruct13Struct
        {
            public uint Argument;
        }
        
        public uint Unknown0;
        public string WarpName;
        public bool CanSkipCutscene;
        public string[] Function;
        public UnkStruct13Struct[] UnkStruct13;
        public string Question;
        public string ResponseYes;
        public string ResponseNo;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            WarpName = parser.ReadColumn< string >( 1 );
            CanSkipCutscene = parser.ReadColumn< bool >( 2 );
            Function = new string[ 10 ];
            for( var i = 0; i < 10; i++ )
                Function[ i ] = parser.ReadColumn< string >( 3 + i );
            UnkStruct13 = new UnkStruct13Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct13[ i ] = new UnkStruct13Struct();
                UnkStruct13[ i ].Argument = parser.ReadColumn< uint >( 13 + ( i * 1 + 0 ) );
            }
            Question = parser.ReadColumn< string >( 23 );
            ResponseYes = parser.ReadColumn< string >( 24 );
            ResponseNo = parser.ReadColumn< string >( 25 );
        }
    }
}