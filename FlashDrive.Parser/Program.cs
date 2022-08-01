using HtmlAgilityPack;

var html = @"https://catalog.onliner.by/usbflash/";
HtmlWeb web = new HtmlWeb();
var htmlDoc = web.Load(html);
var nodes = htmlDoc.DocumentNode.SelectNodes("//a[@class='model']");
if (nodes is not null)
{
    foreach (HtmlNode item in nodes)
    {
        Console.WriteLine(item.InnerText);
    }
}