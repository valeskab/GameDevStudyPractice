using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other) //If youre doing 2D you need to use OnTriggerEnter2D
    {
        triggerEnterEvent.Invoke();
    }
}



//Character controller moves around collides and trigger without physics