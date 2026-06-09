using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F0 RID: 1520
	[Token(Token = "0x20005F0")]
	[ProtoContract]
	public class MessageNotifySlice
	{
		// Token: 0x06002370 RID: 9072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x21BCAFC", Offset = "0x21BCAFC", VA = "0x7BBC9BCAFC")]
		public MessageNotifySlice()
		{
		}

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106AF4", Offset = "0x1106AF4")]
		public List<MessageNotify> msgs;
	}
}
