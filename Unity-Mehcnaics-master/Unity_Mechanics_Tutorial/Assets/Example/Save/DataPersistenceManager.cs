using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DataPersistenceManager : MonoBehaviour
{
   [Header("File Storage Config")]
   [SerializeField] private string fileName;
   private GameData gameData;
   private List<IDataPersistence> dataPersistenceObjects;
   private FileDataHandler dataHandler;
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
      this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
      this.dataPersistenceObjects = FindAllDataPersistenceObjects();
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
      this.gameData = dataHandler.Load();
      if(this.gameData == null)
      {
         Debug.Log("No data was found. Initializing data to defaults"); 
         NewGame();
      }
      Debug.Log(Application.persistentDataPath);
      // TODO - push the Loaded data to all the scripts that need it
      foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects)
         dataPersistenceObj.LoadData(gameData);
   }
   public void SaveGame(){
      //TODO - pass the data to other scripts so they can update it
      foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects)
         dataPersistenceObj.SaveData(ref gameData);
      //TODO -  save that data to a file using the data handler
      dataHandler.Save(gameData);
   }
   private List<IDataPersistence> FindAllDataPersistenceObjects(){
      // FindObjectsofType takes in an optional boolean to include inactive gameobjects
      IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>(true)
      .OfType<IDataPersistence>();

      return new List<IDataPersistence>(dataPersistenceObjects);

   }
}
