using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiningState : MonoBehaviour
{

    public Image spriteImage;
    public Sprite[] sprites;


    public static MiningState instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de MiningState dans la scène");
            return;
        }
        instance = this;
    }

    void Update()
    {
        if (Ressource.instance.miningState == 5)
        {
            StartCoroutine(Ressource.instance.Reset());
        }

        if (Ressource.instance.miningState == 4)
        {
            spriteImage.sprite = sprites[4];
        }

        if (Ressource.instance.miningState == 3)
        {
            spriteImage.sprite = sprites[3];
        }

        if (Ressource.instance.miningState == 2)
        {
            spriteImage.sprite = sprites[2];
        }

        if (Ressource.instance.miningState == 1)
        {
            spriteImage.sprite = sprites[1];
        }

        if (Ressource.instance.miningState == 0)
        {
            spriteImage.sprite = sprites[0];
        }

    }

}
