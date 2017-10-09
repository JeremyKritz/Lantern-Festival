using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatOnWater : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("Destroy", 100.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate((-0.8987f * 0.09f), (0.43837f * 0.09f), 0);
	}
    void Destroy()
    {
        if (this.gameObject.name == "waterlantern(Clone)")
        {
            Object.Destroy(this.gameObject);
        }
    }
}
