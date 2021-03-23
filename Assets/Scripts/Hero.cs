using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public delegate void HitHandler(int damage);
    public event HitHandler Hit;

    Animator animator;
    public bool isAttacking = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Hit?.Invoke(1); // the ? is a null check on the hit event to check that there is atleast one event 
            animator.SetTrigger("attack");
        }  
    }
}
