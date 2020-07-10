using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class KillAllInit : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Inint());

    }

    IEnumerator Inint()
    {
        gameObject.SetActive(false);
        yield return new WaitForSeconds(3f);
    }
}
