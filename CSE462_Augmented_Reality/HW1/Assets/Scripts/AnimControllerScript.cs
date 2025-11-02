using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimControllerScript : MonoBehaviour
{
    public Animator animator;

    public void PlayWalk()
    {
        animator.SetTrigger("WalkTrigger");
    }

    public void PlayDance()
    {
        animator.SetTrigger("DanceTrigger");
    }

    public void PlayClimb()
    {
        animator.SetTrigger("ClimbTrigger");
    }
}