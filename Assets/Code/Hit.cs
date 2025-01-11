using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{

    public int damagePower = 1;
    public int miningPower = 1;
    public Button buttonHit;

    public static Hit instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance d'Hit dans la scène");
            return;
        }
        instance = this;
    }

    private void Update()
    {

    }

    public void ReduceHp(int damagePower)
    {
        if (Iron.instance !=null && Iron.instance.spriteRenderer.enabled == true)
        {
            Iron.instance.baseHp -= damagePower;
            if (Iron.instance.baseHp <= 0)
            {
                Ressource.instance.ironNug ++;
            }
        }
            
    }


    public void Mine(int miningPower)
    {
        Ressource.instance.miningState += miningPower;
    }
}
