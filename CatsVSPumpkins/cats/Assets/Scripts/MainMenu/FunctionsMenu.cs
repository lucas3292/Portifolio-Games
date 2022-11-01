using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FunctionsMenu : MonoBehaviour
{

    public void ToStart(){
        SceneManager.LoadScene("Game");
    }
    public void ToExit(){
        Application.Quit();
    }
    
}
