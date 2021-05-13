﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.PubSubEvent
{
    public interface ITransientDomainEventPublisher
    {
        Task PublishAsync<T>(T publishedEvent);
    }
}
