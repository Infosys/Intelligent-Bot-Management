/****************************************************************
Copyright 2021 Infosys Ltd. 
Use of this source code is governed by Apache License Version 2.0 that can be found in the LICENSE file or at 
http://www.apache.org/licenses/
 ***************************************************************/

using System;
using System.Runtime.Serialization;

namespace Infosys.Lif.LegacyCommon
{
	[Serializable]
	public sealed class LegacyException:Exception
	{
		public LegacyException() : base() 
		{
		}
		public LegacyException(string message) : base(message) 
		{
		}
		public LegacyException(string message, Exception exception) : 
			base(message, exception) 
		{
		}
		private LegacyException(SerializationInfo info, StreamingContext context)
			:base(info, context) 
		{
		}
	}
    [Serializable]
    public sealed class QueueNotRespondedException : Exception
    {
        public QueueNotRespondedException() : base()
        {
        }
        public QueueNotRespondedException(string message) : base(message)
        {
        }
        public QueueNotRespondedException(string message, Exception exception) :
            base(message, exception)
        {
        }
        private QueueNotRespondedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
