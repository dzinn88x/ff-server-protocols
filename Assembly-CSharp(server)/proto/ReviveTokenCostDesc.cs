using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD7 RID: 2775
	[Token(Token = "0x2000AD7")]
	[ProtoContract]
	public class ReviveTokenCostDesc
	{
		// Token: 0x060027DF RID: 10207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x24A01EC", Offset = "0x24A01EC", VA = "0x7BBCCA01EC")]
		public ReviveTokenCostDesc()
		{
		}

		// Token: 0x04003420 RID: 13344
		[Token(Token = "0x4003420")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127CF4", Offset = "0x1127CF4")]
		public uint gem_cost_self;

		// Token: 0x04003421 RID: 13345
		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127D08", Offset = "0x1127D08")]
		public uint gem_cost_teammate;

		// Token: 0x04003422 RID: 13346
		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127D1C", Offset = "0x1127D1C")]
		public uint gem_cost_wiped;
	}
}
