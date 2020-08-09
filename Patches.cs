using Harmony;
using Klei.AI;
using System;
using System.Diagnostics;

namespace More_Realism_
{
    public class Patches
    {
        public static class Mod_OnLoad
        {
            public static void OnLoad()
            {
                Debug.Log("[More Realism!] You now have More Realism! Congrats, have fun!");
            }
        }

        //[HarmonyPatch(typeof(MinionConfig), "AddMinionTraits")]
        //class Patch
        //{
        //    static void Postfix(string name)
        //    {
        //        Debug.Log("dbg " + name);
        //        var trait = Db.Get().traits.Get(MinionConfig.MINION_BASE_TRAIT_ID);
        //        Debug.Log("dbg " + trait);

        //        var id = Db.Get().Attributes.AirConsumptionRate.Id;
        //        Debug.Log("dbg " + id);

        //        AttributeModifier attr_mod = trait.SelfModifiers.Find(x => x != null && x.AttributeId == id); ; ;
        //        if (attr_mod != null)
        //        {
        //            Debug.Log("dbg " + attr_mod.ToString());
        //            var method = typeof(AttributeModifier).GetProperty("Value").GetSetMethod(true);
        //            Debug.Log("dbg " + method.ToString());
        //            method.Invoke(attr_mod, new object[] { 0.05f });
        //        }
        //    }
        //}

        [HarmonyPatch(typeof(OxygenBreather), "Sim200ms")]
        public class Sim200ms
        {
            public static void Prefix(OxygenBreather __instance, float dt)
            {
                //Debug.Log("Patch o2toco2 " + dt.ToString());
                __instance.O2toCO2conversion = 1;
                __instance.minCO2ToEmit = 0.6f;
            }
        }
    }
}
