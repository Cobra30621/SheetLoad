using Card;
using UnityEngine;

namespace GameAction
{
    public static class GameActionFactory
    {
        public static GameActionBase GetGameAction(SkillInfo skillInfo)
        {
            GameActionBase action = new DamageAction();
            switch (skillInfo.ActionType)
            {
                case GameActionType.ApplyPower:
                    action = new ApplyPowerAction();
                    break;
                case GameActionType.Damage:
                    action = new DamageAction();
                    break;
                case GameActionType.MultiDamage:
                    action = new MultiDamageAction();
                    break;
                default:
                    Debug.LogError("无效的技能类型");
                    break;
            }

            action.SetEffectInfo(skillInfo);
            return action;
        }
        
       
    }
}