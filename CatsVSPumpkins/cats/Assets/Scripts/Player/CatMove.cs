using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    private Vector3 mousePosition;
    
    void Update()
    {
        if(Input.touchCount>0){
            Touch t = Input.GetTouch(0);
            Vector3  pos = Camera.main.ScreenToWorldPoint(t.position);
            pos.z = 0;
            transform.position = pos;
        }
        if(transform.position.x <= -2.58f){
            transform.position = new Vector3(-2.57f, transform.position.y, transform.position.z);
        }
        if(transform.position.x >= 2.58f){
            transform.position = new Vector3(2.57f, transform.position.y, transform.position.z);
        }
    }
    private Vector3 GetMousePosition(){
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDown() {
        mousePosition =  gameObject.transform.position - GetMousePosition();
    }
    private void OnMouseDrag() {
        if(transform.position.x > -2.58f && transform.position.x < 2.58f){
            transform.position = GetMousePosition() + mousePosition;   }
    }

}
