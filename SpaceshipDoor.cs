using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipDoor : MonoBehaviour
{
    Animator _animator;
    GameObject player;
    CharacterController cc;
    AudioSource aud;
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
        _animator = GetComponent<Animator>();
        player = GameObject.Find("Player");
        cc = player.GetComponent<CharacterController>();
        aud = player.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _animator.SetTrigger("open");
            StartCoroutine(FreezeResume());
        }
    }
    IEnumerator FreezeResume()
    {
        PlayerFreeze();
        yield return new WaitForSeconds(5);
        PlayerResume();
        Destroy(gameObject);
    }
}
