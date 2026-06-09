using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB4 RID: 2740
	[Token(Token = "0x2000AB4")]
	[ProtoContract]
	public class PayLevelRewardDesc
	{
		// Token: 0x060027BE RID: 10174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x249F0C0", Offset = "0x249F0C0", VA = "0x7BBCC9F0C0")]
		public PayLevelRewardDesc()
		{
		}

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126E08", Offset = "0x1126E08")]
		public uint id;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126E1C", Offset = "0x1126E1C")]
		public uint level;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126E30", Offset = "0x1126E30")]
		public EStore.PayLevelRewardHintType hint;

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126E44", Offset = "0x1126E44")]
		public List<AwardDesc> awards;
	}
}
