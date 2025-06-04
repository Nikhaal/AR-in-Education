using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class qn1 : MonoBehaviour
{
    public Button qnbt;
    // Start is called before the first frame update
    void Start()
    {
        qnbt.onClick.AddListener(qnnxt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void qnnxt()
    {
        SceneManager.LoadScene(19);
    }
}
