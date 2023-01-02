public class PlayerState
{
    protected Player player;
    protected PlayerStateMachine stateMachine;

    private string animationName;


    public PlayerState(Player player, PlayerStateMachine stateMachine, string animationName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animationName = animationName;
    }

    public virtual void Enter()
    {
        player.PlayerAnimator.SetBool(animationName, true);
    }
    
    public virtual void Exit()
    {
        player.PlayerAnimator.SetBool(animationName, false);
    }
    
    public virtual void LogicUpdate()
    {
        
    }
    
    public virtual void PhysicsUpdate()
    {
        
    }
}
