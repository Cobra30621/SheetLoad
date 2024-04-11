using Card;

namespace GameAction
{
    public class GameActionFactory
    {
        public static void DoGameAction(EffectInfo effectInfo)
        {
            GameActionBase action = new DamageAction();
            switch (effectInfo.ActionType)
            {
                case GameActionType.ApplyPower:
                    action = new ApplyPowerAction();
                    break;
                case GameActionType.Damage:
                    action = new DamageAction();
                    break;
            }
            
            action.SetEffectInfo(effectInfo);
            action.DoAction();
        }
    }
}