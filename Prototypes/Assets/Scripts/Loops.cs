using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public int balloonsmax = 3;

        public int countdown = 10;

        public int cookieMax = 4;

        public int patrolRange = 10;

        public int powerlevel = 100;

        public int enemies = 100;

        public int gold = 100;

        public int dogs = 2;

        public int cats = 3;
        
        public int candymin = 10;


        void Start()
        {
            for (int i = 0; i < balloonsmax; i++)
            {
                Debug.Log("Current Balloon Count: " + i);
            }
            for (int c = 0; c < countdown; c--)
            {
                Debug.Log("T minus " + c);
            }
            while (powerlevel > 30)
            {
                Debug.Log("Current battery: " + powerlevel);
                powerlevel - 10;
            }
            for (int z = 0; z < enemies; z++)
            {
                Debug.Log("The zombies grow in number. Current population " + z);
            }
            for (int m = 0; m < cats; m++)
            {
                Debug.Log("Current cats: " + m);
            }
        }

    // Update is called once per frame
    void Update()
    {
            while (cookieMax > 0)
            {
                Debug.Log("I've found a cookie!");
                cookieMax--;
            }
            for (int g = 0; g < gold; g--)
            {
                Debug.Log("Thanks for donating! I now have " + g + " gold in funding.");
            }
            while (patrolRange > 3)
            {
                Debug.Log("Scanning...");
                patrolRange--;
            }
            while (dogs > 10)
            {
                Debug.Log("We got a puppy!");
                dogs++;
            }
            while (candymin > 1)
            {
                Debug.Log("Yum! Candy!");
                candymin--;
            }
        }
