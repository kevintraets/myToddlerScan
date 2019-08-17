using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface IScanService
    {
        //Next are methods that are used if the MockAPI is still active
        void addScan(Scan scan);
        List<Scan> allScans();

        //Next are methods that need to be implemented if a real API exists
        /*
         * Task<Scan> addScan (Scan scan);
         * Task<IEnumerable<Scan>> allScans;
         * 
         */
    }
}
