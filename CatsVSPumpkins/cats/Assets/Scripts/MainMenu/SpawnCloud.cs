using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCloud : MonoBehaviour
{
    [SerializeField] GameObject[] clouds;
    void Start()
    {
        StartCoroutine(CreateClouds());
    }

    private IEnumerator CreateClouds(){
        while(true){
            var idCloud =  Random.Range(0, 1);
            var pointY = Random.Range(-2.20f, 3.60f);
            Instantiate(clouds[idCloud], new Vector3(-7.52f,pointY,0), Quaternion.identity);
            yield return new WaitForSecondsRealtime(1f);
        }
    }
}
