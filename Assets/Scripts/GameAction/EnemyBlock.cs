using Card;
using Counter;
using Power;
using UnityEngine;

namespace GameAction
{
    public class EnemyBlock : GameActionBase
    {
        public int Block;
        
        
        
        public override void SetEffectInfo(SkillInfo skillInfo)
        {
            Block = skillInfo.int1;
            PowerType powerType;
        }

        public override void DoAction()
        {
            int EnemyCount = CounterManager.GetCounter(CounterType.EnemyCount);
            Debug.Log($"獲得 {Block} 點護盾{EnemyCount}次");
        }
    }
}