using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text ironOre;
    public Text ironNug;
    public Text ironIng;

    public Text prixMine1;
    public Text prixMine2;


    public Text moneyAmount;

    private void Update()
    {
        ironOre.text = Ressource.instance.ironOre.ToString();
        ironNug.text = Ressource.instance.ironNug.ToString();
        ironIng.text = Ressource.instance.ironIng.ToString();

        prixMine1.text = UpgradeMenus.instance.prixMine1.ToString();
        prixMine2.text = UpgradeMenus.instance.prixMine2.ToString();

        moneyAmount.text = Ressource.instance.moneyAmount.ToString();
    }
}





