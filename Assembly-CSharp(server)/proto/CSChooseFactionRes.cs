using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200095E RID: 2398
	[Token(Token = "0x200095E")]
	[ProtoContract]
	public class CSChooseFactionRes
	{
		// Token: 0x0600266C RID: 9836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x21B0668", Offset = "0x21B0668", VA = "0x7BBC9B0668")]
		public CSChooseFactionRes()
		{
		}

		// Token: 0x04002BE0 RID: 11232
		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119488", Offset = "0x1119488")]
		public ulong account_id;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111949C", Offset = "0x111949C")]
		public ELimitedEvent.RampageFaction faction;
	}
}
