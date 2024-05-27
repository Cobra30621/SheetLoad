using System.Collections.Generic;
using NueGames.Enums;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    [CreateAssetMenu(fileName = "Card Data", menuName = "Collection/Card", order = 0)]
    public class CardData : SerializedScriptableObject
    {
        [SerializeField] private string cardId;
        [SerializeField] private List<CardLevelInfo> _levelInfos;
        
        
        [FoldoutGroup("卡牌顯示")]
        [SerializeField] private string cardName;
        [FoldoutGroup("卡牌顯示")]
        [SerializeField] private Sprite cardSprite;
        [FoldoutGroup("卡牌顯示")]
        [SerializeField] private RarityType rarity;
        
        public string CardId => cardId;
        public List<CardLevelInfo> LevelInfos => _levelInfos;
        public string CardName => cardName;
        public Sprite CardSprite => cardSprite;
        public RarityType Rarity => rarity;
        

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