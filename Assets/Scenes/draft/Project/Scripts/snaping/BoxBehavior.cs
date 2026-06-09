using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{

    public Rigidbody rb;
    public HandGrabInteractable interactable;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "spot1")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;

            rb.isKinematic = true;
            interactable.enabled = false;
        }
    }
}
