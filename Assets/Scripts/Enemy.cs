using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 10;

    Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) {
            animator.SetTrigger("attack");
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("hit");
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("dead", true);
        }
    }
}
