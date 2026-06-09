using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F92 RID: 3986
	[Token(Token = "0x2000F92")]
	public class NetworkMessageHandlerPair
	{
		// Token: 0x06003A0A RID: 14858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0A")]
		[Address(RVA = "0x246791C", Offset = "0x246791C", VA = "0x7BBCC6791C")]
		public NetworkMessageHandlerPair()
		{
		}

		// Token: 0x04004BA0 RID: 19360
		[Token(Token = "0x4004BA0")]
		[FieldOffset(Offset = "0x10")]
		public List<Delegate> CallBacks;

		// Token: 0x04004BA1 RID: 19361
		[Token(Token = "0x4004BA1")]
		[FieldOffset(Offset = "0x18")]
		public Type MsgType;
	}
}
