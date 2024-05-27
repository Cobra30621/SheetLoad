using System.Collections.Generic;
using Card.Display;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    public class BattleCardDisplayTest : MonoBehaviour
    {
        [SerializeField] private BattleCard prefab;
        
        
        [SerializeField] private List<BattleCard> spawnedCardList = new List<BattleCard>();
        [SerializeField] private Transform spawnPos;

        [Button]
        public void Open()
        {
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