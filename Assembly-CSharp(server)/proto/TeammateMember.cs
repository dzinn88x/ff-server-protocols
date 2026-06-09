using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x200063C")]
	[ProtoContract]
	public class TeammateMember
	{
		// Token: 0x060023A6 RID: 9126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x24A0FF0", Offset = "0x24A0FF0", VA = "0x7BBCCA0FF0")]
		public TeammateMember()
		{
		}

		// Token: 0x04001FA1 RID: 8097
		[Token(Token = "0x4001FA1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11081C4", Offset = "0x11081C4")]
		public ulong account_id;

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11081D8", Offset = "0x11081D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11081D8", Offset = "0x11081D8")]
		public string clan_name;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108228", Offset = "0x1108228")]
		public uint kills;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110823C", Offset = "0x110823C")]
		public uint damage;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108250", Offset = "0x1108250")]
		public uint headshot_kills;

		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108264", Offset = "0x1108264")]
		public uint hp_used_count;
	}
}
