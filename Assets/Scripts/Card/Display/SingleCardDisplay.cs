﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Card.Display
{
    public class SingleCardDisplay : MonoBehaviour
    {
        [SerializeField] protected Image cardImage;
        [SerializeField] protected Image passiveImage;
        [SerializeField] protected TextMeshProUGUI nameTextField;
        [SerializeField] protected TextMeshProUGUI descTextField;
        [SerializeField] protected TextMeshProUGUI manaTextField;

        public void UpdateUI(CardInfo cardInfo)
        {
            nameTextField.text = cardInfo.CardData.CardName;
            descTextField.text = cardInfo.Description;
            manaTextField.text = cardInfo.ManaCost.ToString();
            cardImage.sprite = cardInfo.CardData.CardSprite;
        }
        
        public void SetPlayable(bool playable)
        {
            passiveImage.gameObject.SetActive(playable);
        }

    }
}