using UnityEngine;

namespace Card
{
    public abstract class CardBase
    {
        [SerializeField] protected CardData CardData;
        protected int Level;
        
        public virtual void SetCard(CardData cardData, int level
            , bool isPlayable = true)
        {
            CardData = cardData;

            Level = level;
        }
    }
}