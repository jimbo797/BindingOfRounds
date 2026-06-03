using UnboundLib;
using UnboundLib.Cards;
using BindingOfRounds.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using BepInEx;
using System;
using System.Collections.Generic;
using UnboundLib.GameModes;

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
        public const string Version = "1.2.0"; // What version are we on (major.minor.patch)?
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
            CustomCard.BuildCard<BucketOfLard>();
            CustomCard.BuildCard<DeadCat>();
            CustomCard.BuildCard<Fate>();
            CustomCard.BuildCard<MagicMushroom>();
            CustomCard.BuildCard<MiniMush>();
            CustomCard.BuildCard<NumberOne>();
            CustomCard.BuildCard<Polyphemus>();
            CustomCard.BuildCard<SadOnion>();
            CustomCard.BuildCard<ThePact>();
            CustomCard.BuildCard<TheWiz>();

            //WIP - need to figure out how to attach monobehaviors
            //CustomCard.BuildCard<CSection>();
            //CustomCard.BuildCard<SacredHeart>();
            //CustomCard.BuildCard<JacobsLadder>();
            //CustomCard.BuildCard<TheVirus>();
            //CustomCard.BuildCard<BobsBrain>();
            //CustomCard.BuildCard<HaloOfFlies>();

            //WIP - need to patch RoundsWithFriends to allow point and card-choosing modifications
            //CustomCard.BuildCard<Birthright>();
            //CustomCard.BuildCard<RKey>();
        }
    }

}
