using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
    public float delay = 1f;
    private bool ended = false;

    public GameObject levelCompleteScreen;

    public void CompleteLevel() {
        levelCompleteScreen.SetActive(true);
    }

    public void EndGame() {
        if (!ended) {
            this.ended = true;
            Invoke("restartGame", this.delay);
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}