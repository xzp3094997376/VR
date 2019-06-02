using UnityEngine;
using System.Collections;

public class TestAwake2 : MonoBehaviour {
    float testTime = 0;
    private void Awake()//executed--> once on restart the unity-->start menu/load to the scene->initialed the scene all datas once
    {
        Debug.Log("TestAwake2");
        Debug.Log(Quaternion.identity);
      
    }
    private void OnEnable()//executed the script which was enabled =refreash the data in the current script
    {
        Debug.Log("TestOnEnable2");//I->IEnumrator
    }

    private void OnLevelWasLoaded(int level)//calld at the scene changed after Awake(),it blong to the unity -->dont belong to the scripts
    {
        Debug.Log("OnLevelWasLoaded2"+level);
    }

    // Use this for initialization
    void Start () {//executed once at the gameobject activated,=Awake()
        Debug.Log(2 + "start");
     
        //DontDestroyOnLoad(gameObject);
    }

  
    private void FixedUpdate()//rennder the physical enginee
    {
        
        Debug.Log("FixedUpdate");
    }

   
    void Update () // Update is called once per frame
    { 
        Debug.Log("update");
	}

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    /// <summary>
    /// render after lateUpdte()
    /// </summary>
    private void OnDrawGizmos()
    {
        
    }

    private void OnGUI()//called 2 times once frame
    {
        Debug.Log("OnGUI");
    }
    private void OnDestroy()//the gameobject was destroyeds
    {
        Debug.Log("OnDestroy2");
        Application.Quit();
        Debug.Log("OnDestroy3");
    }

    private void OnDisable()//the script enabled=false
    {
        Debug.Log("OnDisable2");
      Destroy(gameObject);
      //  Application.LoadLevel(1);
    }

    private void OnGUIw()
    {
   
    }
}
