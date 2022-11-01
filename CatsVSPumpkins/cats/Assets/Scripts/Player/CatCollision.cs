using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CatCollision : MonoBehaviour
{
    private CatChange catChange;
    
    void Start()
    {
        catChange = GetComponent<CatChange>();
        
    }
    private void Update() {
      
    }
    private void ManagerCollision(GameObject coll){
        if(coll.CompareTag("PumpkimBlue")){
            if(catChange.idCat != 0){
                SceneManager.LoadScene("Lose");
            }
        }
        if(coll.CompareTag("PumpkimYellow")){
            if(catChange.idCat != 1){
                SceneManager.LoadScene("Lose");
            }
        }
        if(coll.CompareTag("PumpkimRed")){
            if(catChange.idCat != 2){
                SceneManager.LoadScene("Lose");
            }
        }
    }
   private void OnCollisionEnter2D(Collision2D other) {
        ManagerCollision(other.gameObject);
   }
}
