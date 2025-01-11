using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMoov : MonoBehaviour
{
    public Animator animator;

    public Button buttonLeft;
    public Button buttonRight;
    public GameObject buttonL;
    public GameObject buttonR;

    public GameObject forgeSide;
    public GameObject mineSide;

    private void Start()
    {
        buttonR.SetActive(false);
        mineSide.SetActive(false);
    }

    public void goLeft()
    {
        animator.SetBool("Left", true);
        buttonRight.enabled = false;
        buttonL.SetActive(false);
        forgeSide.SetActive(false);
    }

    public void goRight()
    {
        animator.SetBool("Right", true);
        buttonRight.enabled = false;
        buttonR.SetActive(false);
        mineSide.SetActive(false);
    }

    public void resetLeft()
    {
        animator.SetBool("Left", false);
        buttonRight.enabled = true;
        buttonR.SetActive(true);
        mineSide.SetActive(true);
    }

    public void resetRight()
    {
        animator.SetBool("Right", false);
        buttonLeft.enabled = true;
        buttonL.SetActive(true);
        forgeSide.SetActive(true);
    }
}
