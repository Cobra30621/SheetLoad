using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    [CreateAssetMenu(fileName = "Card Data", menuName = "Collection/Card", order = 0)]
    public class CardData : SerializedScriptableObject
    {
        [SerializeField] private string cardId;
        [SerializeField] private List<CardLevelInfo> _levelInfos;
        
        public string CardId => cardId;
        public List<CardLevelInfo> LevelInfos => _levelInfos;


        public CardLevelInfo GetLevelInfo(int level)
        {
            return LevelInfos[level];
        }
        
        public void SetCardLevels(List<CardLevelInfo> levelInfos)
        {
            _levelInfos = levelInfos;
        }
    }
}