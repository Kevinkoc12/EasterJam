using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int vidas = 3;
    public SpriteRenderer vidasSprite;
    public Sprite[] sprites;

    void Start()
    {
        
    }

    void Update()
    {
        vidasSprite.sprite = sprites[vidas];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Huevo")
        {
            Destroy(collision.gameObject);
            vidas--;
        }
    }

    
    
}
