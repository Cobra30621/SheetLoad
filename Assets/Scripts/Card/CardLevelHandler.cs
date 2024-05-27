using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    public class CardLevelHandler 
    {
        // TEST
        [SerializeField] public String cardName;
        [SerializeField] public int level;
        // TEST
        public Dictionary<string, int> cardLevels;
        public DeckData SaveCard;
        [Button("初始化字典")]
        public void InitDictionary()
        {
            cardLevels = new Dictionary<string, int>();
            foreach (var cardData in SaveCard.CardList)
            {
                var cardId = cardData.CardId;
                cardLevels[cardId] = 0;
            }
        }
        
        // TEST
        [Button("AddCardLevel")]
        public void AddCardLevel()
        {
            cardLevels[cardName] = level;
        }
        
        public int GetCardLevel(string id)
        {
            return cardLevels.TryGetValue(id, out var cardLevel) ? cardLevel : 0;
        }
        // public void LoadData(GameData data)
        // {
        //     cardLevels = data.cardLevels;
        //
        // }
        //
        // public void SaveData(GameData data)
        // {
        //     data.cardLevels = cardLevels;
        // }
        //
        
    }
}