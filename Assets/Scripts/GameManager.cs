using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager GetInstance()
    {
        if(_instance == null)
        {   // ������ ã�� ����
            _instance = FindObjectOfType<GameManager>();
        }
        // �׷����� ���� ?
        if (_instance == null) 
        {
            GameObject go = new GameObject("GameManager");
            _instance = go.AddComponent<GameManager>();
            
        }


        return _instance;
    }

    void Start()
    {

        Debug.Log(" ���� �ϴ°� Ȯ��");
        UIManager.Instance.CreateGameUI<UIStartPage>();

    }

    public void GameStart()
    {

    }
    public void ChanegGameScene()
    {
        UIManager.Instance.RemovePage<UISelectMode>();

        SceneManager.LoadScene("InGameScene");

        CountTimer ui = UIManager.Instance.CreateGameUI<CountTimer>() as CountTimer;
       // ui.SetGameTime();
    }
    

    
}
