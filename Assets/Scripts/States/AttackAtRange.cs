using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : StateMachineBehavior 
{
    TowerManager tm;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state  
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        tm = animator.GetComponent<TowerManager>();
        animator.speed = tm.self.attackRate;

    }

    //OnStateUpdate is called on each update frame between OnStateEnter and OnStateExit callbacks;
    override public void OnstateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
