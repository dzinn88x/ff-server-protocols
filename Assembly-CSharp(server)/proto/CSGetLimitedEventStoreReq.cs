using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200094C RID: 2380
	[Token(Token = "0x200094C")]
	[ProtoContract]
	public class CSGetLimitedEventStoreReq
	{
		// Token: 0x0600265A RID: 9818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x21B4554", Offset = "0x21B4554", VA = "0x7BBC9B4554")]
		public CSGetLimitedEventStoreReq()
		{
		}

		// Token: 0x04002BBD RID: 11197
		[Token(Token = "0x4002BBD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119168", Offset = "0x1119168")]
		public uint event_id;

		// Token: 0x04002BBE RID: 11198
		[Token(Token = "0x4002BBE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111917C", Offset = "0x111917C")]
		public uint store_type;
	}
}
