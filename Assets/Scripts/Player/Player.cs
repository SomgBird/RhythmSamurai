using System;
using UnityEngine;

public class Player : MonoBehaviour
{

    #region StateMachine
    public PlayerStateMachine StateMachine { get; private set; }
    
    public PlayerIdleState IdleState { get; private set; } 
    public PlayerRunningState RunningState { get; private set; }
    

    #endregion


    #region Components
    public Core Core { get; private set; }
    public Rigidbody2D RB { get; private set; }

    #endregion
    
    public Animator PlayerAnimator { get; private set; }


    public void Awake()
    {
        Core = GetComponentInChildren<Core>();
        StateMachine = new PlayerStateMachine();

        IdleState = new PlayerIdleState(this, StateMachine, "idle");
        RunningState = new PlayerRunningState(this, StateMachine, "idle");
    }

    public void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
        
        StateMachine.Initialize(IdleState);
    }

    public void Update()
    {
        Core.LogicUpdate();
        StateMachine.CurrentState.LogicUpdate();
    }

    public void FixedUpdate()
    {
        StateMachine.CurrentState.PhysicsUpdate();
    }
}
