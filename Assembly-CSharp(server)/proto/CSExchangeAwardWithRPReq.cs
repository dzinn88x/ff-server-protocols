using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E9 RID: 2025
	[Token(Token = "0x20007E9")]
	[ProtoContract]
	public class CSExchangeAwardWithRPReq
	{
		// Token: 0x060024F8 RID: 9464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x21B11F4", Offset = "0x21B11F4", VA = "0x7BBC9B11F4")]
		public CSExchangeAwardWithRPReq()
		{
		}

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FFF0", Offset = "0x110FFF0")]
		public ulong clan_id;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110004", Offset = "0x1110004")]
		public uint stage;
	}
}
