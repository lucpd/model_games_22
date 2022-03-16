using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cascade : MonoBehaviour
{
    public Material material00;
    public Material material01;
    public Material material02;
    public Material material03;
    public Material material04;
    public Material material05;

    private float randomMass;

    public GameObject[] objects;
    private int index;

    private float usingTime = 0;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        usingTime += Time.deltaTime;
        print(usingTime);
        if (usingTime > 0.07) 
        {

            GameObject clone;
            clone = Instantiate(objects[index], new Vector3(Random.Range(-17.0f, 22.0f), 20.0f, 0), Quaternion.identity);



            float randomMass = Random.Range(2.0f, 3.5f);
            

            usingTime = 0;


            if (randomMass >= 2f && randomMass < 2.25f)
            {
                clone.GetComponent<Renderer>().material = material00;
            }
            else if (randomMass >= 2.25f && randomMass < 2.5f)
            {
                clone.GetComponent<Renderer>().material = material01;
            }
            else if (randomMass >= 2.5f && randomMass < 2.75f)
            {
                clone.GetComponent<Renderer>().material = material02;
            }
            else if (randomMass >= 2.75f && randomMass < 3f)
            {
                clone.GetComponent<Renderer>().material = material03;
            }
            else if (randomMass >= 3f && randomMass < 3.25f)
            {
                clone.GetComponent<Renderer>().material = material04;
            }
            else if (randomMass >= 3.25f && randomMass < 3.5f)
            {
                clone.GetComponent<Renderer>().material = material05;
            }
        }
        

    }
}
