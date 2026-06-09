using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	[ProtoContract]
	public class RankAwardsDesc
	{
		// Token: 0x0600277E RID: 10110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x249F918", Offset = "0x249F918", VA = "0x7BBCC9F918")]
		public RankAwardsDesc()
		{
		}

		// Token: 0x04003104 RID: 12548
		[Token(Token = "0x4003104")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11221F0", Offset = "0x11221F0")]
		public uint rank;

		// Token: 0x04003105 RID: 12549
		[Token(Token = "0x4003105")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122204", Offset = "0x1122204")]
		public List<AwardDesc> level_awards;

		// Token: 0x04003106 RID: 12550
		[Token(Token = "0x4003106")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122218", Offset = "0x1122218")]
		public List<AwardDesc> season_awards;
	}
}
