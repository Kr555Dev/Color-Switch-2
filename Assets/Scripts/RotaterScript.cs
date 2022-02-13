using UnityEngine;

public class RotaterScript : MonoBehaviour
{     // Update is called once per frame
    public float Rotationspeed = 120f;

    void Update()
    {
        transform.Rotate(0f, 0f, Rotationspeed * Time.deltaTime);
    }
}
