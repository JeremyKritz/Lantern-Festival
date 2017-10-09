using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I CAN MAKE THE LANTERN INTO A PREFAB, SPAWN SAID PREFAB, AND DELETE THE INITIAL LANTERN



public class LanternSpawn : MonoBehaviour {
    public GameObject lantern = GameObject.Find("Cylinder");

	// Use this for initialization
	void Start () {
        InvokeRepeating("SendLantern", 0, .6f);
	}

    // Update is called once per frame
    void Update() {
    }
    void SendLantern() { 
        int randx = Random.Range(-100, 400);
        int randz = Random.Range(180, 450);

        Vector3 location = new Vector3(randx, 5, randz);
        Quaternion rotation = lantern.transform.rotation;
        GameObject.Instantiate(lantern, location, rotation);
        
    }
}
