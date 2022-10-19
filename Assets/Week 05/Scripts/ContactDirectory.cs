using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<Contact> contactsList = new List<Contact>();

        private void Start()
        {
            // Let's loop through our collection.
            // Create integer call i and give it value of 0
            // if i < Count, then do the things inside this loop
            // then, increase i by 1... making i = 1... then i = 2... then i = 3...

            for(int i = 0; i < contactsList.Count; i++)
            {
                contactsList[i].Initialise();
            }

            foreach(Contact chosenContact in contactsList)
            {
                chosenContact.Initialise();
            }
        }

        //[SerializeField] private string[] carsArray = { "Volvo", "BMW", "Ford", "Mazda" };
        //[SerializeField] private List<string> carsList = new List<string>();

        //private void Start()
        //{
        //    carsArray = new string[] { "Toyota", "Toyota", "Toyota", "Toyota", "Toyota" };
        //    carsArray = new string[] { "Hyundai", "Hyundai", "Hyundai", "Hyundai", "Hyundai", "Hyundai" };
        //    // print out all cars...

        //    carsList.Add("Toyota");
        //    carsList.Add("Volvo");
        //    carsList.Remove("Toyota");
        //    // print all cars...
        //}
    }
}
