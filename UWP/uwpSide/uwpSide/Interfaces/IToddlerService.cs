using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Models;

namespace uwpSide.Interfaces
{
    public interface IToddlerService
    {
        //Next methods are used if the MockAPI is still active.
        IEnumerable<Toddler> getAllToddlers();
        void addToddler(Toddler toddler);

        //Next are methods that need to be implemented when a real API exists.
        /*
         * Task<IEnumerable<Toddler>> getAllToddlers();
         * Task<Toddler> addToddler(Toddler toddler);
         */
    }
}
