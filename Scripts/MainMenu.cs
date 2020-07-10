using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void btn_chnage_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
