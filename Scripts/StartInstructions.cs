using System.Collections;
using UnityEngine;
public class StartInstructions : MonoBehaviour
{
    GameObject startinstructions;
    GameObject ToDolist;
    [SerializeField] CharacterController cc;
    [SerializeField] AudioSource aud;

    public void PlayerFreeze()
    {
        cc.enabled = false;
        aud.enabled = false;
    }

    public void PlayerResume()
    {
        cc.enabled = true;
        aud.enabled = true;

    }
    void Start()
    {
        startinstructions = GameObject.Find("InitialInstructions");
        ToDolist = GameObject.Find("ToDolist");
        ToDolist.SetActive(false);
        startinstructions.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(InitInstr());
    }

    IEnumerator InitInstr()
    {
       
        yield return new WaitForSeconds(6f);
        startinstructions.SetActive(false);
        ToDolist.SetActive(true);
        
    }
}
