using _3_Script.UI.TitleScreenMenuUI;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineSolsNohit.Patches
{
    internal class PlayerHealthPatch
    {
        [HarmonyPrefix, HarmonyPatch(typeof(PlayerHealth), "ReceiveDamage")]
        public static void ReceiveDamagePreFix(ref PlayerHealth __instance)
        {
            if (__instance.IsInvincible == false)
            {
                __instance.Die();
            }
        }

        [HarmonyPostfix, HarmonyPatch(typeof(PlayerHealth), "ReceiveDamage")]
        public static void ReceiveDamagePostFix(ref PlayerHealth __instance)
        {
            if (__instance.IsInvincible == false)
            {
                __instance.Die();
            }
        }

        [HarmonyPrefix, HarmonyPatch(typeof(PlayerHealth), "ReceiveDOT_Damage")]
        public static void ReceiveDOT_DamagePostFix(ref PlayerHealth __instance)
        {
            //__instance.currentValue = -1.0f;
            if (__instance.IsInvincible == false)
            {
                __instance.Die();
            }
        }

        [HarmonyPrefix, HarmonyPatch(typeof(PlayerHealth), "ReceiveRecoverableDamage")]
        public static void ReceiveRecoverableDamagePostFix(ref PlayerHealth __instance)
        {
            //if (__instance.currentValue - __instance.CurrentInternalInjury < 0f)
            //{
            //    __instance.currentValue = - -1 * __instance.CurrentInternalInjury;
            //}
            //else
            //{
                __instance.currentValue = 1f;
            //}
        }
    }
}
