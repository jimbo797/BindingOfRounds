using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;


namespace BindingOfRounds.Cards
{
    class TheWiz : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            //UnityEngine.Debug.Log($"[{BindingOfRounds.ModInitials}][Card] {GetTitle()} has been setup.");
            //gun.numberOfProjectiles = 1;
            //gun.spread = 0.33f; // NOTE: Max usable spread is 0.33
            gun.evenSpread = 1.0f;
            gun.reloadTimeAdd = 0.25f;
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            //UnityEngine.Debug.Log($"[{BindingOfRounds.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");

            gun.numberOfProjectiles *= 2;

            // Ok to use assignment here, since I always want to change the spread
            gun.spread = 0.4f / gun.numberOfProjectiles;
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
            //UnityEngine.Debug.Log($"[{BindingOfRounds.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");

        }


        protected override string GetTitle()
        {
            return "The Wiz";
        }
        protected override string GetDescription()
        {
            return "Double wiz shot!";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bullets shot",
                    amount = "2x",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Max bullet spread",
                    amount = "20%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bullet spread",
                    amount = "Even",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload time",
                    amount = "+0.25s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.TechWhite;
        }
        public override string GetModName()
        {
            return BindingOfRounds.ModInitials;
        }
    }
}
