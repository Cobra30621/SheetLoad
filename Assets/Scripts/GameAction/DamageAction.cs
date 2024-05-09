using Card;
using Power;
using UnityEngine;

namespace GameAction
{
    public class DamageAction : GameActionBase
    {
        public int damageValue;
        
        
        
        public override void SetEffectInfo(SkillInfo skillInfo)
        {
            damageValue = skillInfo.int1;
            PowerType powerType;
        }

        public override void DoAction()
        {
            Debug.Log($"造成 {damageValue} 點傷害");
        }
    }
}