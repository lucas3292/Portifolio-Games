using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackGame : MonoBehaviour
{
    public void BackToGame(){
        SceneManager.LoadScene("Game");
    }
}
