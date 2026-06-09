using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C1 RID: 2241
	[Token(Token = "0x20008C1")]
	[ProtoContract]
	public class ExchangeStore
	{
		// Token: 0x060025CF RID: 9679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CF")]
		[Address(RVA = "0x21B9E04", Offset = "0x21B9E04", VA = "0x7BBC9B9E04")]
		public ExchangeStore()
		{
		}

		// Token: 0x04002A1B RID: 10779
		[Token(Token = "0x4002A1B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11166D4", Offset = "0x11166D4")]
		public ExchangeStoreDesc exchange_store_desc;

		// Token: 0x04002A1C RID: 10780
		[Token(Token = "0x4002A1C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11166E8", Offset = "0x11166E8")]
		public List<ExchangeStoreItemDesc> exchange_store_items;
	}
}
