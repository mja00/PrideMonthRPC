using DiscordRPC;
var now = DateTime.Now;
var midnightLocal = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0, DateTimeKind.Local);

Console.WriteLine("Choose your flag shown: 1 - lesbian, 2 - trans, anything else - legtq");
string input = Console.ReadLine();
string pic = "";
string pictext = "";

switch (input)
{
    case "1":
        pic = "lesbianflag";
        pictext = "Lesbian";
        break;
    case "2":
        pic = "transflag";
        pictext = "Transgender";
        break;
    default:
        pic = "lgbtqflag";
        pictext = "LGBTQ";
        break;
}

var client = new DiscordRpcClient("1510964108432769114");

client.Initialize();
client.SetPresence(new RichPresence()
{
    Details = "You're Valid!",
    State = "meow",
    Assets = new Assets
    {
        LargeImageKey = pic,
        LargeImageText = pictext
    },
    Timestamps = new Timestamps
    {
        Start = midnightLocal.ToUniversalTime()
    },
    Buttons = new Button[]
    {
        new Button() { Label = "github", Url = "https://github.com/BunnyGirlElysia/PrideMonthRPC" }
    }
});

Console.ReadLine();
client.Dispose();