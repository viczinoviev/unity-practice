using UnityEngine;

public class EnemyArcher : Enemy
{
    protected override void Attack()
    {
        Debug.Log($"{enemyName} is shooting an arrow!");
    }
}
