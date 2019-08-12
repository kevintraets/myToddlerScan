using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class ScanService : IScanService
    {
        public void addScan(Scan scan)
        {
            MockAPI.MockAPI.addScan(scan);
        }
    }
}
