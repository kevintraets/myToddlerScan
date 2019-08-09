using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Interfaces;
using uwpSide.Models;

namespace uwpSide.Services
{
    public class ToddlerService : IToddlerService
    {
        public IEnumerable<Toddler> getAllToddlers()
        {
            return MockAPI.MockAPI.GetAllToddlersMock();
        }

        public void addToddler(Toddler toddler)
        {
            MockAPI.MockAPI.addToddler(toddler);
        }
    }
}
