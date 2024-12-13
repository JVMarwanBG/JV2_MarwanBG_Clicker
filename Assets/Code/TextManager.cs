using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text ironOre;
    public Text ironNug;
    public Text ironIng;
    public Text copperOre;
    public Text copperNug;
    public Text copperIng;
    public Text titaniumOre;
    public Text titaniumNug;
    public Text titaniumIng;
    public Text goldOre;
    public Text goldNug;
    public Text goldIng;

    private void Update()
    {
        ironOre.text = Ressource.instance.ironOre.ToString();
        ironNug.text = Ressource.instance.ironNug.ToString();
        ironIng.text = Ressource.instance.ironIng.ToString();
        copperOre.text = Ressource.instance.copperOre.ToString();
        copperNug.text = Ressource.instance.copperNug.ToString();
        copperIng.text = Ressource.instance.copperIng.ToString();
        titaniumOre.text = Ressource.instance.titaniumOre.ToString();
        titaniumNug.text = Ressource.instance.titaniumNug.ToString();
        titaniumIng.text = Ressource.instance.titaniumIng.ToString();
        goldOre.text = Ressource.instance.goldOre.ToString();
        goldNug.text = Ressource.instance.goldNug.ToString();
        goldIng.text = Ressource.instance.goldIng.ToString();
    }
}





