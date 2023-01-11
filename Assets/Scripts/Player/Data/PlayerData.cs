using UnityEngine;


[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Walking state")] public float walkVelocity = 10f;

    [Header("Jump state")] 
    public float jumpVelocity = 15f;
    public int amountOfJumps = 1;

    [Header("In Air State")] 
    public float coyoteTime = 0.2f;
}
