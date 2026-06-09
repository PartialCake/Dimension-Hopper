using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class PuzzzleBottom : MonoBehaviour
{
    public Rigidbody bottomrigidbody;
    public HandGrabInteractable bottominteractable;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "spotB")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;
            transform.localScale = other.transform.localScale;

            bottomrigidbody.isKinematic = true;
            bottominteractable.enabled = false;
        }
    }
}
