using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace BlazorApp.Api
{
    public static class DocumentProcessing
    {
        [FunctionName("DocumentProcessing")]
        public static void Run([BlobTrigger("dropfolder/{name}", Connection = "dropfolderconnection")]Stream blob, 
                               string name, 
                               ILogger log)
        {
            log.LogInformation($"Processed blob\n Name:{name} \n Size: {blob.Length} Bytes");

            //switch (Path.GetExtension(name))
            //{
            //    case ".jpg":
            //        {

            //            break;
            //        }
            //    default:
            //        break;
            //}
        }
    }
}
