using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Ben", "David", "Hunter", "Hannah", "Ash", "Ian"};
    public string[] dogBreeds = {"Golden Retriever", "Labrador", "German Shepherd", "Poodle", "Chihuahua", "Maltese"};
    public string[] flavors = {"Vanilla", "Chocolate", "Strawberry", "Rocky Road", "Cookie Dough", "Peppermint"};
    public string[] location = {"Mountains", "Beach", "Forest", "City", "Space", "Ocean", "Plains"};
    public string[] gemstone = {"Garnet", "Amethyst", "Aquamarine", "Diamond", "Emerald", "Alexandrite", "Ruby", "Peridot", "Sapphire", "Tourmaline", "Topaz", "Blue Topaz"};
    public int[] mph = {5, 7, 10, 15, 20, 25};
    public int[] icPrice = {2, 2, 3, 4 , 5, 6,};
    public int[] temp = {68, 72, 75, 81, 86, 92};
    public int[] psi = {10, 25, 50, 125, 150, 300};
    public float[] candyPrice = {0.99f, 1.25f, 2.50f, 3.00f, 4.25f, 5.00f};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Former friend = " + friendNames[0]);
        Debug.Log(friendNames[2] + " greets us as we walk by.");
        friendNames[0] = "Mary";
        Debug.Log("New friend = " + friendNames[0]);
        
        Debug.Log(friendNames[4] + "'s favorite dogs are " + dogBreeds[5]);
        Debug.Log(friendNames[1] + " has never been to " + location[3]);
        Debug.Log(friendNames[0] + "'s RC car can go" + mph[4] + "miles per hour.");
        Debug.Log(friendNames[5] + "'s birthstone is a/an " + gemstone[10]);
        
        foreach(string flavors in flavors)
        {
            print (flavors);
        } 
        foreach(int icPrice in icPrice)
        {
            print (icPrice);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
