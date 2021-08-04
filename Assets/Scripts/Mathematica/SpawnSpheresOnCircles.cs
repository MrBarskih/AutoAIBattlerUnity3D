using UnityEngine;
using System;

public class SpawnSpheresOnCircles : MonoBehaviour
{
    GameObject newSphere;
    
    private void Awake()
    {
        newSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        newSphere.name = "newSphere" + 0;
        Vector3 center = gameObject.transform.position;
        

        float radius = 4f;

        newSphere.transform.position = new Vector3(center.x, center.y + ((float)Math.Sin(3.14 * 0 / 4) * radius), center.z + ((float)Math.Cos(3.14 * 0 / 4) * radius));
        newSphere.AddComponent<Movement>().center = gameObject.transform.position;
    }

    private void FixedUpdate()
    {
        newSphere.GetComponent<Movement>().center = gameObject.transform.position;
    }
}
