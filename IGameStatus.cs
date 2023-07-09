using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameStatus 
{
   bool StartBool { get; set; }
   bool GameNow { get; set; }
   bool GameOver { get; set;}
   bool GameClear {get; set; }
   void ChangeGameNow();
   void ChangeGameOver();
   void ChangeGameClear();
}
