using System;

namespace YandexCloudDotNet.ObjectStorage
{
    public interface IObjectStorageClient: IDisposable
    {
        IBucketClient Bucket { get; }
        IObjectClient Object { get; }
    }
}
