using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B22 RID: 2850
	[Token(Token = "0x2000B22")]
	[ProtoContract]
	public class BermudaSettingsDesc
	{
		// Token: 0x0600282A RID: 10282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x21AF7B4", Offset = "0x21AF7B4", VA = "0x7BBC9AF7B4")]
		public BermudaSettingsDesc()
		{
		}

		// Token: 0x0400360D RID: 13837
		[Token(Token = "0x400360D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C010", Offset = "0x112C010")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C010", Offset = "0x112C010")]
		public string movie;

		// Token: 0x0400360E RID: 13838
		[Token(Token = "0x400360E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C060", Offset = "0x112C060")]
		public uint mode_jump_go_pos;

		// Token: 0x0400360F RID: 13839
		[Token(Token = "0x400360F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C074", Offset = "0x112C074")]
		public uint mode_jump_sub_go_pos;

		// Token: 0x04003610 RID: 13840
		[Token(Token = "0x4003610")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C088", Offset = "0x112C088")]
		public uint item_id;
	}
}
