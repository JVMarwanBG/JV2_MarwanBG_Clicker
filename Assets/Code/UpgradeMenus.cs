using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UpgradeMenus : MonoBehaviour
{
    public GameObject menuForge;
    public bool menuForgeActive;

    public GameObject menuMine;
    public bool menuMineActive;

    public GameObject buttonMine2;
    public bool autoMine;

    public SpriteRenderer spriteRenderer;

    public int prixMine1;
    public int prixMine2;

    public static UpgradeMenus instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de UpgradeMenus dans la scène");
            return;
        }
        instance = this;
    }

    private void Start()
    {
        menuForge.SetActive(false);
        menuMine.SetActive(false);
    }
    public void ActiveForge()
    {
        if (menuForgeActive == false)
        {
            menuForge.SetActive(true);
            menuForgeActive = true;
        }
        else
        {
            menuForge.SetActive(false);
            menuForgeActive = false;
        }
    }

    public void ActiveMine()
    {
        if (menuMineActive == false)
        {
            menuMine.SetActive(true);
            menuMineActive = true;
        }
        else
        {
            menuMine.SetActive(false);
            menuMineActive = false;
        }
    }

    public void UpgradeMine1()
    {
        if (Ressource.instance.moneyAmount >= prixMine1)
        {
            Ressource.instance.moneyAmount -= prixMine1;
            Ressource.instance.oreAmount += 1;
            prixMine1 = prixMine1 * 2;
        }
    }

    public void UpgradeMine2()
    {
        if (Ressource.instance.moneyAmount >= prixMine2)
        {
            Ressource.instance.moneyAmount -= prixMine2;
            spriteRenderer.enabled = true;
            autoMine = true;
            StartCoroutine(AutoMine());
            Destroy(buttonMine2);
        }
    }

    IEnumerator AutoMine()
    {
        while (autoMine == true)
        {
            Hit.instance.Mine(Hit.instance.miningPower);
            yield return new WaitForSeconds(2f);
        }

    }

}
