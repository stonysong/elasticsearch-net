﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Nest.Resolvers.Converters;
using System.Linq.Expressions;
using Nest.Resolvers;

namespace Nest
{

	public class NodeIdOptionalDescriptor<P, K>
		where P : NodeIdOptionalDescriptor<P, K> 
		where K : FluentQueryString<K>, new()
	{
		internal string _NodeId { get; set; }

		/// <summary>
		/// Specify the {name} part of the operation
		/// </summary>
		public P NodeId(string nodeId)
		{
			this._NodeId = nodeId;
			return (P)this;
		}

		internal virtual ElasticSearchPathInfo<K> ToPathInfo<K>(IConnectionSettings settings)
			where K : FluentQueryString<K>, new()
		{
			var pathInfo = new ElasticSearchPathInfo<K>()
			{
				NodeId = this._NodeId
			};
			pathInfo.QueryString = new K();
			return pathInfo;
		}

	}
}
