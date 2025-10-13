using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    private Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        player = GetComponentInParent<Player>();
    }

    private void DisableMovementAndJump()
    {
        player.EnableMovementAndJump(false);
    }

    private void EnableMovementAndJump() { 
        player.EnableMovementAndJump(true); 
    }

    public void DamageEnemies() { 
        player.DamageEnemies();
    }
}
