using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ressource : MonoBehaviour
{
    public static Ressource instance;

    public int ironOre = 0;
    public int ironNug = 0;
    public int ironIng = 0;
    public int copperOre = 0;
    public int copperNug = 0;
    public int copperIng = 0;
    public int titaniumOre = 0;
    public int titaniumNug = 0;
    public int titaniumIng = 0;
    public int goldOre = 0;
    public int goldNug = 0;
    public int goldIng = 0;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Ressource dans la scène");
            return;
        }
        instance = this;
    }

    public 
    void Update()
    {
        
    }
}
