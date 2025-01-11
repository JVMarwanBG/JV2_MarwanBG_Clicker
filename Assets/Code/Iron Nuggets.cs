using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronNuggets : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public static IronNuggets instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance d'IronNuggets dans la scène");
            return;
        }
        instance = this;
        spriteRenderer.enabled = false;
    }

}
