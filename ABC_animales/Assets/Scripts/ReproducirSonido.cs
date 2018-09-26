using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirSonido : MonoBehaviour {

	public void Reproducir()
    {
        GetComponent<AudioSource>().Play();
    }
}
