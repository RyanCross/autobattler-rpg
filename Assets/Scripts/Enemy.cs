using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 10;
    public Hero hero;

    Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hero = FindObjectOfType<Hero>();
        hero.Hit += processHit;

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

        if(hp <= 0)
        {
            animator.SetBool("dead", true);
        }
    }

    void processHit(int damage)
    {
        hp -= 1;
        Debug.Log($"HP is now {hp}");
    }
}
