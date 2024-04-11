using Card;

namespace GameAction
{
    public class SuperDamage : GameActionBase
    {
        public float amount;
        public CounterType counterType;
        
        public override void SetEffectInfo(EffectInfo effectInfo)
        {
            throw new System.NotImplementedException();
        }

        public override void DoAction()
        {
            int counter = CounterManager.GetCounter(counterType);
        }
    }


    public enum CounterType
    {
        DamageTimes,
        DrawTimes
    }
}