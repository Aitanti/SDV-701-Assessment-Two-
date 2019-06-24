using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace cameraClient
{
    static class ServiceClient
    {
        internal async static Task<List<string>> GetCameraNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/camera/GetCameraNames/"));
        }

        internal async static Task<clsBrand> GetCameraAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsBrand>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/camera/GetCamera?BrandName=" + prBrandName));
        }
        internal async static Task<List<string>> GetEquipmentAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/camera/GetEquipment?BrandName=" + prBrandName));
        }
        //internal async static Task<clsCameraequipment> GetEquipmentAsync(string prEquipmentType)
        //{
        //    using (HttpClient lcHttpClient = new HttpClient())
        //        return JsonConvert.DeserializeObject<clsCameraequipment>
        //    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/camera/GetEquipment?Brand_Name=" + prEquipmentType));

        //}



        //private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        //{
        //    using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
        //    using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
        //    using (HttpClient lcHttpClient = new HttpClient())
        //    {
        //        HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
        //        return await lcRespMessage.Content.ReadAsStringAsync();
        //    }
        //}





        //internal async static Task<string> InsertCameraAsync(clsCameraequipment prEquipmentType)
        //{
        //    return await InsertOrUpdateAsync(prEquipmentType, "http://localhost:60064/api/camera/PostCameras", "POST");
        //}

        //internal async static Task<string> UpdateCameraAsync(clsCameraequipment prEquipmentType)
        //{
        //    return await InsertOrUpdateAsync(prEquipmentType, "http://localhost:60064/api/camera/PutCameras", "PUT");
        //}

        //    internal async static Task<string> DeleteCameraAsync(clsCameraequipment prCamera)
        //    {
        //        using (HttpClient lcHttpClient = new HttpClient())
        //        {
        //            HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
        //        ($"http://localhost:60064/api/camera/DeleteCamera?Model={prCamera.Model}");
        //            return await lcRespMessage.Content.ReadAsStringAsync();
        //        }
        //        throw new NotImplementedException();
        //    }


    }









}
