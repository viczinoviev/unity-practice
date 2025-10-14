using UnityEngine;

public class EnemyGoblin : Enemy
{
    [ContextMenu("Steal Money")]
    private void StealMoney()
    {
        Debug.Log($"{enemyName} is stealing money!");
    }
}
