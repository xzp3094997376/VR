using UnityEngine;
using System.Collections;

public class testTranslate : MonoBehaviour {
    Animator ani;
    // Use this for initialization
    Vector3 vec;
    CharacterController cc;
    //Vector3 last;
	void OnEnable() {
        StartCoroutine(TestCor(10, "123"));
        //vec = transform.position;
        //transform.rotation = Quaternion.Euler(0, 60, 0);
        //transform.rotation =Quaternion.AngleAxis(-60, transform.up);
        ////  Quaternion.Angle();
        //Vector3 v1 = new Vector3(0,10,0);
        //Vector3 v2 = new Vector3(0, 20, 0);
        //Vector3.Dot(v1.normalized, v2.normalized);
        //GetComponent<Rigidbody>().AddTorque(transform.up * 10, ForceMode.Impulse);
         Rigidbody r=  GetComponent<Rigidbody>();
        //r.MovePosition(transform.position + new Vector3(1, 0, 0));
        //r.MoveRotation(transform.rotation * Quaternion.Euler(new Vector3(0,10,0) * 100 * Time.deltaTime));//rotate some degrees in the specified direction
        //r.AddRelativeForce(Vector3.forward, ForceMode.Impulse);//using vector3.forward,tranform.forward cannot keep direction right==translate
        Debug.Log(Screen.width + "," + Screen.height);

        r.AddExplosionForce(2000f, transform.position, 5f, 0.0f, ForceMode.Force);
        Collider[] collders = Physics.OverlapSphere(transform.position, 5);
        Ray r12 = new Ray(transform.position, Vector3.forward);  
        RaycastHit hit;
        Physics.Raycast(r12, out hit,1);

        cc.SimpleMove(Vector3.forward);
    }
    private void OnLevelWasLoaded(int level)
    {
        ani.SetFloat(1, 10);
    }
    private void Start()
    {
        int layer = gameObject.layer;//[0,31]
        StopCoroutine("TestCor");
        Debug.Log(1 << 6);
        PlayerPrefs.SetInt("cs", 12);
        PlayerPrefs.SetString("sdd","10");
     
    }

    // Update is called once per frame
    void Update1 () {
        
       // transform.Translate(Vector3.forward * 1f * Time.deltaTime,Space.Self);//
        //Debug.DrawLine(vec, transform.position, Color.red,10,true);
      //  vec = transform.position;
      //  Debug.Log(transform.forward+"===");
    //  transform.Translate(transform.forward * 2f * Time.deltaTime,Space.World);
      // Debug.Log(transform.forward+"---");
      //Debug.DrawLine(vec,transform.position,Color.red);
      //  vec = transform.position;
    }
    IEnumerator TestCor(int a,string s)//the gameObject.setActive(false)后，协程停止运行
    {
        Debug.Log(a+"1"+s);
        yield return new WaitForSeconds(1);
        Debug.Log("2");
        yield return new WaitForSeconds(2);
        Debug.Log("3");
        Debug.Log("4");
        yield return new WaitForSeconds(3);
        Debug.Log("5");
        yield return new WaitForSeconds(1);
        Debug.Log("6");
        GetComponent<Transform>();
        lock (this)
        {

        }
    }
}
