using Card;

namespace GameAction
{
    public abstract class GameActionBase
    {
        public Target Target;
        public abstract void SetEffectInfo(SkillInfo skillInfo);

        public abstract void DoAction();
    }
}