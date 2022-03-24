using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateControl : MonoBehaviour
{
    Animator animator;
    public Transform feetTransform;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
          //   if (animator.GetFloat("slip") < 1.0f)
          //   {
                animator.SetBool("isWalkingForward", true);
                animator.SetBool("isWalkingBackward", false);
          //   }

            
        }
        else
        {
            animator.SetBool("isWalkingForward", false);
        }

        if (feetTransform.position.z > 28 && feetTransform.position.z < 38 && animator.GetFloat("slip") < 0.5f)
        {
            int chanceToSlip = Random.Range(0, 150);
            if (chanceToSlip == 11 && !Input.GetKey(KeyCode.Q)) animator.SetFloat("slip", 10.0f);
        }

        if (animator.GetFloat("slip") > 0.0f)
        {
            float reduction = animator.GetFloat("slip") - (Time.deltaTime * 2.0f);
            animator.SetFloat("slip", reduction);
            if(animator.GetFloat("slip") < 0.0f) animator.SetFloat("slip", 0.0f);
        }

    }
}
