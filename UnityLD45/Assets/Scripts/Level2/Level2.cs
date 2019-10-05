using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{

    public GameObject player;
    public Camera cam;

    private Plane[] cameraPlanes;
    // Start is called before the first frame update
    void Start()
    {
        cameraPlanes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GeometryUtility.TestPlanesAABB(cameraPlanes, player.GetComponent<SpriteRenderer>().bounds))
        {
            //
        } else
        {
            Debug.Log("out");
        }
    }

    
}
