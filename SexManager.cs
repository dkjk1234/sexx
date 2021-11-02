using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SexManager : MonoBehaviour
{
    List<Rigidbody> rigidodies = new List<Rigidbody>();
    List<GameObject> sexList = new List<GameObject>();
    List<GameObject> angList;
    public Vector3 pos;
    public GameObject water;
    public int gage = 0;
    void Start()
    {
        gage = 10;
        pos = new Vector3(0.83f, -2.3f, -1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            gage--;
            
        }
        if (gage == 0)
        {
            for (int i = 0; i < 30; i++)
            {


                GameObject a = Instantiate(water, new Vector3(0.83f, -2.3f, -1.5f), Quaternion.identity) as GameObject;
                sexList.Add(a);
                for(i = 0,)
                {
                    sexList[s].transform.Translate(0, 1, -1);
                    Debug.Log("¾Ó¾Ó¾Ó");
                }

           
            }
        }
        

        
        
    }
}
