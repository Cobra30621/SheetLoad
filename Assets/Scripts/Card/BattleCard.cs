using GameAction;
using Sirenix.OdinInspector;

namespace Card
{
    public class BattleCard : CardBase
    {
        [Button("使用卡片")]
        public void Use()
        {
            var cardLevelInfo = CardData.GetLevelInfo(Level);

            foreach (var effectInfo in cardLevelInfo.EffectInfos)
            {
                var gameAction = GameActionFactory.GetGameAction(effectInfo);
                gameAction.DoAction();
            }
        }
    }
}