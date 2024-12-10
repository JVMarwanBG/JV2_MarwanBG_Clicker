using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{

    public int damagePower = 1;
    public int tickingPower = 1;
    public int tickingProgress = 0;
    public Button buttonHit;
    public Button buttonSmelt;
    public Slider smeltingProcess;

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

        if (smeltingProcess.value != tickingProgress)
        {
            smeltingProcess.value = tickingProgress;
            float colorProgress = (float)tickingProgress;
            IronNuggets.instance.spriteRenderer.color = Color.Lerp(Color.white, new Color32(255, 95, 0, 255), colorProgress / 100);
        }

        if (Iron.instance.spriteRenderer.enabled == false)
        {
            buttonHit.interactable = false;
        }
        else
        {
            buttonHit.interactable = true;
        }
        if (IronNuggets.instance.spriteRenderer.enabled == true || IronNuggets.instance.nuggetsCount == 0)
        {
            buttonSmelt.interactable = false;
        }
        else
        {
            buttonSmelt.interactable = true;
        }

    }
    public void ReduceHp(int damagePower)
    {
        Iron.instance.baseHp -= damagePower;
    }

    public void SmeltStart()
    {
        if (IronNuggets.instance.nuggetsCount >= 1)
        {
            IronNuggets.instance.spriteRenderer.enabled = true;
            IronNuggets.instance.nuggetsCount--;
            StartCoroutine(Ticking(tickingPower));
        }
    }

    IEnumerator Ticking(int tickingPower)
    {
        while (smeltingProcess.value <= 99)
        {
            tickingProgress += tickingPower;
            yield return new WaitForSeconds(0.2f);
        }
        IronNuggets.instance.spriteRenderer.enabled = false;
    }
}
