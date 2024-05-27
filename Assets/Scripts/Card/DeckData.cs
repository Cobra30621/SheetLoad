using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Card
{
    [CreateAssetMenu(fileName = "Deck Data", menuName = "Collection/Deck", order = 1)]
    public class DeckData : ScriptableObject
    {
        [SerializeField] private string deckId;
        [SerializeField] private string deckName;
        
        [InlineEditor]
        [SerializeField] private List<CardData> cardList;
        public List<CardData> CardList => cardList;
        
        
        public string DeckId => deckId;

        public string DeckName => deckName;
    }
}