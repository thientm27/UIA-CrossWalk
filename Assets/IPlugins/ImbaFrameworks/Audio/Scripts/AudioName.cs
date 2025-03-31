using UnityEngine;

namespace Imba.Audio
{
    [SerializeField]
    public enum AudioName
    {
        // Main Music
        Track_1 = -2,

        NoSound = -1,

        BGM_Menu     = 0,
        BGM_GAMEPLAY = 1,

        #region UI

        PopupOpen  = 2,
        PopupClose = 3,

        #endregion

        #region GAME PLAY

        Click1        = 6,
        Uio        = 7,
       
        #endregion
    }

    public enum AudioType
    {
        SFX = 0,
        BGM = 1,
        AMB = 2,
    }
}