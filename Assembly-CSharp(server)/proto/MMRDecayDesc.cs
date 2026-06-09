using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A4E RID: 2638
	[Token(Token = "0x2000A4E")]
	[ProtoContract]
	public class MMRDecayDesc
	{
		// Token: 0x06002758 RID: 10072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x21BC074", Offset = "0x21BC074", VA = "0x7BBC9BC074")]
		public MMRDecayDesc()
		{
		}

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112092C", Offset = "0x112092C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112092C", Offset = "0x112092C")]
		public string region;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112097C", Offset = "0x112097C")]
		public uint game_mode;

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120990", Offset = "0x1120990")]
		public bool enable_decay;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11209A4", Offset = "0x11209A4")]
		public uint days_to_mark_decay;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11209B8", Offset = "0x11209B8")]
		public uint decay_basis_per_day;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11209CC", Offset = "0x11209CC")]
		public uint progressive_factor;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11209E0", Offset = "0x11209E0")]
		public uint decay_stage_in_days;

		// Token: 0x04003026 RID: 12326
		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11209F4", Offset = "0x11209F4")]
		public uint decay_ratio_upperlimit;

		// Token: 0x04003027 RID: 12327
		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A08", Offset = "0x1120A08")]
		public uint mmr_lowerlimit_after_decay;
	}
}
