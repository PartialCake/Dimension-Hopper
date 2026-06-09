using UnityEngine;

public class NotebookUI : MonoBehaviour
{
  
    public GameObject notesCanvas;
    public Transform centerEye;

    public float distance = 0.5f;

    private bool collected = false;
    private bool opened = false;

    public void CollectNote()
    {
        collected = true;
        opened = true;

        ShowNote();
    }

    void Update()
    {
        if (!collected) return;

        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            opened = !opened;

            if (opened)
                ShowNote();
            else
                notesCanvas.SetActive(false);
        }
    }

    void ShowNote()
    {
        notesCanvas.SetActive(true);

        notesCanvas.transform.position =
            centerEye.position + centerEye.forward * distance;

        notesCanvas.transform.rotation =
            Quaternion.LookRotation(
                notesCanvas.transform.position - centerEye.position
            );
    }
}
