using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000907 RID: 2311
	[Token(Token = "0x2000907")]
	[ProtoContract]
	public class CSTeamNameReq
	{
		// Token: 0x06002615 RID: 9749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x21B7A28", Offset = "0x21B7A28", VA = "0x7BBC9B7A28")]
		public CSTeamNameReq()
		{
		}

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117CB4", Offset = "0x1117CB4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117CB4", Offset = "0x1117CB4")]
		public string team_name;
	}
}
