using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	[ProtoContract]
	public class RebateCardDesc
	{
		// Token: 0x06002794 RID: 10132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002794")]
		[Address(RVA = "0x249FC0C", Offset = "0x249FC0C", VA = "0x7BBCC9FC0C")]
		public RebateCardDesc()
		{
		}

		// Token: 0x040031B0 RID: 12720
		[Token(Token = "0x40031B0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112335C", Offset = "0x112335C")]
		public uint rebate_id;

		// Token: 0x040031B1 RID: 12721
		[Token(Token = "0x40031B1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123370", Offset = "0x1123370")]
		public uint subscription_bonus;
	}
}
