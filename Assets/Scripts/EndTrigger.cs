using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public Game game;

    void OnTriggerEnter() {
        game.CompleteLevel();
    }

}