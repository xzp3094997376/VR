using UnityEngine;
using System.Collections;

public class ZD : MonoBehaviour {

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 10,ForceMode.Impulse);
        Destroy(gameObject, 3f);
       
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
