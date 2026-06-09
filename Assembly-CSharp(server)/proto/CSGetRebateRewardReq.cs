using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	[ProtoContract]
	public class CSGetRebateRewardReq
	{
		// Token: 0x060024D4 RID: 9428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D4")]
		[Address(RVA = "0x21B583C", Offset = "0x21B583C", VA = "0x7BBC9B583C")]
		public CSGetRebateRewardReq()
		{
		}

		// Token: 0x04002613 RID: 9747
		[Token(Token = "0x4002613")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F050", Offset = "0x110F050")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F050", Offset = "0x110F050")]
		public string login_token;

		// Token: 0x04002614 RID: 9748
		[Token(Token = "0x4002614")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F0A0", Offset = "0x110F0A0")]
		public uint[] rebate_card_ids;
	}
}
