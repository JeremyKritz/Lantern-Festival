using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I CAN MAKE THE LANTERN INTO A PREFAB, SPAWN SAID PREFAB, AND DELETE THE INITIAL LANTERN



public class WaterLanternSpawn : MonoBehaviour
{
    public GameObject wlantern = GameObject.Find("waterlantern");

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SendLantern", 0, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SendLantern()
    {
        int randx = Random.Range(285, 325);
        int randz = Random.Range(335, 375);

        Vector3 location = new Vector3(randx, 4.5f, randz);
        Quaternion rotation = wlantern.transform.rotation;
        // change up lantern rotation
        GameObject.Instantiate(wlantern, location, rotation);

    }
  
}
