using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FinalPlatTriggerController : MonoBehaviour {



    void OnTriggerEnter(Collider collider)
    {

        if (collider.name == "Player")
        {

            collider.transform.parent = this.transform;

            
            Invoke("DoAnimation",2f);
            
        }

    }


    void DoAnimation()
    {
        this.transform.DORotate(new Vector3(0, -180, 0), 4f);
        this.transform.DOMove(new Vector3(-3070.57f, 96.24f, -2875.77f), 6f);
    }

}
