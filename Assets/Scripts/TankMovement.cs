using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 30;
    private Rigidbody rigidbody;
    public float number = 1;    //
     

	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        float v = Input.GetAxis("VerticalPlayer"+number);
        rigidbody.velocity = transform.forward * v * speed; //transform.forward 代表前方向  h代表-1到1的值

        float h = Input.GetAxis("HorizontalPlayer"+number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;
    }
}
