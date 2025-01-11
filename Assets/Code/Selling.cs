using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selling : MonoBehaviour
{
    public int moneyValue;


    public static Selling instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Selling dans la scène");
            return;
        }
        instance = this;
    }
    public void Sell()
    {
        if (Ressource.instance.ironIng >= 1)
        {
            Ressource.instance.moneyAmount += moneyValue * Ressource.instance.ironIng;
            Ressource.instance.ironIng = 0;
        }
    }
}
