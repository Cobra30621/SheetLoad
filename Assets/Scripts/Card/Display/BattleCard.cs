using GameAction;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card.Display
{
    public class BattleCard : MonoBehaviour
    {
        private CardInfo _cardInfo;

        [SerializeField] private CardDisplay _cardDisplay;
        
        
        public void Init(CardInfo cardInfo)
        {
            _cardInfo = cardInfo;
            _cardDisplay.SetCard(cardInfo);
        }
        
        
        [Button("使用卡片")]
        public void Use()
        {
            var effectInfos = _cardInfo.CardLevelInfo.EffectInfos;
            
            foreach (var effectInfo in effectInfos)
            {
                var gameAction = GameActionFactory.GetGameAction(effectInfo);
                gameAction.DoAction();
            }
        }
    }
}