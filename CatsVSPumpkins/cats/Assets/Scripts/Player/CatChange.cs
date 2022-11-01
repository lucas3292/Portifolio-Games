using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatChange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] spritsCats;
    public int idCat;
    private const float DOUBLE_CLICK_TIME = .2f;
    private float lastClickTime;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        idCat = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        OnClick();
    }
    public void OnClick(){
        if(Input.GetMouseButtonDown(0)){
            float timeSinceLastClick = Time.time - lastClickTime;
            if(timeSinceLastClick <= DOUBLE_CLICK_TIME){
                idCat++;
                if(idCat > 2){
                    idCat = 0;
                }
                spriteRenderer.sprite = spritsCats[idCat];
            }
            lastClickTime = Time.time;
        }
    }

    
}
