using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    // Variables
    private float rotationSpeed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation of the propeller
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
