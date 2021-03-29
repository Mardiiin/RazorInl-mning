ASP.NET-CORE förklaring på startup.cs, wwwroot, razor språket, Content Page, Page Model samt skillnaden mellan model, view och controller.

Det som sker i startup.cs är kod vars function är att bestämma hur själva webbapplicationen skall fungera. Startup.cs är ingångspunkten av webbapplicationen. Filen innehåller en startup klass som sätts igång när man startar webbapplicationen samt i varje HTTP request och svar. Startup.cs hanterar alla requests som skickas till applicationen.

Wwwroot är en mapp som innehåller alla statiska filer i projektet. Filer som sätts i mappen inkluderar HTML filer, CSS filer, bild filer, och JavaScript filer. Namnet säger sig självt, wwwroot mappen är roten till webbsidan.

Razor är en markeringssyntax vars funktion låter en bädda in serverbaserad kod (C# och Visual Basic) in till webbsidan. Med razor får man möjligheten att skapa dynamiskt webbinnehåll i farten. När man kallar på en webbsida så körs den server baserade koden inuti själva hemsidan innan den returneras till webbläsaren. Med detta kan man få tillgång till databaser och utföra komplicerade uppgifter (genom att köra på servern).

Content Page är en sida som är ansluten till en Master Page. Alla Master Pages har en eller mer Content Pages i en application. I en Content Page innehåller det enbart markup samt controls inuti Content Controls. Den kan inte ha någon högre level av innehåll av sig själv. Det man kan göra är att ställa in controls som specifikt överskrider platshållare i en 

Content Page i olika sektioner av Master Page.
Page Model är till för att skapa en tydlig separation mellan .cshtml view filen samt få fram själva logiken av sidan och använder det för att referera till sidelement (page elements).

Skillnaden mellan model view och controller är att -  model är själva datan, view är 'the table view' alltså hämtar data från Model och är det användaren ser. Controller är the UITableViewController eller gränssnittet mellan Model och View komponenter. View skickar meddelanden till controller för att ta tag i en ny händelse och kan då uppdatera Model.
