using UnityEngine;

namespace Card
{
    /// <summary>
    /// 用來實作卡片在場景中的功能，如 UI 顯示、拖移卡片
    /// 這個不是 CardActionBase
    /// </summary>
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