using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotsuMove : MonoBehaviour
{
    public float scale = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0.55f, -2f, 0f);
        this.transform.localScale += new Vector3(scale, scale, 0f);
    }
}
