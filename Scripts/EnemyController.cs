using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 20f;
    Transform target;
    NavMeshAgent agent;
    Animator _animator;
    private AudioSource AlienSound;
    public float damageOnPlayer = 4f;

    public HealthBar healthBar;
    
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        AlienSound = GetComponent<AudioSource>();
        
    }
    
    public void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance > lookRadius)
        {
            _animator.SetBool("IsWalking", false);
            agent.enabled = false;
        }

        if (distance <= lookRadius)
        {
            AlienSound.Play();
            agent.enabled = true;
            agent.destination = target.position;
            _animator.SetBool("IsWalking", true);
            _animator.SetBool("Attack", false);

            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                agent.destination = target.position;
                _animator.SetBool("Attack", true);
                      
                StartCoroutine(healthreduce());
            }
        }
        

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    
    IEnumerator healthreduce()
    {
        while (_animator.GetBool("Attack"))
        {            
            PlayerManager.instance.CurrentHealth -= damageOnPlayer*Time.deltaTime;
            healthBar.SetHealth(PlayerManager.instance.CurrentHealth);
            yield return new WaitForSeconds(1f);
        }
    }
}
