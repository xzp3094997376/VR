using UnityEngine;
using System.Collections;
using System.Reflection;
using System;

namespace test{
    public class TestUsingKeyWord : MonoBehaviour {

        // Use this for initialization
        void Start() {
            Assembly ass= Assembly.Load("UnityEngine");//load the program intergrated class 
            foreach (Type type in ass.GetTypes())//get all classes information
            {
                string t = type.Name;
            }
            Type type1 = ass.GetType("UnityEngine.GameObject");//specified the special program intergrated
            Activator.CreateInstance(type1);
            MethodInfo mInfor = type1.GetMethod("Destroy");
            UnityEngine.Object[] ot=null;
            mInfor.Invoke(null,ot);
        }

        // Update is called once per frame
        void Update() {

        }
    }
}

namespace test1
{
    using test1 = test;//
    /*
     * using :
     * use the keyword to give value to the another 
     * 1.import the spcified namespace
     * 
     * 
     * 
     * 
     * 
     */
    public class TestClass {


    }

}
