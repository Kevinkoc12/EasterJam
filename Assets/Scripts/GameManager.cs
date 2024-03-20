using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int vidas = 3;
    public int puntos = 0;
    public SpriteRenderer vidasSprite;
    public Sprite[] sprites;
    public static GameManager gameManager;
    public TMP_Text puntosUI;
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        //guarda los puntos en memoria
        Cursor.visible = false;
        PlayerPrefs.SetInt("Puntos", puntos);
        puntosUI.text = puntos.ToString();

    }

    void Update()
    {
        if (puntos < 0)
        {
            puntos = 0;
            PlayerPrefs.SetInt("Puntos", puntos);
        }
        vidasSprite.sprite = sprites[vidas];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Huevo")
        {
            Destroy(collision.gameObject);
            vidas--;
            if (vidas <= 0)
            {
                //cambiar de escenas
                SceneManager.LoadScene("Game Over");
            }
        }
    }

    public void anadirPuntos(int newPoint)
    {
       puntos += newPoint;

        //setear Puntos
        puntosUI.text = puntos.ToString();

        //guarda los puntos en memoria
        PlayerPrefs.SetInt("Puntos", puntos);
    }
    
}
