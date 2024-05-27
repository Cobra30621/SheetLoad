using System;

namespace Card
{
    [Serializable]
    public class CardInfo
    {
        public CardData CardData { get; private set; }

        public int Level { get; private set; }

        public CardLevelInfo CardLevelInfo { get; private set; }

        public string Description => CardLevelInfo.Description;

        public int ManaCost => CardLevelInfo.Mana;

        public CardInfo(CardData cardData, int level)
        {
            CardData = cardData;
            Level = level;
            CardLevelInfo = cardData.GetLevelInfo(level);
        }
    }
}