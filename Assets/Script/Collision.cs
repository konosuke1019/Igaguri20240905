using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    igaguriGenerator generator;
    // Start is called before the first frame update
    private void OnCollisionEnter()
    {
        generator = FindObjectOfType<igaguriGenerator>();
    }
}
