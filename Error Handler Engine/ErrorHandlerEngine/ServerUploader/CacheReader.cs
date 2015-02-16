﻿
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using ErrorHandlerEngine.CacheHandledErrors;
using ErrorHandlerEngine.ExceptionManager;
using ErrorHandlerEngine.ModelObjecting;
using Newtonsoft.Json;

namespace ErrorHandlerEngine.ServerUploader
{
    public static class CacheReader
    {
        public static ErrorUniqueCollection ErrorHistory = new ErrorUniqueCollection();


        #region Read Cache to Error History

        /// <summary>
        /// Read cache and fill ErrorHistory array
        /// </summary>
        /// <param name="router"></param>
        public static async void ReadCacheToHistory(this RoutingDataStoragePath router)
        {
            var errors = await ReadLogToErros(router);
            //
            // Read any error in errors array to sent it to ServerUploader
            ErrorHistory.AddRange(errors);
        }

        #endregion




        public static async void ReadCacheToServerUploader()
        {
            await Task.Run(async () =>
            {
                foreach (var error in ErrorHistory)
                {
                    await Kernel.Instance.Uploader.ErrorListenerTransformBlock.SendAsync(new LazyError(error));
                }
            });

        }

        #region Error Read from Json Log file

        public static async Task<Error[]> ReadLogToErros(RoutingDataStoragePath router)
        {
            Kernel.IsSelfException = true;
            try
            {
                //
                // Read Error Log Json File
                var allJsonString = await router.ReadTextAsync();
                //
                // Check file is not empty ?
                if (String.IsNullOrEmpty(allJsonString)) return null;

                //
                // Convert json string to Error array's.
                return await JsonConvert.DeserializeObjectAsync<Error[]>(allJsonString);
            }
            finally
            {
                Kernel.IsSelfException = false;
            }

        }
        #endregion
    }
}