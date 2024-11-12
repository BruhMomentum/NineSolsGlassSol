using System;
using System.Collections;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using NineSolsNohit.Patches;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using I2.Loc;
using TMPro;

namespace NineSolsNohit
{
    [BepInPlugin("flyingRozenbaum.NineSolsNohit", "NineSolsNohit", "0.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "flyingRozenbaum.NineSolsNohit";
        private const string modName = "NineSolsNohit";
        private const string modVersion = "0.1.0";
        public static Plugin instance;
        internal ManualLogSource mls;
        public class Result<T> where T : class
        {
            public T value;
        }
        private void Awake()
        {
            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("СТАРТУЕМ");
            instance = this;

            Harmony.CreateAndPatchAll(typeof(PlayerHealthPatch));

            mls.LogInfo("СТАРТАНУЛИ");
        }
    }
}
