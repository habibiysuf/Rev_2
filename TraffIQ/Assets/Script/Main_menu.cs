﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    
   public void Playgame()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
