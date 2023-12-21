using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : BaseStateMachine
{
    public override void Enter(GameManager gameManager)
    {
        Debug.Log("Hello from PlayState");
    }

    public override void Update(GameManager gameManager)
    {
        Debug.Log("Hello from PlayState. This is Update");

    }
}
