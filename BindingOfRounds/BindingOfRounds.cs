using UnboundLib;
using UnboundLib.Cards;
using BindingOfRounds.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using BepInEx;

namespace BindingOfRounds
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class BindingOfRounds : BaseUnityPlugin
    {
        private const string ModId = "com.jimbo797.rounds.BindingOfRounds";
        private const string ModName = "BindingOfRounds";
        public const string Version = "1.0.2"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "BOR";

        public static BindingOfRounds instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;

            CustomCard.BuildCard<Brimstone>();
            CustomCard.BuildCard<MagicMushroom>();
            CustomCard.BuildCard<MiniMush>();
        }
    }

}
