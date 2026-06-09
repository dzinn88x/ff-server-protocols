using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200091F RID: 2335
	[Token(Token = "0x200091F")]
	[ProtoContract]
	public class TeamChampionshipInfoBundleRes
	{
		// Token: 0x0600262D RID: 9773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x24A0D18", Offset = "0x24A0D18", VA = "0x7BBCCA0D18")]
		public TeamChampionshipInfoBundleRes()
		{
		}

		// Token: 0x04002B54 RID: 11092
		[Token(Token = "0x4002B54")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111877C", Offset = "0x111877C")]
		public List<TeamChampionshipInfo> infos;
	}
}
