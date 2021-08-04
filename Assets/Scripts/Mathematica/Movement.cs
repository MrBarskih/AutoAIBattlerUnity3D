using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 center;
    float smeschenie = 0;
    float sinusoidSmeschenie = 0;
    float radius = 4f;
    private void FixedUpdate()
    {
        sinusoidSmeschenie += 3.14f / 2 * Time.fixedDeltaTime * 20;
        float sinusoidY = (float)Math.Sin(sinusoidSmeschenie) * 0.1f;
        smeschenie += 3.14f / 4 * Time.fixedDeltaTime;
        float y = (float)Math.Sin((0 + smeschenie)) * (radius + sinusoidY);
        float z = (float)Math.Cos((0 + smeschenie)) * (radius + sinusoidY);
        gameObject.transform.position = new Vector3(center.x, center.y + y, center.z + z);
    }
}
