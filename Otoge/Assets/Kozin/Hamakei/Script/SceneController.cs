using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour
{
    public string _nextScene;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Application.LoadLevel(_nextScene);
        }
    }

    private void OnGUI()
    {
        var rect = new Rect(10, 10, 400, 100);
        var text = string.Format("Index:{0}\nName:{1}",
                                 Application.loadedLevel,
                                 Application.loadedLevelName);
        GUI.Label(rect, text);
    }
}
