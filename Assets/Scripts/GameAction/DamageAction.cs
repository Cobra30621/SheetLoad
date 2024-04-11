using Card;
using UnityEngine;

namespace GameAction
{
    public class DamageAction : GameActionBase
    {
        public int damageValue;
        
        public Target Target;
        
        public override void SetEffectInfo(EffectInfo effectInfo)
        {
            damageValue = effectInfo.int1;
        }

        public override void DoAction()
        {
            Debug.Log($"造成 {damageValue} 點傷害");
        }
    }

    public enum Target
    {
        Enemy,
        AllEnemy,
        Self
    }
}