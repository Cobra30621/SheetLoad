using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

namespace Card
{
    public class CardEditorTool : MonoBehaviour
    {
        public DeckData SaveDeck;
        public CardLevelData cardLevelData;
        public EffectData EffectData;

        [Button("讀取卡牌資料")]
        public void LoadCardData()
        {
            var cardLevelInfos = cardLevelData.GetAllCardInfo();
            foreach (var card in SaveDeck.CardList)
            {
                var levelInfos = GetLevelInfo(cardLevelInfos, card.CardId);
                
                foreach (var levelInfo in levelInfos)
                {
                    var effectId = ConvertStringToList(levelInfo.EffectID);
                    var effectInfos = GetEffectInfo(effectId);
                    levelInfo.SetEffect(effectInfos);
                }
                    
                card.SetCardLevels(levelInfos);
            }
            
            AssetDatabase.SaveAssets();
        }

        private static List<CardLevelInfo> GetLevelInfo(List<CardLevelInfo> cardLevelInfos, string cardId)
        {
            return cardLevelInfos.
                Where(x => x.GroupID == cardId).ToList();
        }

        private List<EffectInfo> GetEffectInfo(List<int> effectId)
        {
            return EffectData.GetAllCardInfo().Where(x =>  effectId.Contains(x.EffectID)).ToList();
        }
        
        static List<int> ConvertStringToList(string input)
        {
            List<int> numbers = new List<int>();

            string[] parts = input.Split(',');

            foreach (string part in parts)
            {
                if (int.TryParse(part.Trim(), out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Debug.Log($"Invalid input: {part}");
                }
            }

            return numbers;
        }
    }
}