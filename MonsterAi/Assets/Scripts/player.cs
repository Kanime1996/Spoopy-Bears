using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    // Use this for initialization
    public bool alive = true;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Eyes")
        {
            other.transform.parent.GetComponent<Monster>().checkSight();
        }
        else if(other.CompareTag("lostCandy"))
        {
            Destroy(other.gameObject);
            gamePlayCanvas.instance.findPage();
        }
    }
}
