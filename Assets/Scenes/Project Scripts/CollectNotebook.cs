using UnityEngine;
using System.Collections;
public class CollectNotebook : MonoBehaviour
{

    public NotebookUI notebookUI;

    public void Collect()
    {
        notebookUI.CollectNote();

        gameObject.SetActive(false);
    }
}
