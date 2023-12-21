using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    BaseStateMachine currentState;
    public StartState StartS = new StartState();
    public PlayState PlayS = new PlayState();
    public PauseState PauseS = new PauseState();
    public EndState EndS = new EndState();
    // Start is called before the first frame update
    void Start()
    {
        currentState = StartS;
        StartS.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update(this);   
    }
    public void SwitchState(BaseStateMachine state)
    {
        currentState = state;
        state.Enter(this);  
    }    
}
