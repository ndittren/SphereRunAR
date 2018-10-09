using UnityEngine;

public class EndLevel : MonoBehaviour {

    public GameManager gameManager;

    private void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
