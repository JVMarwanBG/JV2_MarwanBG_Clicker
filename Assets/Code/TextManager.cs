using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private int test = 1;
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
        ironNug.text = test.ToString();
        ironIng.text = test.ToString();
        copperOre.text = test.ToString();
        copperNug.text = test.ToString();
        copperIng.text = test.ToString();
        titaniumOre.text = test.ToString();
        titaniumNug.text = test.ToString();
        titaniumIng.text = test.ToString();
        goldOre.text = test.ToString();
        goldNug.text = test.ToString();
        goldIng.text = test.ToString();
    }
}





