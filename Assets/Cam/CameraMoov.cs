using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMoov : MonoBehaviour
{
    public Animator animator;
    public Button buttonLeft;
    public Button buttonRight;

    public void goLeft()
    {
        animator.SetBool("Left", true);
        buttonLeft.enabled = false;
    }

    public void goRight()
    {
        animator.SetBool("Right", true);
        buttonRight.enabled = false;
    }

    public void resetLeft()
    {
        animator.SetBool("Left", false);
    }

    public void resetRight()
    {
        animator.SetBool("Right", false);
    }
}
