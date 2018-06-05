using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class S2TriggerControllerst : MonoBehaviour {


    void OnTriggerEnter(Collider collider)
    {

        if (collider.name == "Player")
        {

            GameObject.Find("S2FirstTrigger").transform.SendMessage("DoAnimation");

            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceH = 5f;

            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceV = 3f;

            this.transform.GetComponent<BoxCollider>().enabled = false;

        }
    }


}
