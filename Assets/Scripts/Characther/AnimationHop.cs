using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationHop : MonoBehaviour
{
    bool isHop;
    Animator animator;
 
    void Start()
    {
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
       
            if (!isHop)
            {
                animator.SetTrigger("hop");
                isHop = true;
            }
            else if ((Input.GetMouseButton(0)||Input.GetKeyDown(KeyCode.A))&&!isHop)
            {
                animator.SetTrigger("hop");
                isHop = true;
            }
            else if ((Input.GetMouseButton(0)||Input.GetKeyDown(KeyCode.D))&&!isHop)
            {
                animator.SetTrigger("hop");
                isHop = true;
            }
           
    }
    public void  FinishHop()
    {
        isHop = false;
    }
}
