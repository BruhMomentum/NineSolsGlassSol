using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineSolsNohit
{
    public class GameConfigPatch
    {
        [HarmonyPatch(nameof(GameConfig.PlayerDefenseDamageGlobalRatio))]
        [HarmonyPostfix]
        public static void PlayerDefenseDamageGlobalRatio(ref float ___damage)
        {
            ___damage = 100000f;
        }
    }
}
