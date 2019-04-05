using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform playerPosition;
    public Text scoreText;

    void Update() {
        this.scoreText.text = playerPosition.position.z.ToString("0");
    }
}