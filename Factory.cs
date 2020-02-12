using System;
using System.Collections.Generic;
using System.Text;

namespace Quete4SOLIDOpenClosedPrinciple
{
    public sealed class Factory
    {
        public Production Craft(IEnumerable<Craftable> manyCraftableBlocks)
        {
            Production newProduction = new Production(manyCraftableBlocks);
            return newProduction;
        }
    }
}
