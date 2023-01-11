public class PlayerState
{
    protected Player player;
    protected PlayerStateMachine stateMachine;
    protected Core core;
    protected PlayerData playerData;

    private string animationName;


    public PlayerState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animationName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animationName = animationName;
        this.playerData = playerData;
        core = player.Core;
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


    public virtual void UpdateState()
    {
        
    }
}
