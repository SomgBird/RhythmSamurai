using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityState : PlayerState
{
    protected bool isAbilityDone;

    private bool isGrounded;

    private Movement movement;
    protected Movement Movement => movement ? movement : core.GetCoreComponent(ref movement);
    
    private CollisionSenses collisionSenses;
    private CollisionSenses CollisionSenses =>
        collisionSenses ? collisionSenses : core.GetCoreComponent(ref collisionSenses);
    
    public PlayerAbilityState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animationName) : base(player, stateMachine, playerData, animationName)
    {
    }


    public override void Enter()
    {
        base.Enter();

        isAbilityDone = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (isAbilityDone)
        {
            if(isGrounded) // TODO: Y velocity check??
                stateMachine.ChangeState(player.IdleState);
            else
                stateMachine.ChangeState(player.FallState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void UpdateState()
    {
        base.UpdateState();

        if (CollisionSenses)
            isGrounded = CollisionSenses.Ground;
    }
}
