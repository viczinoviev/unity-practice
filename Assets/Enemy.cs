using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer sr;
    private float damageTime = 0.1f;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    public void TakeDamage()
    {
        sr.color = Color.red;
        Invoke(nameof(TurnWhite), damageTime);
    }

    private void TurnWhite()
    {
        sr.color = Color.white;
    }
    
}
