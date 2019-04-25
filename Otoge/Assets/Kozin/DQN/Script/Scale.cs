using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, -0.08f, 0);
        this.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
    }
}
