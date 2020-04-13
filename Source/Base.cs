using System.Linq;
using Verse;

namespace TrapsGoWet
{
    [StaticConstructorOnStartup]
    public static class Splash
    {
        static Splash()
        {
            TerrainAffordanceDef waterproof = DefDatabase<TerrainAffordanceDef>.GetNamed("Waterproof");
            foreach (TerrainDef t in DefDatabase<TerrainDef>.AllDefs)
            {
                t.affordances.Add(waterproof);
            }
            foreach (ThingDef t in DefDatabase<ThingDef>.AllDefs.Where(x => x.defName.Contains("Trap")))
            {
                t.terrainAffordanceNeeded = waterproof;
            }
        }
    }
}
