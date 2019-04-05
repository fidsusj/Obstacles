using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;

    private const float force = 100;

    void FixedUpdate() {

        switch (Input.inputString) {
            case "a": sidewaysForce = -force;
                break;
            case "d":
                sidewaysForce = force;
                break;
            default:
                sidewaysForce = 0;
                break;
        }
        rb.AddForce(this.sidewaysForce * Time.deltaTime, 0, this.forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if(rb.position.y <= -10) {
            FindObjectOfType<Game>().EndGame();
        }

    }
}