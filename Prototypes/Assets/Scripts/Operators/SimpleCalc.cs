using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{

    public int numberA = 30;
    public int numberB = 5;
    public int numberC = 7;
    public float numberD = 15.0f;
    public float numberE = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        Add();
        Sub();
        Multiply();
        Divide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Add()
    {
        int total;

        total = numberA + numberB;

        Debug.Log("Added numbers A and B to a total of " + total);
    }
    void Sub()
    {
        int total;

        total = numberA - numberC;

        Debug.Log("Subtracted numbers A and C to a total of " + total);
    }
    void Multiply()
    {
        int total;

        total = numberB * numberB;

        Debug.Log("Multiplied numbers B by itself to a total of " + total);
    }
    void Divide()
    {
        int total;
        int rem;
        float tot;

        total = numberA / numberB;
        rem = numberA % numberC;
        tot = numberD / numberE;

        Debug.Log("Divided numbers A by B to a total of " + total);
        Debug.Log("The remainder is " + rem);
        Debug.Log("Divided numbers D by E to a total of " + total);

    }
}
