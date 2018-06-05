using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GreenTriggerController : MonoBehaviour {

	
	void Start ()
	{

	    Tweener tweener = this.transform.DOMove(new Vector3(0,17.1f, -21.64f), 3f);
	    tweener.Pause();


	}


    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            this.transform.DOPlayForward();

            GameObject.Find("platform").SendMessage("DoInitPlatformPath",SendMessageOptions.DontRequireReceiver);

        }
    }



}
