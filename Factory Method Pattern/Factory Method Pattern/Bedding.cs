using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    abstract class Bedding
    {
        protected string name;

        public string getName()
        {
            return name;
        }
    }

    class Blanket : Bedding
    {
        public Blanket()
        {
            name = "Blanket";
        }
    }

    class LBlanket : Bedding
    {
        public LBlanket()
        {
            name = "Large Blanket";
        }
    }

    class TwinSheets : Bedding
    {
        public TwinSheets()
        {
            name = "Twin Sheets";
        }
    }

    class XLTwinSheets : Bedding
    {
        public XLTwinSheets()
        {
            name = "XL Twin Sheets";
        }
    }

    class FullSheets : Bedding
    {
        public FullSheets()
        {
            name = "Full Sheets";
        }
    }

    class QueenSheets : Bedding
    {
        public QueenSheets()
        {
            name = "Queen Sheets";
        }
    }

    class KingSheets : Bedding
    {
        public KingSheets()
        {
            name = "King Sheets";
        }
    }

    class Pillow : Bedding
    {
        public Pillow()
        {
            name = "Pillow";
        }
    }

    class PillowCase : Bedding
    {
        public PillowCase()
        {
            name = "Pillow Case";
        }
    }
}