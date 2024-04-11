using Card;

namespace GameAction
{
    public abstract class GameActionBase
    {
        public abstract void SetEffectInfo(EffectInfo effectInfo);

        public abstract void DoAction();
    }
}