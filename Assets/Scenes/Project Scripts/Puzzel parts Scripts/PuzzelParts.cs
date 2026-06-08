using Oculus.Interaction.HandGrab;
using UnityEngine;

public class PuzzelParts : MonoBehaviour
{
    public Transform puzzleL;
    public Rigidbody leftrigidbody;
    public HandGrabInteractable leftinteractable;

    public Transform puzzleR;
    public Rigidbody rightrigidbody;
    public HandGrabInteractable rightinteractable;

    public Transform puzzleT;
    public Rigidbody toprigidbody;
    public HandGrabInteractable topinteractable;

    public Transform puzzleB;
    public Rigidbody bottomrigidbody;
    public HandGrabInteractable bottominteractable;

    public Transform puzzleC;
    public Rigidbody centerrigidbody;
    public HandGrabInteractable centerinteractable;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "spotL")
        {
            puzzleL.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            puzzleL.transform.rotation = other.transform.rotation;

            leftrigidbody.isKinematic = true;
            leftinteractable.enabled = false;
        }

        if (other.gameObject.name == "spotR")
        {
            puzzleR.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            puzzleR.transform.rotation = other.transform.rotation;

            rightrigidbody.isKinematic = true;
            rightinteractable.enabled = false;
        }

        if (other.gameObject.name == "spotT")
        {
            puzzleT.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            puzzleT.transform.rotation = other.transform.rotation;

            toprigidbody.isKinematic = true;
            topinteractable.enabled = false;
        }

        if (other.gameObject.name == "spotB")
        {
            puzzleB.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            puzzleB.transform.rotation = other.transform.rotation;

            bottomrigidbody.isKinematic = true;
            bottominteractable.enabled = false;
        }

        if (other.gameObject.name == "spotC")
        {
            puzzleC.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            puzzleC.transform.rotation = other.transform.rotation;

            centerrigidbody.isKinematic = true;
            centerinteractable.enabled = false;
        }


    }

}
