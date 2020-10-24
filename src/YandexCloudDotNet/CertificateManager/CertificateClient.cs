using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Yandex.Cloud.Certificatemanager.V1;
using ChallengeType = YandexCloudDotNet.CertificateManager.DTO.ChallengeType;

namespace YandexCloudDotNet.CertificateManager
{
    public class CertificateClient: ICertificateClient
    {
        public async Task RequestNew(string folderId,
                                     string name,
                                     string description,
                                     Dictionary<string, string> labels,
                                     string[] domains,
                                     ChallengeType challengeType)
        {
            var channel = new Channel("certificate-manager.api.cloud.yandex.net", 443, new SslCredentials());
            var client = new CertificateService.CertificateServiceClient(channel);
            var request = new RequestNewCertificateRequest
                          {
                              Description = description,
                              ChallengeType = ConvertChallengeType(challengeType),
                              FolderId = folderId,
                              Name = name
                          };
            request.Domains.AddRange(domains);
            request.Labels.Add(labels);

            var response = await client.RequestNewAsync(request);
        }

        private Yandex.Cloud.Certificatemanager.V1.ChallengeType ConvertChallengeType(ChallengeType challengeType)
        {
            return challengeType switch
            {
                ChallengeType.Dns => Yandex.Cloud.Certificatemanager.V1.ChallengeType.Dns,
                ChallengeType.Http => Yandex.Cloud.Certificatemanager.V1.ChallengeType.Http,
                _ => throw new Exception()
            };
        }
    }
}
