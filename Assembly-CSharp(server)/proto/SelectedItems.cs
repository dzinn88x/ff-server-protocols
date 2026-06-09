using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	[ProtoContract]
	public class SelectedItems
	{
		// Token: 0x06002490 RID: 9360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002490")]
		[Address(RVA = "0x24A0510", Offset = "0x24A0510", VA = "0x7BBCCA0510")]
		public SelectedItems()
		{
		}

		// Token: 0x04002556 RID: 9558
		[Token(Token = "0x4002556")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DC50", Offset = "0x110DC50")]
		public uint avatar_id;

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DC64", Offset = "0x110DC64")]
		public uint skin_color;

		// Token: 0x04002558 RID: 9560
		[Token(Token = "0x4002558")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DC78", Offset = "0x110DC78")]
		public uint[] clothes;

		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x4002559")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DCB4", Offset = "0x110DCB4")]
		public List<LoadoutInfo> loadouts;

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DCC8", Offset = "0x110DCC8")]
		public uint banner_id;

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DCDC", Offset = "0x110DCDC")]
		public uint head_pic;

		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DCF0", Offset = "0x110DCF0")]
		public uint[] slots;

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DD2C", Offset = "0x110DD2C")]
		public ChoosedEmotes emotes;

		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DD40", Offset = "0x110DD40")]
		public uint[] shows;

		// Token: 0x0400255F RID: 9567
		[Token(Token = "0x400255F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DD7C", Offset = "0x110DD7C")]
		public uint pve_primary_weapon_skin;

		// Token: 0x04002560 RID: 9568
		[Token(Token = "0x4002560")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DD90", Offset = "0x110DD90")]
		public uint[] ranking_cards;

		// Token: 0x04002561 RID: 9569
		[Token(Token = "0x4002561")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DDCC", Offset = "0x110DDCC")]
		public uint pin_id;
	}
}
