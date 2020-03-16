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
                Title = "SignalR",
                Body = "I did SignalR",
                URL = "https://google.com/",
                Tags = new string[]
                {
                    "SignalR",
                    "Blazor"
                },
            },
            new CardData()
            {
                Title = "SignalR",
                Body = "I did SignalR",
                URL = "https://google.com/",
                Tags = new string[]
                {
                    "SignalR",
                    "Blazor"
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