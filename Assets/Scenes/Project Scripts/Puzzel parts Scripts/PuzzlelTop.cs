using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class PuzzlelTop : MonoBehaviour
{
    public Rigidbody toprigidbody;
    public HandGrabInteractable topinteractable;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "spotT")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;
            transform.localScale = other.transform.localScale;

            toprigidbody.isKinematic = true;
            topinteractable.enabled = false;
        }
    }
}
