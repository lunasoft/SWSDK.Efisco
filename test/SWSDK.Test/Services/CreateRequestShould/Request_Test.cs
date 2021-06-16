using System;
using SW.Entities.CreateRequest;
using SW.Services.CreateRequest;
using SWSDK.Test.Helpers;
using Xunit;

namespace SWSDK.Test.Services.RequestShould
{
    public class Request_Test
    {        
        [Fact]
        public async void Test1()
        {
            CreateRequest createRequest = new CreateRequest(Settings.Url, Settings.Token);
            RequestEntity entity = new RequestEntity()
            {
                documentType = SW.Enums.DocumentType.Emision,
                taxId = "EKU9003173C9",
                endDate = DateTime.Now,
                startDate = DateTime.Now,
                generatePDF =  false
            };

            var result = await createRequest.CreateWebPortalRequestAsync(entity);
            
            Assert.Contains("success", result.status);
        }

        [Fact(Skip = "El servicio del SAT regreso una respuesta no exitosa , no acepto la solicitud de descarga. Codigo: 305 Mensaje:Certificado Inválido" + "CSD de test")]
        public async void Test2()
        {
            CreateRequest createRequest = new CreateRequest(Settings.Url, Settings.Token);
            RequestEntity entity = new RequestEntity()
            {
                documentType = SW.Enums.DocumentType.Emision,
                taxId = "EKU9003173C9",
                endDate = DateTime.Now,
                startDate = DateTime.Now,
                generatePDF =  false
            };

            var result = await createRequest.CreateWebServiceRequestAsync(entity);
            
            Assert.Contains("success", result.status);
        }

        [Fact(Skip = "El servicio del SAT regreso una respuesta no exitosa , no acepto la solicitud de descarga. Codigo: 305 Mensaje:Certificado Inválido" + "CSD de test")]
        public async void Test3()
        {
            CreateRequest createRequest = new CreateRequest(Settings.Url, Settings.Token);
            RequestEntity entity = new RequestEntity()
            {
                documentType = SW.Enums.DocumentType.Emision,
                taxId = "EKU9003173C9",
                endDate = DateTime.Now,
                startDate = DateTime.Now,
                generatePDF =  false
            };

            var result = await createRequest.CreateMetadataAsync(entity);
            
            Assert.Contains("success", result.status);
        }

        [Fact]
        public async void Test4()
        {
            CreateRequest createRequest = new CreateRequest(Settings.Url, Settings.Token);
            SchedureEntity entity = new SchedureEntity()
            {
                Active = true,
                Schedule = new TimeSpan(),
                DocumentType = SW.Enums.DocumentType.Emision,
                TaxId = "EKU9003173C9",
                LapseDays = 1,
                ProcessType = 2,
                FrecuencyInDays = 1
            };

            var result = await createRequest.CreateSchedulerAsync(entity);
            
            Assert.Contains("success", result.status);
        }
    }
}
