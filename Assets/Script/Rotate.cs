using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
        transform.Rotate(Vector3.right * 20 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        //transform.Rotate(Vector3.up * 20 * Time.deltaTime);
        //transform.Rotate(Vector3.right * 20 * Time.deltaTime);
    }
}