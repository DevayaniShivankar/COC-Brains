using UnityEngine.SceneManagement;
using UnityEngine;

public class StartKeys : MonoBehaviour
{ 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("The Lab");
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("AboutPanel");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
