using System;
using UnityEngine;

public class Player : MonoBehaviour
{

    #region StateMachine
    public PlayerStateMachine StateMachine { get; private set; }
    
    [SerializeField] private PlayerData playerData;
    public PlayerIdleState IdleState { get; private set; } 
    public PlayerRunningState RunningState { get; private set; }
    

    #endregion


    #region Components
    public Core Core { get; private set; }
    public Rigidbody2D RB { get; private set; }
    public Animator PlayerAnimator { get; private set; }
    public PlayerInputHandler InputHandler { get; private set; }
    #endregion


    public void Awake()
    {
        Core = GetComponentInChildren<Core>();
        StateMachine = new PlayerStateMachine();

        IdleState = new PlayerIdleState(this, StateMachine, playerData, "idle");
        WalkState = new PlayerWalkState(this, StateMachine, playerData, "walk");
    }

    public void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
        InputHandler = GetComponent<PlayerInputHandler>();
        
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
