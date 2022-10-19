using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace AaronGoss
{
    public enum Avenger { Undefined, IronMan, TheHulk, CaptainMarvel }

    public class Contact : MonoBehaviour
    {
        [SerializeField] private Avenger chosenAvenger = Avenger.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string preferredName;
        [SerializeField] private string pronouns;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialise()
        {
            // We want to set up all 3 characters here
            // Using an if statement, we can say:
            // use if statements
            // if variable == 0, set up iron man
            // if variable == 1, set up the hulk
            // if variable == 2, set up captain marvel
            // if statement
            // switch statement
            //SetupIronMan();
            //SetupTheHulk();
            //SetupCaptainMarvel();

            switch (chosenAvenger)
            {
                case Avenger.Undefined:
                    Debug.Log("Superhero undefined. Set its enum in the inspector!");
                    break;
                case Avenger.IronMan:
                    Setup("Tony", "Stark", "Iron Man", "He/Him", "1800 IRONMAN", "Revealed in Iron Man 2", "ironman@avengers.com");
                    break;
                case Avenger.TheHulk:
                    Setup("Bruce", "Banner", "The Hulk", "He/Him", "HULKSMASH", "HERE", "no");
                    break;
                case Avenger.CaptainMarvel:
                    Setup("Carol", "Denvers", "Captain Marvel", "Captain", "0492101193", "America", "carol@aol.com");
                    break;
                default:
                    Debug.Log("Invalid choice!");
                    break;
            }
        }

        private void Setup(string newFirstName,
                           string newLastName,
                           string newPreferredName,
                           string newPronouns,
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail)
        {
            firstName = newFirstName;
            lastName = newLastName;
            preferredName = newPreferredName;
            pronouns = newPronouns;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
        }

        private void SetupIronMan()
        {
            firstName = "Iron Man";
            lastName = "Stark";
            preferredName = "Iron Man";
            pronouns = "He/Him";
            phoneNumber = "1800 153 678";
            address = "Revealed in Iron Man 2";
            email = "ironman@secret.com";
        }

        private void SetupTheHulk()
        {
            firstName = "Iron Man";
            lastName = "Stark";
            preferredName = "Iron Man";
            pronouns = "He/Him";
            phoneNumber = "1800 153 678";
            address = "Revealed in Iron Man 2";
            email = "ironman@secret.com";
        }

        private void SetupCaptainMarvel()
        {
            firstName = "Iron Man";
            lastName = "Stark";
            preferredName = "Iron Man";
            pronouns = "He/Him";
            phoneNumber = "1800 153 678";
            address = "Revealed in Iron Man 2";
            email = "ironman@secret.com";
        }
    }
}
