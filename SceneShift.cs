using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneShift : MonoBehaviour
{
    public float timeToWait;
    public string SceneName;
    [SerializeField] Animator transition;
     void Update()
    {
        StartCoroutine(ShiftScene());
    }

    IEnumerator ShiftScene()
    {
        yield return new WaitForSeconds(timeToWait);
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneName);
    }
}
