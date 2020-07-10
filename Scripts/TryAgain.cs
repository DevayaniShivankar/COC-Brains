using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class TryAgain : MonoBehaviour
{
    public Animator transition;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(shift());
        }
    }

    IEnumerator shift()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("The Planet");
    }
}
