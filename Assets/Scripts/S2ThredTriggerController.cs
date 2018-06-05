using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class S2ThredTriggerController : MonoBehaviour {



    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {

            this.transform.DOMove(new Vector3(-3016.07f, 83.11f, -2883.79f), 3f);

            GameObject.Find("s2plat").transform.GetComponent<BoxCollider>().enabled = true;

            Collider[] coll = this.transform.GetComponents<BoxCollider>();

            coll[1].enabled = false;


        }
    }

}
