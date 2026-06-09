using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class PuzzleRight : MonoBehaviour
{
    public Rigidbody rightrigidbody;
    public HandGrabInteractable rightinteractable;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "spotR")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;
            transform.localScale = other.transform.localScale;

            rightrigidbody.isKinematic = true;
            rightinteractable.enabled = false;
        }
    }
}
