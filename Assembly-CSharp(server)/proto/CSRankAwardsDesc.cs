using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B04 RID: 2820
	[Token(Token = "0x2000B04")]
	[ProtoContract]
	public class CSRankAwardsDesc
	{
		// Token: 0x0600280C RID: 10252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x21B7018", Offset = "0x21B7018", VA = "0x7BBC9B7018")]
		public CSRankAwardsDesc()
		{
		}

		// Token: 0x04003534 RID: 13620
		[Token(Token = "0x4003534")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A238", Offset = "0x112A238")]
		public uint rank;

		// Token: 0x04003535 RID: 13621
		[Token(Token = "0x4003535")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A24C", Offset = "0x112A24C")]
		public List<AwardDesc> level_awards;

		// Token: 0x04003536 RID: 13622
		[Token(Token = "0x4003536")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A260", Offset = "0x112A260")]
		public List<AwardDesc> season_awards;
	}
}
