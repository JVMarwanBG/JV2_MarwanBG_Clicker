using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ressource : MonoBehaviour
{
    public static Ressource instance;

    public int ironOre = 0;
    public int ironNug = 0;
    public int ironIng = 0;

    public int moneyAmount = 0;

    // Import de l'auto click----------------------------
    public int miningState;
    public int oreAmount;
    public Button MiningButton;
    public GameObject ore;
    public bool oreactive = false;
    //---------------------------------------------------
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Ressource dans la scène");
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
    }

    //---------------------------------------------------
    public IEnumerator Reset()
    {
        if (!oreactive)
        {
            Ressource.instance.ironOre -= oreAmount;
            ore.SetActive(true);
            oreactive = true;
        }
        Ressource.instance.ironOre += oreAmount;
        MiningButton.interactable = false;
        miningState -= 1;
        yield return new WaitForSeconds(0.1f);
        miningState -= 1;
        yield return new WaitForSeconds(0.1f);
        miningState -= 1;
        yield return new WaitForSeconds(0.1f);
        miningState -= 1;
        yield return new WaitForSeconds(0.1f);
        miningState -= 1;
        MiningButton.interactable = true;
    }
    //---------------------------------------------------
}
