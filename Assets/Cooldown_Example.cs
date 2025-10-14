using UnityEngine;

public class Cooldown_Example : MonoBehaviour
{
    private SpriteRenderer sr;
    private float damageTime = 0.1f;

    [SerializeField]private float redColorDuration = 1;

    public float currentTimeInGame;
    public float lastTimeDamaged;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        ChangeColorIfNeeded();
    }

    private void ChangeColorIfNeeded()
    {
        currentTimeInGame = Time.time;

        if (currentTimeInGame > lastTimeDamaged + redColorDuration)
        {
            if (sr.color != Color.white)
            {
                TurnWhite();
            }
        }
    }

    public void TakeDamage()
    {
        sr.color = Color.red;
        lastTimeDamaged = Time.time;
    }

    private void TurnWhite()
    {
        sr.color = Color.white;
    }
    
}
