using UnityEngine.SceneManagement;
using UnityEngine;

public class BackKey : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("startup");
        }
    }
}
