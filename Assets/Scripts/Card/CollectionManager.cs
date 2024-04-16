using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    public class CollectionManager : SerializedMonoBehaviour
    {
        [InlineEditor]
        public List<CardData> DrawPile;

        
        public CardBase Card;

        [Button("抽卡")]
        public void DrawCard()
        {
            Card = new BattleCard();
            var cardData = DrawPile[Random.Range(0, DrawPile.Count)];
            var cardLevel = CardLevelManager.GetCardLevel(cardData.CardId);

            Card.SetCard(cardData, cardLevel);
        }

    }
}