using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI nameText;

    [SerializeField]
    TextMeshProUGUI scoreTxt;

    protected virtual void Awake()
    {
        if (nameText != null && scoreTxt != null)
        {
            nameText.text = StateManager.Instance.getName();
            scoreTxt.text = StateManager.Instance.getScore();
        }
    }

    public void Reiniciar()
    {
        LevelManager.Instance.FirstScene();
    }

}
