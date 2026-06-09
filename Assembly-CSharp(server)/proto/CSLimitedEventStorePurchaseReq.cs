using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000955 RID: 2389
	[Token(Token = "0x2000955")]
	[ProtoContract]
	public class CSLimitedEventStorePurchaseReq
	{
		// Token: 0x06002663 RID: 9827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x21B6798", Offset = "0x21B6798", VA = "0x7BBC9B6798")]
		public CSLimitedEventStorePurchaseReq()
		{
		}

		// Token: 0x04002BCD RID: 11213
		[Token(Token = "0x4002BCD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111930C", Offset = "0x111930C")]
		public uint event_id;

		// Token: 0x04002BCE RID: 11214
		[Token(Token = "0x4002BCE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119320", Offset = "0x1119320")]
		public uint store_id;

		// Token: 0x04002BCF RID: 11215
		[Token(Token = "0x4002BCF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119334", Offset = "0x1119334")]
		public uint sku_id;

		// Token: 0x04002BD0 RID: 11216
		[Token(Token = "0x4002BD0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119348", Offset = "0x1119348")]
		public uint cnt;

		// Token: 0x04002BD1 RID: 11217
		[Token(Token = "0x4002BD1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111935C", Offset = "0x111935C")]
		public uint currency_id;

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119370", Offset = "0x1119370")]
		public uint currency_price;
	}
}
