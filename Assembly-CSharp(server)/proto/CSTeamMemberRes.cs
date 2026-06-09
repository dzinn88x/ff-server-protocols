using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200090A RID: 2314
	[Token(Token = "0x200090A")]
	[ProtoContract]
	public class CSTeamMemberRes
	{
		// Token: 0x06002618 RID: 9752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x21B7A20", Offset = "0x21B7A20", VA = "0x7BBC9B7A20")]
		public CSTeamMemberRes()
		{
		}

		// Token: 0x04002AE7 RID: 10983
		[Token(Token = "0x4002AE7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117DF4", Offset = "0x1117DF4")]
		public ulong team_id;

		// Token: 0x04002AE8 RID: 10984
		[Token(Token = "0x4002AE8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117E08", Offset = "0x1117E08")]
		public ulong member_id;

		// Token: 0x04002AE9 RID: 10985
		[Token(Token = "0x4002AE9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117E1C", Offset = "0x1117E1C")]
		public uint member_type;

		// Token: 0x04002AEA RID: 10986
		[Token(Token = "0x4002AEA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117E30", Offset = "0x1117E30")]
		public ulong join_at;

		// Token: 0x04002AEB RID: 10987
		[Token(Token = "0x4002AEB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117E44", Offset = "0x1117E44")]
		public bool is_not_in_team;
	}
}
