using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smelt : MonoBehaviour
{
    public int tickingPower = 1;
    public int tickingProgress = 0;

    public Button buttonSmelt;
    public Slider smeltingProcess;

    public static Smelt instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Smelt dans la scène");
            return;
        }
        instance = this;
    }
    void Update()
    {

        if (smeltingProcess.value != tickingProgress)
        {
            smeltingProcess.value = tickingProgress;
            float colorProgress = (float)tickingProgress;
            IronNuggets.instance.spriteRenderer.color = Color.Lerp(Color.white, new Color32(255, 95, 0, 255), colorProgress / 100);
        }

        if (IronNuggets.instance.spriteRenderer.enabled == true || Ressource.instance.ironNug == 0)
        {
            buttonSmelt.interactable = false;
        }
        else
        {
            buttonSmelt.interactable = true;
        }
    }
    public void SmeltStart()
    {
        if (Ressource.instance.ironNug >= 1)
        {
            IronNuggets.instance.spriteRenderer.enabled = true;
            Ressource.instance.ironNug --;
            StartCoroutine(Ticking(tickingPower));
        }
    }

    IEnumerator Ticking(int tickingPower)
    {
        while (tickingProgress <= 99)
        {
            tickingProgress += tickingPower;
            yield return new WaitForSeconds(0.2f);
        }
        IronNuggets.instance.spriteRenderer.enabled = false;
        Ressource.instance.ironIng++;
        tickingProgress = 0;
    }
}
