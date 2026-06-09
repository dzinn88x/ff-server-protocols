using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	[ProtoContract]
	public class CSTopupEventInfoRes
	{
		// Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x21B7A9C", Offset = "0x21B7A9C", VA = "0x7BBC9B7A9C")]
		public CSTopupEventInfoRes()
		{
		}

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E27C", Offset = "0x110E27C")]
		public MysteryBonusInfo mystery_bonus;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E290", Offset = "0x110E290")]
		public DiamondSpendEventInfo diamond_spend_event;
	}
}
