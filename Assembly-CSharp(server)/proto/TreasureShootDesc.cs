using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F3 RID: 2547
	[Token(Token = "0x20009F3")]
	[ProtoContract]
	public class TreasureShootDesc
	{
		// Token: 0x060026FD RID: 9981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x24A12D0", Offset = "0x24A12D0", VA = "0x7BBCCA12D0")]
		public TreasureShootDesc()
		{
		}

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C390", Offset = "0x111C390")]
		public uint id;

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C3A4", Offset = "0x111C3A4")]
		public uint weight;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C3B8", Offset = "0x111C3B8")]
		public List<AwardDesc> awards;

		// Token: 0x04002E03 RID: 11779
		[Token(Token = "0x4002E03")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C3CC", Offset = "0x111C3CC")]
		public bool is_preview;

		// Token: 0x04002E04 RID: 11780
		[Token(Token = "0x4002E04")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C3E0", Offset = "0x111C3E0")]
		public uint preview_avatar;

		// Token: 0x04002E05 RID: 11781
		[Token(Token = "0x4002E05")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C3F4", Offset = "0x111C3F4")]
		public bool is_big_reward;

		// Token: 0x04002E06 RID: 11782
		[Token(Token = "0x4002E06")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C408", Offset = "0x111C408")]
		public EInventory.AwardType return_type;

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C41C", Offset = "0x111C41C")]
		public uint return_id;

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C430", Offset = "0x111C430")]
		public uint return_num;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C444", Offset = "0x111C444")]
		public uint reward_level;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C458", Offset = "0x111C458")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C458", Offset = "0x111C458")]
		public string icon;

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C4A8", Offset = "0x111C4A8")]
		public bool is_auto_open;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C4BC", Offset = "0x111C4BC")]
		public bool compose_icon;
	}
}
