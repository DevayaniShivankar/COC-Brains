using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpscam;
    public ParticleSystem MuzzleFlash;
    public GameObject ImpactEffect;

    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            source.Play();
            Shoot();
        }
        
    }

    void Shoot()
    {
        MuzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            GunHit target = hit.transform.GetComponent<GunHit>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
