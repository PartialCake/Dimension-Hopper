using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class PuzzleLeft : MonoBehaviour
{
    public Rigidbody leftrigidbody;
    public HandGrabInteractable leftinteractable;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "spotL")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;
            transform.localScale = other.transform.localScale;

            leftrigidbody.isKinematic = true;
            leftinteractable.enabled = false;
        }
    }

}
