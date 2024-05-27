using System.Collections.Generic;
using Card.Display;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    public class CardListDisplay : MonoBehaviour
    {
        [SerializeField] private GameObject mainPanel;
        [SerializeField] private DeckData _deckData;
        [SerializeField] private UICard prefab;
        
        
        [SerializeField] private List<UICard> _spawnedCardList = new List<UICard>();
        [SerializeField] private Transform spawnPos;

        [Button]
        public void Open()
        {
            mainPanel.SetActive(true);
            SetCardUI();
        }
        
        private void SetCardUI()
        {
            DestroyPreviousUI();

            var cardInfos = CardManager.Instance.GetAllCardInfos();

            foreach (var cardInfo in cardInfos)
            {
                var card = Instantiate(prefab, spawnPos);
                _spawnedCardList.Add(card);
                card.Init(cardInfo);
            }
        }
        
        
        /// <summary>
        /// Destroys the previously created UI elements.
        /// </summary>
        private void DestroyPreviousUI()
        {
            foreach (var cardBase in _spawnedCardList)
            {
                Destroy(cardBase.gameObject);
            }

            _spawnedCardList.Clear();
        }

            
            
    }
}