using CMS;
using HarmonyLib;
using RimWorld;
using Verse;

namespace UdderlyEvelyn.ConsistentDeepDrillStone;

[HarmonyPatch(typeof(DeepDrillUtility), nameof(DeepDrillUtility.GetBaseResource))]
internal class HarmonyPatches
{
    private static bool Prefix(Map map, IntVec3 cell, ref ThingDef __result)
    {
        if (!map.Biome.hasBedrock)
        {
            __result = null;
            return false;
        }

        Rand.PushState();
        Rand.Seed = cell.GetHashCode();
        __result = map.GetComponent<MapComponent_StoneGrid>().StoneChunkAt(cell);
        Rand.PopState();
        return false;
    }
}