using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200090B RID: 2315
	[Token(Token = "0x200090B")]
	[ProtoContract]
	public class CSAddTeamContactInfoReq
	{
		// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x21B02EC", Offset = "0x21B02EC", VA = "0x7BBC9B02EC")]
		public CSAddTeamContactInfoReq()
		{
		}

		// Token: 0x04002AEC RID: 10988
		[Token(Token = "0x4002AEC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117E58", Offset = "0x1117E58")]
		public ulong team_id;

		// Token: 0x04002AED RID: 10989
		[Token(Token = "0x4002AED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117E6C", Offset = "0x1117E6C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117E6C", Offset = "0x1117E6C")]
		public string contact_info;
	}
}
