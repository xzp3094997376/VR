using UnityEngine;
using System.Collections;

public class VR_Shooter : MonoBehaviour {

    public GameObject ZD;
    public Transform GunPos;
    private SteamVR_TrackedObject dev;
    void Start()
    {
        dev = GetComponent<SteamVR_TrackedObject>();
    }
    void Update()
    { 
        var ctrl = SteamVR_Controller.Input((int)dev.index);
        Debug.Log(ctrl.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger));
        if(ctrl.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)){
            Debug.Log("Trigger");
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject go = Instantiate(ZD) as GameObject;
        go.transform.position = GunPos.transform.position;
        go.transform.rotation = GunPos.transform.rotation;
    }
}
