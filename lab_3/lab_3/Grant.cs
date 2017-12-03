using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Grant
    {
        private IState _state;

        public CreateState CreateState { get; private set; }
        public ConsiderState ConsiderState { get; private set; }

        public Grant()
        {
            CreateState = new CreateState(this);
            ConsiderState = new ConsiderState(this);
       
            _state = CreateState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void CreateGrant()
        {
            _state.Create();
        }

        public void ConsiderGrant()
        {
            _state.Consider();
        }
        
    }
}
