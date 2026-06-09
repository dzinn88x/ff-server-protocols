using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F4 RID: 2548
	[Token(Token = "0x20009F4")]
	[ProtoContract]
	public class TreasureShootCSVDesc
	{
		// Token: 0x060026FE RID: 9982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x24A124C", Offset = "0x24A124C", VA = "0x7BBCCA124C")]
		public TreasureShootCSVDesc()
		{
		}

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C4D0", Offset = "0x111C4D0")]
		public uint id;

		// Token: 0x04002E0E RID: 11790
		[Token(Token = "0x4002E0E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C4E4", Offset = "0x111C4E4")]
		public uint weight;

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C4F8", Offset = "0x111C4F8")]
		public List<AwardDesc> awards;

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C50C", Offset = "0x111C50C")]
		public bool is_preview;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C520", Offset = "0x111C520")]
		public uint preview_avatar;

		// Token: 0x04002E12 RID: 11794
		[Token(Token = "0x4002E12")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C534", Offset = "0x111C534")]
		public bool is_big_reward;

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C548", Offset = "0x111C548")]
		public EInventory.AwardType return_type;

		// Token: 0x04002E14 RID: 11796
		[Token(Token = "0x4002E14")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C55C", Offset = "0x111C55C")]
		public uint return_id;

		// Token: 0x04002E15 RID: 11797
		[Token(Token = "0x4002E15")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C570", Offset = "0x111C570")]
		public uint return_num;

		// Token: 0x04002E16 RID: 11798
		[Token(Token = "0x4002E16")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C584", Offset = "0x111C584")]
		public uint reward_level;

		// Token: 0x04002E17 RID: 11799
		[Token(Token = "0x4002E17")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C598", Offset = "0x111C598")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C598", Offset = "0x111C598")]
		public string icon;

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C5E8", Offset = "0x111C5E8")]
		public bool is_auto_open;

		// Token: 0x04002E19 RID: 11801
		[Token(Token = "0x4002E19")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C5FC", Offset = "0x111C5FC")]
		public bool compose_icon;

		// Token: 0x04002E1A RID: 11802
		[Token(Token = "0x4002E1A")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C610", Offset = "0x111C610")]
		public uint base_weight_a;

		// Token: 0x04002E1B RID: 11803
		[Token(Token = "0x4002E1B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C624", Offset = "0x111C624")]
		public uint base_weight_b;

		// Token: 0x04002E1C RID: 11804
		[Token(Token = "0x4002E1C")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C638", Offset = "0x111C638")]
		public uint base_weight_c;

		// Token: 0x04002E1D RID: 11805
		[Token(Token = "0x4002E1D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C64C", Offset = "0x111C64C")]
		public uint base_weight_d;

		// Token: 0x04002E1E RID: 11806
		[Token(Token = "0x4002E1E")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C660", Offset = "0x111C660")]
		public uint base_weight_e;

		// Token: 0x04002E1F RID: 11807
		[Token(Token = "0x4002E1F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C674", Offset = "0x111C674")]
		public uint base_weight_f;

		// Token: 0x04002E20 RID: 11808
		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C688", Offset = "0x111C688")]
		public uint base_weight_g;

		// Token: 0x04002E21 RID: 11809
		[Token(Token = "0x4002E21")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C69C", Offset = "0x111C69C")]
		public uint base_weight_h;
	}
}
