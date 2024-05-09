using GameAction;

namespace Counter
{
    public class CounterManager
    {
        public static int GetCounter(CounterType counterType)
        {
            switch (counterType)
            {
                case CounterType.DamageTimes:
                    return 0;
                case CounterType.DrawTimes:
                    return 0;
            }

            return 0;
        }
    }
}