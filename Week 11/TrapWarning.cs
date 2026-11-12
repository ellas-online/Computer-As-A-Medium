
using UnityEngine;

public class TrapWarning : MonoBehaviour
{
    public GameObject warningMessage;

    void Start()
    {
        warningMessage.SetActive(false);
    }

    public void ShowWarning()
    {
        warningMessage.SetActive(true);
    }

    public void HideWarning()
    {
        warningMessage.SetActive(false);
    }
}
