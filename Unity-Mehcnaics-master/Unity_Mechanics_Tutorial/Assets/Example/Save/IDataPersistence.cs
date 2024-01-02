public interface IDataPersistence 
{
   void LoadData(GameData data);
   void SaveGame(ref GameData data);
}
