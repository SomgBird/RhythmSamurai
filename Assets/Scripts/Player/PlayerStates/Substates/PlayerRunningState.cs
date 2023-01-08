using UnityEngine;

public class PlayerRunningState : PlayerGroundedState
{
    public PlayerRunningState(Player player, PlayerStateMachine stateMachine, string animationName) 
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
        
        Movement.CheckIfShouldFlip(xInput);
        Movement.SetVelocityX(3 * xInput);
        
        if (xInput == 0)
            stateMachine.ChangeState(player.IdleState);
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void UpdateState()
    {
        base.UpdateState();
    }
}
