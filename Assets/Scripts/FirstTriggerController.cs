using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTriggerController : MonoBehaviour {


    void OnTriggerEnter(Collider collider)
    {

        if (collider.name == "Player")
        {
            GameObject.Find("trigger").transform.SendMessage("IceTriggerDown",SendMessageOptions.DontRequireReceiver);

            GameObject.Find("totems").transform.SendMessage("TotemsDown",SendMessageOptions.DontRequireReceiver);
        }

        Destroy(this.transform.gameObject);

    }

}
