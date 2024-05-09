using Card;
using UnityEngine;

namespace GameAction
{
    public class MultiDamageAction : GameActionBase
    {
        public int damageValue;
        public int damageStack;
        
        public Target Target;
        
        public override void SetEffectInfo(SkillInfo skillInfo)
        {
            damageValue = skillInfo.int1;
            damageStack = skillInfo.int2;
        }

        public override void DoAction()
        {
            Debug.Log($"造成 {damageValue} 點傷害{damageStack}次");
        }
    }
}