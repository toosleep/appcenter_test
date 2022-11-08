using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAnimation : MonoBehaviour
{
    
    [SerializeField]
    private float rotationRate = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameObject Rotation Started");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, rotationRate * Time.deltaTime);
    }
}
