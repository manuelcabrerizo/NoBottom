using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float distance = 3.0f;

    private void Awake()
    {
	    Vector3 targetPosition = target.transform.position;
	    transform.position = targetPosition + Vector3.up * distance;	
	    transform.LookAt(targetPosition, Vector3.forward);
    }

    private void Update()
    {
        Vector3 targetPosition = target.transform.position;
        targetPosition.x = 0;
        targetPosition.z = 0;
        transform.position = targetPosition + Vector3.up * distance;
        transform.LookAt(targetPosition, Vector3.forward);
    }
    

}
