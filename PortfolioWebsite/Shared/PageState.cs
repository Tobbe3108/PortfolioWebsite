using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioWebsite.Shared
{
    public class PageState
    {
        public List<CardData> CardDataList { get; private set; } = new List<CardData>()
        {
            new CardData()
            {
                Title = "Single-page applications",
                Preview = "Jeg har igennem en længere periode beskæftiget mig med Single-page applications via flere forskellige frameworks.",
                Body = "Vi har i skoen haft et forløb omkring Blazor, dette forløb indeholdt basal undervisning men selvstudie fik mig dybere ned i frameworket og jeg har blandt andet lavet denne side ved hjælp af Blazor. Jeg her derudover tidligere arbejdet med Svelte, Vue og React da jeg synes det var spændende at lære lidt omkring deres ligheder og forskelligheder.",
                URL = new Dictionary<string, string>(){ { "Blazor kode","https://github.com/Tobbe3108/PortfolioWebsite" } },
                Tags = new string[]
                {
                    "Blazor",
                    "Svelte",
                    "Vue",
                    "React"
                },
            },
            new CardData()
            {
                Title = ".NET Core",
                Preview = "Vi har gennem hele min uddannelse arbejdet med dele af Microsoft Technology Stack.",
                Body = "Vi begyndte i de tidlige semestre med at udvikle i .net framework med en WinForms frontend. Vi er senere gået over til .Net Core og ASP.NET Core og senest har vi påbegyndt et stort klasse projekt med Xamarin som muligvis bliver sat i produktion hos Plantorama.",
                URL = new Dictionary<string, string>(){ { "ASP.NET Core kode", "https://github.com/Tobbe3108/PatchPanic" }, { "WinForms kode", "https://github.com/Tobbe3108/ProjektRepo" } },
                Tags = new string[]
                {
                    "ASP.NET Core",
                    "Xamarin",
                    ".Net Core",
                    "WinForms"
                },
            },
            new CardData()
            {
                Title = ".Net Packages",
                Preview = "Jeg har benyttet flere forskellige NuGet Packages for eksempel til at hjælpe under udviklingen af større projekter.",
                Body = "Jeg har på det seneste forsøgt at sætte mig ind i Real-time communication og mere specifikt SignalR og har også inkorporer denne teknologi i flere projekter. I tidligere projekter, for eksempel mit sidste eksamensprojekt, benyttede jeg Entity Framework Core, Autofac (til DI) og AutoMapper. Beslutningen om at benytte disse teknologier blev taget efter grundige overvejelser i min arbejdsgruppe. Vi endte ud med at tage beslutningen efter en analysering af hvad vi ville få ud af benytte teknologierne og hvad vi ville miste ved at bruge dem.",
                URL = new Dictionary<string, string>(){ { "SignalR kode", "https://github.com/Tobbe3108/BlazorTourOfHeroes" }, { "EF Core, AutoFac og AutoMapper kode", "https://github.com/Tobbe3108/PatchPanic" } },
                Tags = new string[]
                {
                    "SignalR",
                    "EF Core",
                    "AutoFac",
                    "AutoMapper"
                },
            },
            new CardData()
            {
                Title = "Cloud",
                Preview = "Jeg har blandt andet prøvet at leje med Serverless Architecture og Function as a Service. (FaaS)",
                Body = "Jeg har arbejdet med FaaS via MongoDB Stitch og inkorporere det i en web-app jeg udviklede for min far på det tidspunkt. Alt application logic samt QRUD-operationer blev lavet som Serverless Functions oppe på Stitch platformen. Derudover har jeg også haft adgang til Azure for students gennem hele uddannelsen og har benyttet platformen i mange forskellige situationer blandt andet til CI-CD samt hoasting.",
                URL = new Dictionary<string, string>(){ { "FaaS kode", "https://github.com/Tobbe3108/Sortable.js-Test" } },
                Tags = new string[]
                {
                    "FaaS",
                    "Azure",
                    "CI-CD",
                    "MongoDB Stitch"
                },
            },
            new CardData()
            {
                Title = "Arkitektur",
                Preview = "Jeg har arbejdet med flere forskellige system arkitekturer blandt andet N-tier architecture og Distributed Architecture.",
                Body = "Jeg har arbejdet med disse arkitekture igennem de større projekter jeg har udarbejdet i forbindelse med mit studie. Ud over disse er vi lige gået igang med undervisning omkring Microservices, og jeg er selv startet på et par kurser omkring emnet.",
                URL = new Dictionary<string, string>(){ { "", "" } },
                Tags = new string[]
                {
                    "Microservices",
                    "N-tier architecture",
                    "Distributed Architecture"
                },
            },
            new CardData()
            {
                Title = "Uddannelse",
                Preview = "- Folkeskole Dagnæsskolen Horsens 2003-2013<br /> - Step 10 Learnmark Horsens 2013-2014<br /> - HTX Learnmark Horsens 2014-2017<br /> - Datamatiker Ucl Vejle 2018-I dag",
                Tags = new string[]
                {
                    "Folkeskole",
                    "10. klasse",
                    "HTX",
                    "Datamatiker"
                },
            }
        };

        public class Manager
        {
            private readonly PageState _State;

            public Manager(PageState state)
            {
                _State = state;
            }

            public event Action OnStateChanged;
        }
    }
}