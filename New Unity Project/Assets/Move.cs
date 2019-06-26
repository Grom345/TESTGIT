using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(transform.forward * 0.5f);
    }
}
