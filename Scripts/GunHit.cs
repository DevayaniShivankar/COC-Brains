using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class GunHit : MonoBehaviour
{
    public float health;
    [SerializeField] GameObject EnemyBody;
    [SerializeField] Animator _animator;
    NavMeshAgent agent;

    public void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health<= 0f)
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        _animator.SetBool("Dead", true);
        yield return new WaitForSeconds(3);
        EnemyBody.SetActive(false);
        PlayerManager.instance.EnemiesKilled++;
    }
 
}
