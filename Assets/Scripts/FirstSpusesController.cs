using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FirstSpusesController : MonoBehaviour
{

    
	
	void Start ()
	{

	    Tweener tweener = this.transform.DOMove(new Vector3(-3025.1f, -8.2f, -2824.5f),10f);
	    tweener.SetAutoKill(false);
	    tweener.Pause();

	}

    void OnTriggerEnter(Collider collider)
    {


        if (collider.name == "Player")
        {

            collider.transform.parent = this.transform;
            Invoke("DoAnimation",2f);
            Invoke("DoComplete",11.5f);

        }

    }


    public void DoAnimation()
    {

        GameObject.Find("Stage2").transform.SendMessage("DoPlay");

        GameObject.Find("Player").transform.SendMessage("PlayerStopMove");

        GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().smoothSpeed = 2f;

        this.transform.DOPlayForward();

        
    }

    public void DoComplete()
    {

        GameObject.Find("Player").transform.parent = null;

        GameObject.Find("Player").transform.SendMessage("PlayerCanMove");

        GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().smoothSpeed = 0.8f;

        this.transform.GetComponent<BoxCollider>().enabled = false;

    }


}
