using UnityEngine.SceneManagement;
using UnityEngine;

public class LeaveScene : MonoBehaviour
{
    public string ScToLoad;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(ScToLoad);
        }
    }
}
