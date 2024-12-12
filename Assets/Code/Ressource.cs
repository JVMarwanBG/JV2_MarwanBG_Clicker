using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ressource : MonoBehaviour
{
    public static Ressource instance;
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
