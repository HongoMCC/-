using UnityEngine;
using SatorImaging.AppWindowUtility;


public class SetScreen : MonoBehaviour 
{
    void Start()
    {
        AppWindowUtility.Transparent = true;//透明にする
        AppWindowUtility.FullScreen = true;//フルスクリーンにする
    }   
}