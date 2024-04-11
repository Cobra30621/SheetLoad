using Card;
using UnityEngine;

namespace GameAction
{
    public class ApplyPowerAction : GameActionBase
    {
        public PowerType applyPower;
        public int amount;
        public override void SetEffectInfo(EffectInfo effectInfo)
        {
            amount = effectInfo.int1;
            applyPower = (PowerType)effectInfo.int2;
        }

        public override void DoAction()
        {
            Debug.Log($"上狀態 {applyPower}, {amount}");
        }

    }
}