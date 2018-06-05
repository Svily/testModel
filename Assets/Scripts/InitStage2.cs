using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class InitStage2 : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            collider.transform.parent = this.transform;

            Invoke("DoRotate",2f);
        }
    }


    void DoRotate()
    {
        this.transform.DORotate(new Vector3(0, -180, 0), 6f);
    }

}
