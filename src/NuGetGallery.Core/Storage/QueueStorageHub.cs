﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.Storage.Queue;

namespace NuGetGallery.Storage
{
    public class QueueStorageHub
    {
        public CloudQueueClient Client { get; private set; }

        public QueueStorageHub(CloudQueueClient client)
        {
            Client = client;
        }
    }
}
