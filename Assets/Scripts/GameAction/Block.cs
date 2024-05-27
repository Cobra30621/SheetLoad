using Card;
using Power;
using UnityEngine;
namespace GameAction
{
    public class Block : GameActionBase
    {
        public int block;
        
        
        public override void SetEffectInfo(SkillInfo skillInfo)
        {
            block = skillInfo.int1;
            PowerType powerType;
        }

        public override void DoAction()
        {
            Debug.Log($"獲得 {block} 點護盾");
        }
    }
}