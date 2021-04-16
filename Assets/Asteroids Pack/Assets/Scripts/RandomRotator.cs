using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField] float tumble;
    float accelx, accely, accelz = 1;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
    void Update()
    {
        accelx = Input.acceleration.x;
        accely = Input.acceleration.y;
        accelz = Input.acceleration.z;
        transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, accelz * Time.deltaTime);
    }


}