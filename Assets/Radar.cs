using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    // Start is called before the first frame update
public GameObject[] trackedObjects;
List<GameObject> radarObjects; 
public GameObject radarPrefab;
List<GameObject> borderObjects;
public float switchDistance;
public Transform helpTransform;

    void Start()
    {
        createRadarObjects();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < radarObjects.Count; i++)
        {
            if(Vector3.Distance(radarObjects[i].transform.position, transform.position)>switchDistance){
                //siwtch to borderobjects
                helpTransform.LookAt(radarObjects[i].transform);
                borderObjects[i].transform.position = transform.position + switchDistance*helpTransform.forward;
                borderObjects[i].layer = LayerMask.NameToLayer("Radar");
                radarObjects[i].layer = LayerMask.NameToLayer("invisible");
            }
            else
            {
                //switch back to radarObjects
                borderObjects[i].layer = LayerMask.NameToLayer("invisible");
                radarObjects[i].layer = LayerMask.NameToLayer("Radar");
            }
        }
    }

    void createRadarObjects(){
        radarObjects = new List<GameObject>();
        borderObjects = new List<GameObject>();

        foreach(GameObject o in trackedObjects){
            GameObject k = Instantiate(radarPrefab, o.transform.position, Quaternion.identity) as GameObject;
            radarObjects.Add(k);
            GameObject j = Instantiate(radarPrefab, o.transform.position, Quaternion.identity) as GameObject;
            borderObjects.Add(j);
        }
    }
}
