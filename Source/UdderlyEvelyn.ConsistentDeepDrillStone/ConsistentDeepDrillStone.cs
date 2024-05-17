using System.Reflection;
using HarmonyLib;
using Verse;

namespace UdderlyEvelyn.ConsistentDeepDrillStone;

[StaticConstructorOnStartup]
public static class ConsistentDeepDrillStone
{
    static ConsistentDeepDrillStone()
    {
        new Harmony("UdderlyEvelyn.ConsistentDeepDrillStone").PatchAll(Assembly.GetExecutingAssembly());
    }
}