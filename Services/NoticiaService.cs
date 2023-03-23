
using System.Net.Http.Json;
using System.Text.Json;

namespace blazorappdemo;

public class NoticiaService: INoticiaService{

    private readonly HttpClient client;
     private readonly JsonSerializerOptions option;

    public NoticiaService(HttpClient httpClient){
        client=httpClient;
        option=new JsonSerializerOptions{PropertyNameCaseInsensitive =true};      }  
    public async Task<List<Noticia>?> Get(){
        var response=await client.GetAsync("v1/noticias");
        var content= await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        return JsonSerializer.Deserialize<List<Noticia>>(content,option);
    }

    public async Task Add(Noticia noticia){
        var response=await client.PostAsync("v1/noticias", JsonContent.Create(noticia));
        var content= await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
    }

    public async Task Delete(int noticiaId){
        var response=await client.DeleteAsync($"v1/noticias/{noticiaId}");
        var content= await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        } 
    }

}

    public interface INoticiaService
   {
        Task<List<Noticia>?> Get();
        Task Add(Noticia noticia);
        Task Delete(int noticiaId);
    }