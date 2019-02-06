using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateSave : MonoBehaviour
{
    [SerializeField]
    private SSDataControl _ssDataControl;

    public void OnsaveButton()
    {
        int gamemode = 0;
        int maxmode = 3;
        int gamescore = 2;
        int maxscore = 5;

        _ssDataControl.SaveData(gamemode, maxmode, gamescore, maxscore);


        Application.Quit();
    }
}
