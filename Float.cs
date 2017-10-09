using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour {

    // I CAN MAKE THE LANTERN INTO A PREFAB, SPAWN SAID PREFAB, AND DELETE THE INITIAL LANTERN

    // Use this for initialization
    void Start () {
        InvokeRepeating("Destroy", 60.0f, 0.0f);
        if (this.gameObject.name != "Cylinder(Clone)")
        {
            Renderer rend = GetComponent<Renderer>(); 
            rend.enabled = false;
        }
        

        }

        // Update is called once per frame
        void Update () {

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.Translate(0, 0.1f, 0);

	}
    void Destroy()
    {
        if (this.gameObject.name == "Cylinder(Clone)") { 
        Object.Destroy(this.gameObject); }
    }
}
