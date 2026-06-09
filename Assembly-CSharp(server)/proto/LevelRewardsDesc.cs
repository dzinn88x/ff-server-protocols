using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A5B RID: 2651
	[Token(Token = "0x2000A5B")]
	[ProtoContract]
	public class LevelRewardsDesc
	{
		// Token: 0x06002765 RID: 10085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x21BB95C", Offset = "0x21BB95C", VA = "0x7BBC9BB95C")]
		public LevelRewardsDesc()
		{
		}

		// Token: 0x0400307A RID: 12410
		[Token(Token = "0x400307A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121228", Offset = "0x1121228")]
		public uint target_level;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112123C", Offset = "0x112123C")]
		public List<AwardDesc> awards;
	}
}
