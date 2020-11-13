using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAtRange : StateMachineBehaviour 
{
    TowerManager tm;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state  
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        tm = animator.GetComponent<TowerManager>();
        animator.speed = tm.self.attackRange;

    }

    //OnStateUpdate is called on each update frame between OnStateEnter and OnStateExit callbacks;
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(tm.currentTarget != null)
        {
            tm.AttackTarget();
        }
        else 
        {
            animator.SetBool("hasTarget", false);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.speed = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
