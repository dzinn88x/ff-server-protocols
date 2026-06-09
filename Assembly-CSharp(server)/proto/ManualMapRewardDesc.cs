using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ADE RID: 2782
	[Token(Token = "0x2000ADE")]
	[ProtoContract]
	public class ManualMapRewardDesc
	{
		// Token: 0x060027E6 RID: 10214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x21BC404", Offset = "0x21BC404", VA = "0x7BBC9BC404")]
		public ManualMapRewardDesc()
		{
		}

		// Token: 0x0400343A RID: 13370
		[Token(Token = "0x400343A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128154", Offset = "0x1128154")]
		public uint map_id;

		// Token: 0x0400343B RID: 13371
		[Token(Token = "0x400343B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128168", Offset = "0x1128168")]
		public List<AwardDesc> awards;
	}
}
