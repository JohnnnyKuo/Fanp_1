# Save and load system
* writtern by Ian Chen
## Conecpt
1. GameData -> store all the state
   -  Player data
   -  Audio data
   -  Diologue data
   -  ...ETC
2.  DataPersistanceManager -> Keep track all the state
   -  and constroll read write IO
      * NewGame()
      * SaveGame()
      * LoadGame()
   - It's a singleton class, One GameData only   
3. IDataPersistence -> it's a interface , if a class need to save and load, it's need implement IDataPersistence
   - DataPersistanManager will have list of IDataPersistence
4. FileDatahandler.cs, is detach to DataPersistenceManager