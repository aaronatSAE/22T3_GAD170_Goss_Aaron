using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AaronGoss
{
    public class WeekTwoActivities : MonoBehaviour
    {
        private string favouriteGame = "World of Warcraft";
        private int hoursPlayed = 3200;
        private float costOfGame = 800f;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My favourite game is " + favouriteGame + "!");
        }
    }
}
