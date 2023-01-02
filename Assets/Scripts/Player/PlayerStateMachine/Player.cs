using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator PlayerAnimator { get; private set; }


    public void Awake()
    {
        
    }

    public void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }
}
