using UnityEngine;

public class UIToggleActive : MonoBehaviour
{
    public void ToggleGameObject(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
}
