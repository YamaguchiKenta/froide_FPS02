using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ƒ‰ƒCƒuƒ‰ƒŠ‚Ì’Ç‰Á
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class stage1_1 : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
    }
    void StartGame()
    {
        SceneManager.LoadScene("FPS_01");
    }
}