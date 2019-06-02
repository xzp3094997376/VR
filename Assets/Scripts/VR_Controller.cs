using UnityEngine;
using System.Collections;

public class VR_Controller : MonoBehaviour {

    private SteamVR_TrackedObject dev;
    void Start()
    {
        dev = 
            GetComponent<SteamVR_TrackedObject>();//get SteamVR_TrackedObject-->get the device
    }
    void Update()
    { 
        //获取输入事件
        var ctrl = SteamVR_Controller.Input((int)dev.index);//Steam_Controller.input((int)dev.index);-->get the controller
        //获取具体的输入
        if (ctrl.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))   //listen the steam_vrTrackedobject
        { 
            Debug.Log("Trigger Trigger Trigger");
        }
        var dir = ctrl.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);//get 
        Debug.Log(dir);
    }

}
