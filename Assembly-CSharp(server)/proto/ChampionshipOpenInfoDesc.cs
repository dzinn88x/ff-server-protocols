using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	[ProtoContract]
	public class ChampionshipOpenInfoDesc
	{
		// Token: 0x060027E7 RID: 10215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x21B80A8", Offset = "0x21B80A8", VA = "0x7BBC9B80A8")]
		public ChampionshipOpenInfoDesc()
		{
		}

		// Token: 0x0400343C RID: 13372
		[Token(Token = "0x400343C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112817C", Offset = "0x112817C")]
		public uint championship_type;

		// Token: 0x0400343D RID: 13373
		[Token(Token = "0x400343D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128190", Offset = "0x1128190")]
		public uint championship_id;

		// Token: 0x0400343E RID: 13374
		[Token(Token = "0x400343E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11281A4", Offset = "0x11281A4")]
		public long season_start_time;

		// Token: 0x0400343F RID: 13375
		[Token(Token = "0x400343F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11281B8", Offset = "0x11281B8")]
		public long season_end_time;

		// Token: 0x04003440 RID: 13376
		[Token(Token = "0x4003440")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11281CC", Offset = "0x11281CC")]
		public long trial_start_time;

		// Token: 0x04003441 RID: 13377
		[Token(Token = "0x4003441")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11281E0", Offset = "0x11281E0")]
		public long trial_end_time;

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11281F4", Offset = "0x11281F4")]
		public long final_start_time;

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128208", Offset = "0x1128208")]
		public long final_end_time;

		// Token: 0x04003444 RID: 13380
		[Token(Token = "0x4003444")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112821C", Offset = "0x112821C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112821C", Offset = "0x112821C")]
		public string map_id;

		// Token: 0x04003445 RID: 13381
		[Token(Token = "0x4003445")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112826C", Offset = "0x112826C")]
		public long entrance_open_time;

		// Token: 0x04003446 RID: 13382
		[Token(Token = "0x4003446")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128280", Offset = "0x1128280")]
		public long entrance_end_time;
	}
}
