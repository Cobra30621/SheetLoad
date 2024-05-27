using UnityEngine;

namespace Card.Display
{
    public class UICard : MonoBehaviour
    {
        [SerializeField] private CardDisplay _cardDisplay;
        private CardInfo _cardInfo;


        public void Init(CardInfo cardInfo)
        {
            _cardInfo = cardInfo;
            _cardDisplay.SetCard(cardInfo);

        }
    }
}