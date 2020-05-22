using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewGameScript : MonoBehaviour
{

    public Button yourButton;







    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene("arena");
    }



    // Update is called once per frame
    public void Update()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
}
