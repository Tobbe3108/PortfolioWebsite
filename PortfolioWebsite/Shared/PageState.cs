using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioWebsite.Shared
{
    public class PageState
    {
        public bool FirstLoad { get; set; } = false;

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