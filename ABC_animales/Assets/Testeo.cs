using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testeo : MonoBehaviour {
    public Animator anim;
    int runState;
    public bool run;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        run = false;
	}
	
	// Update is called once per frame
	void Update () {
        Activar();
	}

    public void Activar()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Go");
        }
        else
        {
            run=false;
        }
    }
}
