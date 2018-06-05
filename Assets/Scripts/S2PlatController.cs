using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class S2PlatController : MonoBehaviour {

	
	void Start ()
	{

	    Tweener tweener = this.transform.DOMove(new Vector3(-3050.56f, 55f, -2914.12f), 8f);

	    tweener.Pause();

	}



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

        //GameObject.Find("Player").transform.SendMessage("PlayerStopMove");

        GameObject.Find("s2finaltrigger").transform.DOMove(new Vector3(-3070.39f, 38.5f, -2869.97f), 20f);

        this.transform.DOPlayForward();

    }


}
