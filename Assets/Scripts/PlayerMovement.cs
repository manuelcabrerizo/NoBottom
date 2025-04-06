using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
	    Movement();
    }

    private void Movement()
    {
        float x = Input.GetAxis("Horizontal");
	    float y = 0;
	    float z = Input.GetAxis("Vertical");

	    if(Input.GetKey(KeyCode.Space))
	    {
	        y = 1.0f;
	    }
	    else if(Input.GetKey(KeyCode.LeftControl))
	    {
	        y = -1.0f;
	    }

	    Vector3 forward = Vector3.forward;
	    Vector3 right = Vector3.right;
	    Vector3 up = Vector3.up;
	
	    forward.y = 0;
	    right.y = 0;
	    forward.Normalize();
	    right.Normalize();
	
        Vector3 direction = forward * z + right * x + up * y;
        if (direction.sqrMagnitude < 0.01f)
        {
            return;
        }
        direction.Normalize();

        _rigidbody.AddForce(direction * speed, ForceMode.Acceleration);
    }
}

