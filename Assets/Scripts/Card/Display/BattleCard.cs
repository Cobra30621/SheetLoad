using GameAction;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card.Display
{
    public class BattleCard : CardBase
    {
        
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