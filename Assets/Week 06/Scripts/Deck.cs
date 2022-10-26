// Created by Owen
// Adapted by Aaron & GAD170 class

using System.Collections.Generic;
using System;
using UnityEngine;

namespace GAD170
{
    enum CardSuit { Clubs, Spades, Hearts, Diamonds }

    public class Deck : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Card cardPrefab;

        [Header("Collections")]
        [SerializeField] private List<Card> deck;
        private string[] values = new string[13] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        void Start()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (string value in values)
                {
                    Card _newCard = Instantiate(cardPrefab, transform);

                    _newCard.value = value;
                    _newCard.suit = suit.ToString();
                    _newCard.name = value + " of " + suit;

                    deck.Add(_newCard);
                }
            }
        }
    }
}
