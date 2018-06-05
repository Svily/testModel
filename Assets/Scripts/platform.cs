using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class platform : MonoBehaviour
{
    
	
	void Start ()
	{

	    Tweener tweener = this.transform.DOMove(new Vector3(295, 40, 331), 8f);
	    tweener.SetAutoKill(true);
	    tweener.Pause();
	}
	
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        coll.gameObject.transform.parent = this.transform;

        if (coll.name == "Player")
        {
            Invoke("PlatFormMove", 2f);
        }
    }

    void OnTriggerExit(Collider coll)
    {
        coll.gameObject.transform.parent = null;
        transform.DOPlayBackwards();
    }

    void PlatFormMove()
    {

         transform.DOPlayForward();
        
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
