using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    void Awake(){
        Time.timeScale = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonClicked(){
        foreach (Transform eachChild in transform){
            if (eachChild.name != "Score" && eachChild.name != "Life"){
                eachChild.gameObject.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
    }

    public void RestartButtonClicked(){
        SceneManager.LoadScene("Game");
    }
}
