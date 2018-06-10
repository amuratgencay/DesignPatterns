using System;
using System.Collections.Generic;
using DesignPattern.Entity.StructuralPatterns.AdapterPattern;

namespace DesignPattern.BLL.StructuralPatterns.AdapterPattern
{
    public class ChemicalDatabank
    {
        public static readonly Dictionary<string, RichCompound> MapRichCompounds = new Dictionary<string, RichCompound>()
        {
            { CompoundType.Water.ToString(),new RichCompound(CompoundType.Water.ToString(), 100.0f, 0.0f, 18.015, "H20")},
            { CompoundType.Benzene.ToString(), new RichCompound(CompoundType.Benzene.ToString(), 80.1f, 5.5f, 78.1134, "C6H6") },
            { CompoundType.Ethanol.ToString(), new RichCompound(CompoundType.Ethanol.ToString(), 78.3f, -114.1f, 46.0688, "C2H5OH")}
        };
    }
}
