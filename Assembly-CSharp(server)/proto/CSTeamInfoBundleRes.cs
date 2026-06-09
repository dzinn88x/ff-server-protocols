using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F8 RID: 2296
	[Token(Token = "0x20008F8")]
	[ProtoContract]
	public class CSTeamInfoBundleRes
	{
		// Token: 0x06002606 RID: 9734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002606")]
		[Address(RVA = "0x21B7838", Offset = "0x21B7838", VA = "0x7BBC9B7838")]
		public CSTeamInfoBundleRes()
		{
		}

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117854", Offset = "0x1117854")]
		public List<TeamInfo> infos;
	}
}
