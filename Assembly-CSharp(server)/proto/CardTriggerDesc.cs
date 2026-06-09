using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ABF RID: 2751
	[Token(Token = "0x2000ABF")]
	[ProtoContract]
	public class CardTriggerDesc
	{
		// Token: 0x060027C9 RID: 10185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x21B7EA8", Offset = "0x21B7EA8", VA = "0x7BBC9B7EA8")]
		public CardTriggerDesc()
		{
		}

		// Token: 0x040033B6 RID: 13238
		[Token(Token = "0x40033B6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127394", Offset = "0x1127394")]
		public uint id;

		// Token: 0x040033B7 RID: 13239
		[Token(Token = "0x40033B7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11273A8", Offset = "0x11273A8")]
		public uint match_mode;

		// Token: 0x040033B8 RID: 13240
		[Token(Token = "0x40033B8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11273BC", Offset = "0x11273BC")]
		public uint map_id;

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11273D0", Offset = "0x11273D0")]
		public uint game_mode;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11273E4", Offset = "0x11273E4")]
		public bool trigger_card;

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11273F8", Offset = "0x11273F8")]
		public uint rank_need;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112740C", Offset = "0x112740C")]
		public uint kill_need;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127420", Offset = "0x1127420")]
		public bool win_award;
	}
}
