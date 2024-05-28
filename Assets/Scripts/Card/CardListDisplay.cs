using System.Collections.Generic;
using Card.Display;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Card
{
    public class CardListDisplay : MonoBehaviour
    {
        [SerializeField] private GameObject mainPanel;
        [SerializeField] private CardBase prefab;
        
        
        [SerializeField] private List<CardBase> spawnedCardList = new List<CardBase>();
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
                spawnedCardList.Add(card);
                card.Init(cardInfo);
            }
        }
        
        
        /// <summary>
        /// Destroys the previously created UI elements.
        /// </summary>
        private void DestroyPreviousUI()
        {
            foreach (var cardBase in spawnedCardList)
            {
                Destroy(cardBase.gameObject);
            }

            spawnedCardList.Clear();
        }

            
            
    }
}