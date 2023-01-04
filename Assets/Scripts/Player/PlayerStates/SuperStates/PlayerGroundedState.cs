using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{

    protected int
        xInput,
        yInput;

    protected bool 
        isTouchingCeiling,
        jumpInput,
        grabInput,
        isGrounded,
        isTouchingWall,
        isTouchingLedge;

    private Movement movement;
    protected Movement Movement => movement ? movement : core.GetCoreComponent(ref movement);
    
    private CollisionSenses collisionSenses;
    protected CollisionSenses CollisionSenses => collisionSenses ? collisionSenses : core.GetCoreComponent(ref collisionSenses);

    public PlayerGroundedState(Player player, PlayerStateMachine stateMachine, string animationName) 
        : base(player, stateMachine, animationName)
    {
    }


    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        
        // TODO: Update player input from input handler
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void UpdateState()
    {
        base.UpdateState();

        if (!CollisionSenses) return;
        isGrounded = CollisionSenses.Ground;
        isTouchingWall = CollisionSenses.WallFront;
        isTouchingLedge = CollisionSenses.LedgeHorizontal;
        isTouchingCeiling = CollisionSenses.Ceiling;
    }
}
