using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    abstract class BeddingSelector
    {
        protected List<Bedding> beddingNeeded = new List<Bedding>();

        public BeddingSelector()
        {
            this.SelectBedding();
        }

        public List<Bedding> GetBedding()
        {
            return beddingNeeded;
        }

        public abstract void SelectBedding();
    }

    class TwinBeddingSelctor : BeddingSelector
    {
        public override void SelectBedding()
        {
            beddingNeeded.Add(new Blanket());
            beddingNeeded.Add(new TwinSheets());
            beddingNeeded.Add(new Pillow());
            beddingNeeded.Add(new PillowCase());
        }
    }

    class XLTwinBeddingSelctor : BeddingSelector
    {
        public override void SelectBedding()
        {
            beddingNeeded.Add(new Blanket());
            beddingNeeded.Add(new XLTwinSheets());
            beddingNeeded.Add(new Pillow());
            beddingNeeded.Add(new PillowCase());
        }
    }

    class FullBeddingSelctor : BeddingSelector
    {
        public override void SelectBedding()
        {
            beddingNeeded.Add(new LBlanket());
            beddingNeeded.Add(new FullSheets());
            beddingNeeded.Add(new Pillow());
            beddingNeeded.Add(new PillowCase());
        }
    }

    class QueenBeddingSelctor : BeddingSelector
    {
        public override void SelectBedding()
        {
            beddingNeeded.Add(new LBlanket());
            beddingNeeded.Add(new QueenSheets());
            beddingNeeded.Add(new Pillow());
            beddingNeeded.Add(new PillowCase());
            beddingNeeded.Add(new Pillow());
            beddingNeeded.Add(new PillowCase());
        }
    }

    class KingBeddingSelctor : BeddingSelector
    {
        public override void SelectBedding()
        {
            beddingNeeded.Add(new LBlanket());
            beddingNeeded.Add(new KingSheets());
            beddingNeeded.Add(new Pillow());
            beddingNeeded.Add(new PillowCase());
            beddingNeeded.Add(new Pillow());
            beddingNeeded.Add(new PillowCase());
        }
    }
}