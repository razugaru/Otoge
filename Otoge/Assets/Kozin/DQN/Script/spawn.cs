using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(Random.Range(-8.0f, 8.0f), 4f, 0f);
        Instantiate(obj, position,Quaternion.identity);
    }
}
