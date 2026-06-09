using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200093F RID: 2367
	[Token(Token = "0x200093F")]
	[ProtoContract]
	public class CSGetAccountSubscriptionsRes
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x21B17EC", Offset = "0x21B17EC", VA = "0x7BBC9B17EC")]
		public CSGetAccountSubscriptionsRes()
		{
		}

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118EAC", Offset = "0x1118EAC")]
		public List<AccountSubscription> subscriptions;
	}
}
