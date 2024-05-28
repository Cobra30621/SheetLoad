using System;
using System.Collections.Generic;
using Data;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    public class CardLevelHandler : SerializedMonoBehaviour, IDataPersistence
    {
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
        
        public void UpgradeCard(string id)
        {
            bool contain = cardLevels.TryGetValue(id, out var cardLevel);

            Debug.Log($"升級卡牌 {id} 到 {cardLevel + 1}");
            if (contain)
            {
                cardLevels[id]++;
            }
            
            SaveManager.Instance.SaveGame();
        }
        
        public int GetCardLevel(string id)
        {
            return cardLevels.TryGetValue(id, out var cardLevel) ? cardLevel : 0;
        }
        
        
        public void LoadData(GameData data)
        {
            if(data.cardLevels != null)
                cardLevels = data.cardLevels;
            else
            {
                InitDictionary();
            }
        
        }
        
        public void SaveData(GameData data)
        {
            data.cardLevels = cardLevels;
        }
        
        
    }
}