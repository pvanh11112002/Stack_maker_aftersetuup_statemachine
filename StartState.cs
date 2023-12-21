using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : BaseStateMachine
{
    public int second = 0;
    public override void Enter(GameManager gameManager)
    {
        Debug.Log("HAHAHAHAHAHA");
    }

    public override void Update(GameManager gameManager)
    {
        Debug.Log("HIHIHIHIHIHI");
        second++;
        if(second > 50)
        {
            gameManager.SwitchState(gameManager.PlayS);
        }    
    }
}
