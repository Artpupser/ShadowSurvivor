using System.IO;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

namespace ShadowSurvivor.Services {
   internal static class DataService {
      public static string PathToData => Application.dataPath;
      public static async UniTask<T> LoadData<T>(DataNames name) {
         var path = BuildPath(name);
         if (File.Exists(path)) {
            var content = await File.ReadAllTextAsync(path);
            return JsonConvert.DeserializeObject<T>(content);
         }
         Debug.LogError($"file undefiend: {path}");
         return default;
      }
      public static async UniTask SaveData(object content, DataNames name) {
         var path = BuildPath(name);
         var json = JsonConvert.SerializeObject(content);
         await File.WriteAllTextAsync(path, json);
      }
      private static string BuildPath(DataNames name) => $"{PathToData}/{name}.data";
      internal enum DataNames : byte {
         AppConfig = 0,
         GameSave1 = 1,
      }
   }
}
