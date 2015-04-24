﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterNET.ARI.Proxy.Providers.RabbitMQ
{
	public class RabbitMqBackendConfig
	{
		public string AmqpUri { get; set; }
		public bool AutoDelete { get; set; }
		public bool Exclusive { get; set; }
		public bool Durable { get; set; }
		public int Heartbeat { get; set; }

		public static RabbitMqBackendConfig Create(dynamic config)
		{
			return new RabbitMqBackendConfig()
			{
				AmqpUri = config.AmqpUri,
				AutoDelete = config.AutoDelete,
				Durable = config.Durable,
				Exclusive = config.Exclusive,
				Heartbeat = config.Heartbeat
			};
		}
    }
}
