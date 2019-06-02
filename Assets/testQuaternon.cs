using UnityEngine;
using System.Collections;

public class testQuaternon : MonoBehaviour {
    public Transform c1;
    public Transform c2;
	// Use this for initialization
	void Start () {
      //float a=  Quaternion.Angle(c1.rotation, c2.rotation);//get the angle between two rotations
      //Debug.Log(a+"----------------");
      //float b= Quaternion.Dot(c1.rotation, c2.rotation);
      //Quaternion q=Quaternion.FromToRotation(transform.forward,Vector3.left);
      //Debug.Log("b= " + b+"  q="+q.ToString());
      //float c= Mathf.Acos(b);
      //Debug.Log(c);
      //Quaternion t = new Quaternion(0, 8, 0, 1);
      //Quaternion t1= new Quaternion(0, 1, 0, 6);
      //float dotq= Quaternion.Dot(t, t1);
      //Debug.Log(dotq);
        Vector3 v1 = new Vector3(1, 0, 0);
        Vector3 v2 = new Vector3(0.5f,0, 1.732f);
        float t=   Vector3.Dot(v1.normalized, v2.normalized);
        Debug.Log(t);
    }
	
	// Update is called once per frame
	void Update () {

	}
    private void OnGUI()
    {
 
    }
    void ChangeMaterial(Material m)
    {
        GetComponent<Renderer>().material = m;
    }
}
