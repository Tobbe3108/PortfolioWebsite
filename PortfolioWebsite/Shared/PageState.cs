using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioWebsite.Shared
{
    public class PageState
    {
        public bool FirstLoad { get; private set; } = false;

        public List<CardData> CardDataList { get; private set; } = new List<CardData>()
        {
            new CardData()
            {
                Title = "Single-page applications",
                Body = "Jeg har igennem en længere periode beskæftiget mig med Single-page applications via flere forskellige frameworks. Vi har i skoen haft et forløb omkring Blazor, dette forløb indeholdt basal undervisning men selvstudie fik mig dybere ned i frameworket og jeg har blandt andet lavet denne side ved hjælp af Blazor. Jeg her derudover tidligere arbejdet med Svelte, Vue og React da jeg synes det var spændende at lære lidt omkring deres ligheder og forskelligheder.",
                URL = "https://github.com/Tobbe3108/PortfolioWebsite",
                Tags = new string[]
                {
                    "Blazor",
                    "Svelte",
                    "Vue",
                    "React"
                },
            },
        };

        public class Manager
        {
            private readonly PageState _State;

            public Manager(PageState state)
            {
                _State = state;
            }

            public void SetFirstLoad(bool state)
            {
                _State.FirstLoad = state;
                OnStateChanged?.Invoke();
            }

            public event Action OnStateChanged;
        }
    }
}