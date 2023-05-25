using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    Finish endScreen;

    void Awake() 
    {
        quiz = FindObjectOfType<Quiz>();
        endScreen = FindObjectOfType<Finish>();
        
    }
    void Start()
    {
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);        
    }


    void Update()
    {
        bool isComplete =  quiz.isComplete;
        if(isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
        
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
}
