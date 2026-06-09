using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008FA RID: 2298
	[Token(Token = "0x20008FA")]
	[ProtoContract]
	public class CSTeamIDReq
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002608")]
		[Address(RVA = "0x21B7828", Offset = "0x21B7828", VA = "0x7BBC9B7828")]
		public CSTeamIDReq()
		{
		}

		// Token: 0x04002ABB RID: 10939
		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117890", Offset = "0x1117890")]
		public ulong team_id;
	}
}
