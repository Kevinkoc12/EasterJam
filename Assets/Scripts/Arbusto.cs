using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbusto : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Huevo")
        {        
        collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;

        }
    }
}
