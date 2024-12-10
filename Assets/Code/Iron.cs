using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class Iron : MonoBehaviour
{
    public int oreCount = 5;
    public int baseHp = 12;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    public static Iron instance;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance d'Iron dans la scène");
            return;
        }
        instance = this;
    }


    void Update()
    {
        if (12 >= baseHp & baseHp > 9)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (9 >= baseHp & baseHp > 6)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (6 >= baseHp & baseHp > 3)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (3 >= baseHp & baseHp > 0)
        {
            spriteRenderer.sprite = sprites[3];
        }
        else if(baseHp <= 0)
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        spriteRenderer.enabled = false;
        if (oreCount >= 1)
        {
            baseHp = 12;
            yield return new WaitForSeconds(1.5f);
            spriteRenderer.enabled = true;
            oreCount--;
            IronNuggets.instance.nuggetsCount++;
        }

    }
}
