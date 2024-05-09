using Card;
using Power;
using UnityEngine;

namespace GameAction
{
    public class ApplyPowerAction : GameActionBase
    {
        public PowerType applyPower;
        public int amount;
        public override void SetEffectInfo(SkillInfo skillInfo)
        {
            amount = skillInfo.int1;
            applyPower = (PowerType)skillInfo.int2;
        }

        public override void DoAction()
        {
            Debug.Log($"上狀態 {applyPower}, {amount}");
        }

    }
}