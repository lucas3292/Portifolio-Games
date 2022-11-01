using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud: MonoBehaviour
{
   
    void Start()
    {
       Destroy(gameObject, 10f);
    }
    
    private void FixedUpdate() {
        transform.position += transform.right * Time.deltaTime * 2;
    }
}
