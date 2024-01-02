using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistenceManager : MonoBehaviour
{
   private GameData gameData;
   public static DataPersistenceManager Instance { get; private set; }
   public void OnNewGameClicked(){
      DataPersistenceManager.Instance.NewGame();
   }
   public void OnLoadGameClicked(){
      DataPersistenceManager.Instance.LoadGame();
   }
   public void OnSaveGameClicked(){
      DataPersistenceManager.Instance.SaveGame();
   }
   private void Awake()
   {
      if (Instance != null)
      {
         Debug.LogError("Found more than one data Persistence Manager in scene");
         return;
      }
      Instance = this;
   }
   private void Start(){
      LoadGame();
   }
   private void OnApplicationQuit(){
      SaveGame();
   }
   public void NewGame()
   {
      gameData = new GameData();
   }
   public void LoadGame(){
      //TODO - load any saved data frin a fuke using the data handler

      if(this.gameData == null)
      {
         Debug.Log("No data was found. Initializing data to defaults"); 
         NewGame();
      }
      // TODO - push the Loaded data to all the scripts that need it
   }
   public void SaveGame(){
      //TODO - pass the data to other scripts so they can update it
      //TODO -  save that data to a file using the data handler
   }
}
