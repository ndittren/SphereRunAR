using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    private float screenCenterX;

    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }

    void Update()
    {
        // if there are any touches currently
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);

            // if it began this frame
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (firstTouch.position.x > screenCenterX)
                {
                    rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                else if (firstTouch.position.x < screenCenterX)
                {
                    rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
