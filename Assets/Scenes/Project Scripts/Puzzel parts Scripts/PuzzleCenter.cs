using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class PuzzleCenter : MonoBehaviour
{
    public Rigidbody centerrigidbody;
    public HandGrabInteractable centerinteractable;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "spotC")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;
            transform.localScale = other.transform.localScale;

            centerrigidbody.isKinematic = true;
            centerinteractable.enabled = false;
        }
    }
}
