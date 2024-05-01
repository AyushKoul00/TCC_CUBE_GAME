using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 2f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel() {
        CompleteLevelUI.SetActive(true);
    }

    public void Endgame(){
        if(gameEnded == false){
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
