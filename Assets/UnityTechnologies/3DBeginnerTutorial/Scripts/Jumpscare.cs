using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject jumpscareObject;
    public AudioSource jumpascareSound;
    private Boolean jumpscareEnabled = true;
    public ParticleSystem steamParticle;

    // Start is called before the first frame update
    void Start()
    {
        jumpscareObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" & jumpscareEnabled== true)
        {
            jumpscareEnabled = false;
            jumpscareObject.SetActive (true);
            jumpascareSound.Play();
            steamParticle.Play();
            StartCoroutine(DestroyObject());
            
        }
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(2.2f);
        Destroy(jumpscareObject);
        Destroy(gameObject);
    }

  
    // Update is called once per frame
    void Update()
    {
       
    }
}
