using UnityEngine;

public abstract class BaseStateMachine 
{
    public abstract void Enter(GameManager gameManager);
    public abstract void Update(GameManager gameManager);

}
