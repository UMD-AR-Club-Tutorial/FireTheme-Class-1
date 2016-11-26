using UnityEngine;
using System.Collections;
using System;

public class WDestroy : MonoBehaviour {

    public Transform fire, water;



    IEnumerator stopFire()
    {
        yield return new WaitForSeconds(10f);
        fire.GetComponent<ParticleSystem>().enableEmission = false;
    }
    // Update is called once per frame
    void OnTriggerEnter() {
        print(water.GetComponent<ParticleSystem>().enableEmission);
        if(water.GetComponent<ParticleSystem>().enableEmission == true)
        {
            fire.GetComponent<ParticleSystem>().enableEmission = false;
            StartCoroutine(stopFire());
        }
        fire.GetComponent<ParticleSystem>().enableEmission = true;
	}

    private void Update()
    {
        if (water.GetComponent<ParticleSystem>().enableEmission)
        {
            fire.GetComponent<ParticleSystem>().enableEmission = false;
        }
    }

}
