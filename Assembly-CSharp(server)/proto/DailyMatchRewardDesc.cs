using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A52 RID: 2642
	[Token(Token = "0x2000A52")]
	[ProtoContract]
	public class DailyMatchRewardDesc
	{
		// Token: 0x0600275C RID: 10076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275C")]
		[Address(RVA = "0x21B9458", Offset = "0x21B9458", VA = "0x7BBC9B9458")]
		public DailyMatchRewardDesc()
		{
		}

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B20", Offset = "0x1120B20")]
		public uint config_id;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B34", Offset = "0x1120B34")]
		public uint condition_value;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B48", Offset = "0x1120B48")]
		public uint reward_amount;
	}
}
