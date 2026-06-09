using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008FB RID: 2299
	[Token(Token = "0x20008FB")]
	[ProtoContract]
	public class TeamMemberWithAccountInfo
	{
		// Token: 0x06002609 RID: 9737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x24A0F10", Offset = "0x24A0F10", VA = "0x7BBCCA0F10")]
		public TeamMemberWithAccountInfo()
		{
		}

		// Token: 0x04002ABC RID: 10940
		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11178A4", Offset = "0x11178A4")]
		public AccountInfoBasic basic_info;

		// Token: 0x04002ABD RID: 10941
		[Token(Token = "0x4002ABD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11178B8", Offset = "0x11178B8")]
		public ulong team_id;

		// Token: 0x04002ABE RID: 10942
		[Token(Token = "0x4002ABE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11178CC", Offset = "0x11178CC")]
		public uint member_type;

		// Token: 0x04002ABF RID: 10943
		[Token(Token = "0x4002ABF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11178E0", Offset = "0x11178E0")]
		public ulong join_at;

		// Token: 0x04002AC0 RID: 10944
		[Token(Token = "0x4002AC0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11178F4", Offset = "0x11178F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11178F4", Offset = "0x11178F4")]
		public string region;
	}
}
