using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Startup : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(startingGame());
    }

    IEnumerator startingGame()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("The Lab");
    }
}
