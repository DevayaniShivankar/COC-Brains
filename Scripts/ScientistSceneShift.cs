using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScientistSceneShift : MonoBehaviour
{
    public Animator transition;
    public GameObject KillAllText;
    public void Start()
    {
        KillAllText.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && PlayerManager.instance.EnemiesKilled==52)
        {
            transition.SetTrigger("start");
            SceneManager.LoadScene("ScientistTalk");   
        }

        else if(other.CompareTag("Player"))
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
