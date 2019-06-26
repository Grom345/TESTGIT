using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * 0.5f);
    }
}
