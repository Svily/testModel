using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlatformController : MonoBehaviour {

	
	void Start () {
		
        //初始化DoTween动画
	    Tweener tweener = this.transform.DOMove(new Vector3(-31.76f, 12.05f, 9.21f),11f);
	    tweener.Pause();

	}


    void DoInitPlatformPath()
    {
        this.transform.DOPlayForward();
        
    }


    void OnTriggerEnter(Collider collider)
    {
        

        if (collider.name == "Player")
        {

            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceH = 15f;

            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceV = 12f;

            //设置人物父物体
            collider.transform.parent = this.transform;

            Invoke("DoPath",2f);

            
        }

    }


    /*void OnTriggerExit(Collider collider)
    {
        if (collider.name == "Player")
        {

            //设置人物父物体
            collider.transform.parent = this.transform;

            GameObject.Find("Player").transform.parent = null;

            this.transform.DOMove(new Vector3(-31.76f, 11.3f, 9.21f), 12f);

        }
    }*/


    void DoPath()
    {


        //禁止人物运动
        GameObject.Find("Player").transform.SendMessage("PlayerStopMove",SendMessageOptions.DontRequireReceiver);

        //调整摄像机跟随速度
        GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().smoothSpeed =2f;

        //调整方向
        this.transform.DORotate(new Vector3(0, -90, 0), 5f, RotateMode.Fast);

        //移动至第二关
        this.transform.DOMove(new Vector3(-3035.01f, 3.46f, -2721.76f), 10f);

        Invoke("InitSencond",12f);

    }

    void InitSencond()
    {
        GameObject.Find("Player").transform.SendMessage("PlayerCanMove", SendMessageOptions.DontRequireReceiver);

        GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().smoothSpeed = 0.8f;

        //禁用该触发器
        this.transform.GetComponent<BoxCollider>().enabled = false;

    }
}
