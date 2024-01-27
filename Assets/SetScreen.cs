using UnityEngine;


public class SetScreen : MonoBehaviour 
{
    void Start()
    {
        Screen.SetResolution(Screen.width,Screen.height, true);
    }   
}