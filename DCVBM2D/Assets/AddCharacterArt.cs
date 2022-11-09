using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCharacterArt : MonoBehaviour
{

    public GameObject art;
    void Start()
    {
        Instantiate(art, transform);
    }
}
