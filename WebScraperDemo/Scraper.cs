using HtmlAgilityPack;

public class Scraper
{
    private string BaseUrl = "https://www.otomoto.pl/osobowe/bmw/seria-3";

    public void GetCars()
    {
        var web = new HtmlWeb();
        var doc = web.Load(BaseUrl);
        var main = doc.QuerySelector("main");
        var articles = main.QuerySelectorAll("article:not(article article)");
        
        Console.WriteLine("-----------------------------------------------------------------");
        foreach(var article in articles)
        {
            
            if(article.QuerySelector("dd") != null)
            {
                var innerArticle = article.QuerySelectorAll("dd");
                foreach(var dataParameter in innerArticle)
                {
                    Console.WriteLine(dataParameter.InnerText);
                }
                
                
                
            }
            
        }
        Console.WriteLine("-----------------------------------------------------------------");
    }
}