using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGlideState : PlayerInAirState
{
    public PlayerGlideState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animationName) : base(player, stateMachine, playerData, animationName)
    {
    }
}
