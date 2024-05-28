using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Card
{
    [Serializable]
    public class CardInfo
    {
        [ShowInInspector]
        public CardData CardData { get; private set; }
        [ShowInInspector]
        public int Level { get; private set; }

        public CardLevelInfo CardLevelInfo => cardLevelInfo;

        public string Description => CardLevelInfo.Description;

        public int ManaCost => CardLevelInfo.Mana;

        [SerializeField] private CardLevelInfo cardLevelInfo;

        public CardInfo(CardData cardData, int level)
        {
            CardData = cardData;
            Level = level;
            cardLevelInfo = cardData.GetLevelInfo(level);
        }
    }
}