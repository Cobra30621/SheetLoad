using System.Collections.Generic;
using System.Linq;
using Manager;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    public class CardManager : Singleton<CardManager>
    {
        [Required]
        [SerializeField] private DeckData saveDeck;
        [Required]
        [SerializeField] private CardLevelManager _cardLevelManager;


        public List<CardInfo> GetAllCardInfos()
        {
            var cardInfos = saveDeck.CardList.Select(CreateCardInfo).ToList();

            return cardInfos;
        }
        
        
        public CardInfo CreateCardInfo(CardData cardData)
        {
            var level = _cardLevelManager.GetCardLevel(cardData.CardId);

            var cardInfo = new CardInfo(cardData, level);

            return cardInfo;
        }       

    }
}