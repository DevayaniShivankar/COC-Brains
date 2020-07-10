using UnityEngine;
using System.Collections;

public class MachineAnalayze : MonoBehaviour
{
    [SerializeField] public GameObject uiobject;
    [SerializeField] public Animator _animator;
    [SerializeField] public GameObject loadingbar;
    [SerializeField] public Animator messagepop;

    GameObject player;
    CharacterController cc;
    AudioSource aud;
    private bool _IsInside = false;
    private bool _isAnalyzed = false;

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
        uiobject.SetActive(false);
        loadingbar.SetActive(false);
        player = GameObject.Find("Player");
        cc = player.GetComponent<CharacterController>();
        aud = player.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( _IsInside)
        {

            if (Input.GetKeyDown(KeyCode.M))
            {
                _isAnalyzed = !_isAnalyzed;
                _animator.SetBool("Analyse", _isAnalyzed);
                StartCoroutine(FreezeAnalyse());
                messagepop.SetBool("collected", true);
                
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            uiobject.SetActive(true);
            _IsInside = true;
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            uiobject.SetActive(false);
            _IsInside = false;
        }
    }

    IEnumerator FreezeAnalyse()
    {
        PlayerFreeze();
        uiobject.SetActive(false);
        loadingbar.SetActive(true);
        yield return new WaitForSeconds(5);
        loadingbar.SetActive(false);
        PlayerResume();
        Destroy(gameObject);

    }
}
