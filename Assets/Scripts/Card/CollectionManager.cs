using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    public class CollectionManager : SerializedMonoBehaviour
    {
        [InlineEditor]
        public List<CardData> DrawPile;

        [SerializeField] private DeckData saveDeck;
        [SerializeField] private CardLevelManager _cardLevelManager;
        
   
    }
}