using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	[ProtoContract]
	public class RaceAwardExchange
	{
		// Token: 0x06002500 RID: 9472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002500")]
		[Address(RVA = "0x249F7C8", Offset = "0x249F7C8", VA = "0x7BBCC9F7C8")]
		public RaceAwardExchange()
		{
		}

		// Token: 0x040026A4 RID: 9892
		[Token(Token = "0x40026A4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110220", Offset = "0x1110220")]
		public ulong account_id;

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110234", Offset = "0x1110234")]
		public uint stage;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110248", Offset = "0x1110248")]
		public ulong exchange_at;
	}
}
