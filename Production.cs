using System;
using System.Collections.Generic;
using System.Text;

namespace Quete4SOLIDOpenClosedPrinciple
{
    public class Production
    {
        private IEnumerable<Wood> manyWoodBlocks;
        private IEnumerable<Metal> manyMetalBlocks;

        public IEnumerable<Craftable> Materials { get; set; }

        public Production(IEnumerable<Craftable> manyMaterials)
        {
            Materials = manyMaterials;
        }

        public Production(IEnumerable<Wood> manyWoodBlocks)
        {
            this.manyWoodBlocks = manyWoodBlocks;
        }

        public Production(IEnumerable<Metal> manyMetalBlocks)
        {
            this.manyMetalBlocks = manyMetalBlocks;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (Craftable material in Materials)
            {
                description += "\t" + material.Type;
            }
            return description;
        }
    }
}
