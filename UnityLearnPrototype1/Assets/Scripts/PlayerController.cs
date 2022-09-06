using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward with Vector3 (which stores O, 0, 1)
        // With delta time we know when 1 second has elapsed (we move 1 meter a second)
        // we can control how much time is actually passing by multiplying by another number (ex: * 20)
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
