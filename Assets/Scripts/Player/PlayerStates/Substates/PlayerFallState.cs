using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallState : PlayerInAirState
{
    public PlayerFallState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animationName) : base(player, stateMachine, playerData, animationName)
    {
    }
}
