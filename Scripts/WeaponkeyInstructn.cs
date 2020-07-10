using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class WeaponkeyInstructn : MonoBehaviour
{
    public Text WeaponInstruction;

    void Start()
    {
        StartCoroutine(weaponInstr());
    }

    IEnumerator  weaponInstr()
    {
        yield return new WaitForSeconds(5f);
        WeaponInstruction.enabled = false;
    }
}
