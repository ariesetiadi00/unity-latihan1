﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeUI;
    private bool check = false;
    private float delay = 1f;
    private string scenePosition;
    public void endGame () {
        if(check == false) {
            check = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay);
        }
    }
    public void Restart()
    {
        scenePosition = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scenePosition);
    }
    public void FinishComplete(){
        Debug.Log("Level Complete");
        completeUI.SetActive(true);
    }
}
