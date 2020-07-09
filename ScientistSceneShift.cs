using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class ScientistSceneShift : MonoBehaviour
{
    public Animator transition;
    public GameObject[] enemies;
    public GameObject KillAllText;

    private void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        KillAllText.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && PlayerManager.instance.EnemiesKilled==52)
        {
            transition.SetTrigger("start");
            SceneManager.LoadScene("ScientistTalk");   
        }

        else
        {
            StartCoroutine(Killallfirst());
        }
    }

    IEnumerator Killallfirst()
    {
        KillAllText.SetActive(true);
        yield return new WaitForSeconds(3f);
        KillAllText.SetActive(false);
    }
}
