using Card;

namespace GameAction
{
    public abstract class GameActionBase
    {
        public abstract void SetEffectInfo(SkillInfo skillInfo);

        public abstract void DoAction();
    }
}