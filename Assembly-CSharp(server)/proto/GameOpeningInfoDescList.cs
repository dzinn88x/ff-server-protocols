using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A07 RID: 2567
	[Token(Token = "0x2000A07")]
	[ProtoContract]
	public class GameOpeningInfoDescList
	{
		// Token: 0x06002711 RID: 10001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x21BA87C", Offset = "0x21BA87C", VA = "0x7BBC9BA87C")]
		public GameOpeningInfoDescList()
		{
		}

		// Token: 0x04002EEF RID: 12015
		[Token(Token = "0x4002EEF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E4EC", Offset = "0x111E4EC")]
		public List<GameOpeningInfoDesc> gameOpeningInfos;
	}
}
