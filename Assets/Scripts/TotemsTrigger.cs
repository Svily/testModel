using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TotemsTrigger : MonoBehaviour
{


    public AudioClip TotemClip;
    

    void OnTriggerEnter(Collider collider)
    {

        if (collider.name == "Player")
        {
            
            //升起平台图腾
            GameObject.Find("totems").SendMessage("TotemsUp",SendMessageOptions.DontRequireReceiver);
            //降下下侧图腾
            GameObject.Find("totems2").SendMessage("Totems2Down", SendMessageOptions.DontRequireReceiver);
            //抖动
            //GameObject.Find("Main Camera").SendMessage("DoShark",SendMessageOptions.DontRequireReceiver);
            
            //设置人物父物体为空
            collider.transform.parent = null;

            collider.transform.GetComponent<PlayerController>().walkSpeed = 0.1f;

            collider.transform.GetComponent<PlayerController>().runSpeed = 0.2f;

            
            AudioSource.PlayClipAtPoint(TotemClip, collider.transform.position,10.0f);

        }

        //销毁该触发器
        Destroy(this.transform.gameObject);

    }
}
