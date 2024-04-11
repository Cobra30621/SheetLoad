using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    [CreateAssetMenu(fileName = "Card Data", menuName = "Collection/Card", order = 0)]
    public class CardData : SerializedScriptableObject
    {
        [SerializeField] private string cardId;

        [FoldoutGroup("卡片行為")]
        [DetailedInfoBox("如何創建新的卡片行為(CardAction)...",
            "如何創建新的卡片行為(CardAction)\n" +
            "請去 Assets/Scripts/CardAction 資料夾中，創建新的 cs 檔。\n" +
            "技術文件放在 Assets/Scripts/CardAction/CardActionBase.cs 的開頭註解")]
        
        [SerializeField] private List<CardLevelInfo> cardLevels;


        public string CardId => cardId;
        public List<CardLevelInfo> CardLevels => cardLevels;

        public void SetCardLevels(List<CardLevelInfo> cardLevelInfos)
        {
            cardLevels = cardLevelInfos;
        }
    }
}