using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class S2SecondTriggerController : MonoBehaviour {

	
	void Start ()
	{

	    Tweener tweener = this.transform.DOMove(new Vector3(-3020.77f, 75.17f, -2862.9f), 2f);
	    tweener.Pause();

	}


    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            this.transform.DOPlayForward();

            GameObject.Find("stonedoor").transform.DOMove(new Vector3(-3034.72f,78.01f, -2876.67f), 12f);

            GameObject.Find("s2plat").transform.DOMove(new Vector3(-3050.56f, 74.42f, -2914.12f), 22f);

        }
    }


}
