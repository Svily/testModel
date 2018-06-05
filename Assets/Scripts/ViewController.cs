using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour {


    void OnTriggerEnter(Collider collider)
    {
        if (collider.name =="Player")
        {
            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceH = 15f;

            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceV = 12f;
        }
    }

}
