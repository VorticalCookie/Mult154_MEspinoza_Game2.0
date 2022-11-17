using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(animator != null)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                animator.SetTrigger("AttackTrigger");
            }

            if(Input.GetKeyUp(KeyCode.E)) 
            {
                animator.SetTrigger("IdleTrigger");
            }
        }
    }
}
