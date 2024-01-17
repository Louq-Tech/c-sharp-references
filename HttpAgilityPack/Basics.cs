using HtmlAgilityPack;

namespace Webscraping
{
    class Scraping
    {
        static async Task Main(string[] args)
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://www.w3schools.com/cs/index.php");

            var titleNode = doc.DocumentNode.SelectSingleNode("//title");
            var title = titleNode.InnerText;
            Console.WriteLine(title);

            var paragraphNode = doc.DocumentNode.SelectNodes("//p");
            
            foreach( var paragraph in paragraphNode )
            {
                var myP = paragraph.InnerText;
                Console.WriteLine(myP);
            }
        }
    }
}
