using UnityEngine;
using System.Collections;

public class TestAwake : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("TestAwake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Use this for initialization
    void Start () {
        Debug.Log("1111Start");
       // Application.LoadLevel(1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
