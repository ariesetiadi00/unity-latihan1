using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool check = false;
    public float delay = 1f;
    private string scenePosition;
    public void endGame () {
        if(check == false) {
            check = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay);
        }
    }
    public void Restart(){
        scenePosition = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scenePosition);
    }
}
