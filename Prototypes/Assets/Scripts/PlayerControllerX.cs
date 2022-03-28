using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float hInput;
    public float fInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * hInput);
    }
}
