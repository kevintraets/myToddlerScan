using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class ScanService : IScanService
    {

        //Next are the implementations of the MockApi, delete methods when the API exists.
        public void addScan(Scan scan)
        {
            MockAPI.MockAPI.addScan(scan);
        }

        public List<Scan> allScans()
        {
            return MockAPI.MockAPI.getAllScans();
        }

        //Next are the implementations if a real API exists.
        /* 
         * private IGenericRepository _genericRepository;
         * public ScanService(IGenericRepository genericRepository)
         * {
         *      _genericRepository = genericRepository;
         * }
         * 
         * public async Task<IEnumberable<Scan>> allScans()
         * {
         *      UriBuilder builder = new UriBuilder (ApiConstants.BaseApiUrl)
         *      {
         *          Path = ApiConstants.Scan;
         *      };
         *      var scans = await _genericRepository.GetAsync<List<Scan>>(builder.ToString());
         *      return scans;
         * }
         * 
         * public async Task<Scan> addScan(Scan scan)
         * {
         *      UriBuilder builder = new UriBuilder (ApiConstants.BaseApiUrl)
         *      {
         *          Path = ApiConstants.Scan;
         *      };
         *      var scanToPost = await _genericRepository.PostAsync(builder.ToString(), scan);
         *      return scanToPost;
         * }
         */
    }


}
