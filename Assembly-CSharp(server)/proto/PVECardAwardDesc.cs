using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ACE RID: 2766
	[Token(Token = "0x2000ACE")]
	[ProtoContract]
	public class PVECardAwardDesc
	{
		// Token: 0x060027D6 RID: 10198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x249EE1C", Offset = "0x249EE1C", VA = "0x7BBCC9EE1C")]
		public PVECardAwardDesc()
		{
		}

		// Token: 0x040033F9 RID: 13305
		[Token(Token = "0x40033F9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11278BC", Offset = "0x11278BC")]
		public uint game_mode;

		// Token: 0x040033FA RID: 13306
		[Token(Token = "0x40033FA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11278D0", Offset = "0x11278D0")]
		public uint map_id;

		// Token: 0x040033FB RID: 13307
		[Token(Token = "0x40033FB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11278E4", Offset = "0x11278E4")]
		public uint difficulty;

		// Token: 0x040033FC RID: 13308
		[Token(Token = "0x40033FC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11278F8", Offset = "0x11278F8")]
		public uint ai_type;

		// Token: 0x040033FD RID: 13309
		[Token(Token = "0x40033FD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112790C", Offset = "0x112790C")]
		public uint card_rank;

		// Token: 0x040033FE RID: 13310
		[Token(Token = "0x40033FE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127920", Offset = "0x1127920")]
		public AwardFromCard pve_award;
	}
}
