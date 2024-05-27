using Card;
using Power;
using UnityEngine;
namespace GameAction
{
    public class GainMana : GameActionBase
    {
        public int mana;
        
        
        public override void SetEffectInfo(SkillInfo skillInfo)
        {
            mana = skillInfo.int1;
            PowerType powerType;
        }

        public override void DoAction()
        {
            Debug.Log($"獲得 {mana} 點魔力");
        }
    }
}