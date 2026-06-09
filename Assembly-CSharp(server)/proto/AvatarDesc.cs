using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009CC RID: 2508
	[Token(Token = "0x20009CC")]
	[ProtoContract]
	public class AvatarDesc
	{
		// Token: 0x060026D6 RID: 9942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x21AF490", Offset = "0x21AF490", VA = "0x7BBC9AF490")]
		public AvatarDesc()
		{
		}

		// Token: 0x04002D53 RID: 11603
		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B224", Offset = "0x111B224")]
		public uint id;

		// Token: 0x04002D54 RID: 11604
		[Token(Token = "0x4002D54")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B238", Offset = "0x111B238")]
		public EInventory.GenderType gender;

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B24C", Offset = "0x111B24C")]
		public bool is_default;

		// Token: 0x04002D56 RID: 11606
		[Token(Token = "0x4002D56")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B260", Offset = "0x111B260")]
		public bool is_selected;

		// Token: 0x04002D57 RID: 11607
		[Token(Token = "0x4002D57")]
		[FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B274", Offset = "0x111B274")]
		public bool can_change_skin_color;

		// Token: 0x04002D58 RID: 11608
		[Token(Token = "0x4002D58")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B288", Offset = "0x111B288")]
		public uint pve_primary_weapon;

		// Token: 0x04002D59 RID: 11609
		[Token(Token = "0x4002D59")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B29C", Offset = "0x111B29C")]
		public bool head_additive_switch;
	}
}
