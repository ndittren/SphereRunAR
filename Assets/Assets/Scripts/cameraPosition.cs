
using UnityEngine;

public class cameraPosition : MonoBehaviour {

    public Transform player;
    public Vector3 offset; //a vector3 holds 3 floats. 3 integers
	

	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
