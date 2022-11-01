using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void FixedUpdate() {
        var positionAnchor = Vector2.Lerp(transform.position,player.position,0.1f);
        if(transform.position.y < 15 && transform.position.y > -4.4f){
            transform.position = new Vector3(transform.position.x,positionAnchor.y, transform.position.z);
        }
        if( transform.position.y <= -4.4f){
            transform.position = new Vector3(transform.position.x,-4.39f, transform.position.z);
        }
    }
}
