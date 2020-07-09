using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton
    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
        CurrentHealth = MaxHealth;
    }
    #endregion

    public GameObject player;
    public float MaxHealth  = 100f;
    public float MinHealth = 0f;
    public float CurrentHealth;
    public int EnemiesKilled = 0;
}
