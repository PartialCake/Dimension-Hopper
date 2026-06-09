using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class BoxUnlock : MonoBehaviour
{

    public Box chest;                                                              

    public HandGrabInteractable keyinteractable;

    private void OnTriggerEnter(Collider other) 
    { 
        if (other.CompareTag("Key")) 
        { 
            other.GetComponent<Rigidbody>().isKinematic = true;
            chest.OpenChest();
            Debug.Log(other.gameObject.name);
            Debug.Log($"{transform.position.x} {transform.position.y}");
            Debug.Log($"{other.transform.position.x} {other.transform.position.y}");
            other.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            other.transform.rotation = transform.rotation;
             Debug.Log($"{other.transform.position.x} {other.transform.position.y}");
            keyinteractable.enabled = false;

        }
    }
}
