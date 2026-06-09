using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A93 RID: 2707
	[Token(Token = "0x2000A93")]
	[ProtoContract]
	public class ChestGoodsRareDesc
	{
		// Token: 0x0600279D RID: 10141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279D")]
		[Address(RVA = "0x21B8408", Offset = "0x21B8408", VA = "0x7BBC9B8408")]
		public ChestGoodsRareDesc()
		{
		}

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C6C", Offset = "0x1123C6C")]
		public uint jackpot;

		// Token: 0x040031F2 RID: 12786
		[Token(Token = "0x40031F2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C80", Offset = "0x1123C80")]
		public EInventory.AwardType reward_item_type;

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C94", Offset = "0x1123C94")]
		public uint item_id;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123CA8", Offset = "0x1123CA8")]
		public uint item_num;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123CBC", Offset = "0x1123CBC")]
		public bool must_drop_item;

		// Token: 0x040031F6 RID: 12790
		[Token(Token = "0x40031F6")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123CD0", Offset = "0x1123CD0")]
		public ELottery.RareType rare_item;

		// Token: 0x040031F7 RID: 12791
		[Token(Token = "0x40031F7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123CE4", Offset = "0x1123CE4")]
		public bool first_reward_item;

		// Token: 0x040031F8 RID: 12792
		[Token(Token = "0x40031F8")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123CF8", Offset = "0x1123CF8")]
		public uint drop_limit;

		// Token: 0x040031F9 RID: 12793
		[Token(Token = "0x40031F9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D0C", Offset = "0x1123D0C")]
		public uint first_reward_probability;

		// Token: 0x040031FA RID: 12794
		[Token(Token = "0x40031FA")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D20", Offset = "0x1123D20")]
		public uint base_probability;

		// Token: 0x040031FB RID: 12795
		[Token(Token = "0x40031FB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D34", Offset = "0x1123D34")]
		public uint second_level_probability;

		// Token: 0x040031FC RID: 12796
		[Token(Token = "0x40031FC")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D48", Offset = "0x1123D48")]
		public uint third_level_probability;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D5C", Offset = "0x1123D5C")]
		public uint repeat_change_item_id;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D70", Offset = "0x1123D70")]
		public uint repeat_change_item_num;

		// Token: 0x040031FF RID: 12799
		[Token(Token = "0x40031FF")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D84", Offset = "0x1123D84")]
		public uint reward_level;

		// Token: 0x04003200 RID: 12800
		[Token(Token = "0x4003200")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123D98", Offset = "0x1123D98")]
		public EInventory.AwardType repeat_change_item_type;

		// Token: 0x04003201 RID: 12801
		[Token(Token = "0x4003201")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123DAC", Offset = "0x1123DAC")]
		public uint turntable_props_type;

		// Token: 0x04003202 RID: 12802
		[Token(Token = "0x4003202")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123DC0", Offset = "0x1123DC0")]
		public float drop_up_ratio;

		// Token: 0x04003203 RID: 12803
		[Token(Token = "0x4003203")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123DD4", Offset = "0x1123DD4")]
		public bool epbadge_switch;

		// Token: 0x04003204 RID: 12804
		[Token(Token = "0x4003204")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123DE8", Offset = "0x1123DE8")]
		public uint veteran_probability;

		// Token: 0x04003205 RID: 12805
		[Token(Token = "0x4003205")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123DFC", Offset = "0x1123DFC")]
		public uint id;

		// Token: 0x04003206 RID: 12806
		[Token(Token = "0x4003206")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E10", Offset = "0x1123E10")]
		public float base_probability_ratio_a;

		// Token: 0x04003207 RID: 12807
		[Token(Token = "0x4003207")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E24", Offset = "0x1123E24")]
		public float base_probability_ratio_b;

		// Token: 0x04003208 RID: 12808
		[Token(Token = "0x4003208")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E38", Offset = "0x1123E38")]
		public float base_probability_ratio_c;

		// Token: 0x04003209 RID: 12809
		[Token(Token = "0x4003209")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E4C", Offset = "0x1123E4C")]
		public float base_probability_ratio_d;

		// Token: 0x0400320A RID: 12810
		[Token(Token = "0x400320A")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E60", Offset = "0x1123E60")]
		public float base_probability_ratio_e;

		// Token: 0x0400320B RID: 12811
		[Token(Token = "0x400320B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E74", Offset = "0x1123E74")]
		public float base_probability_ratio_f;

		// Token: 0x0400320C RID: 12812
		[Token(Token = "0x400320C")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E88", Offset = "0x1123E88")]
		public float base_probability_ratio_g;

		// Token: 0x0400320D RID: 12813
		[Token(Token = "0x400320D")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123E9C", Offset = "0x1123E9C")]
		public float base_probability_ratio_h;

		// Token: 0x0400320E RID: 12814
		[Token(Token = "0x400320E")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123EB0", Offset = "0x1123EB0")]
		public uint item_duration;

		// Token: 0x0400320F RID: 12815
		[Token(Token = "0x400320F")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123EC4", Offset = "0x1123EC4")]
		public float base_probability_ratio_a2;

		// Token: 0x04003210 RID: 12816
		[Token(Token = "0x4003210")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123ED8", Offset = "0x1123ED8")]
		public float base_probability_ratio_b2;

		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123EEC", Offset = "0x1123EEC")]
		public float base_probability_ratio_c2;

		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F00", Offset = "0x1123F00")]
		public float base_probability_ratio_d2;

		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F14", Offset = "0x1123F14")]
		public float base_probability_ratio_e2;

		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F28", Offset = "0x1123F28")]
		public float base_probability_ratio_f2;

		// Token: 0x04003215 RID: 12821
		[Token(Token = "0x4003215")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F3C", Offset = "0x1123F3C")]
		public float base_probability_ratio_g2;

		// Token: 0x04003216 RID: 12822
		[Token(Token = "0x4003216")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F50", Offset = "0x1123F50")]
		public float base_probability_ratio_h2;

		// Token: 0x04003217 RID: 12823
		[Token(Token = "0x4003217")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F64", Offset = "0x1123F64")]
		public uint fourth_level_probability;

		// Token: 0x04003218 RID: 12824
		[Token(Token = "0x4003218")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F78", Offset = "0x1123F78")]
		public uint fifth_level_probability;

		// Token: 0x04003219 RID: 12825
		[Token(Token = "0x4003219")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123F8C", Offset = "0x1123F8C")]
		public bool token_flag;

		// Token: 0x0400321A RID: 12826
		[Token(Token = "0x400321A")]
		[FieldOffset(Offset = "0xB1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123FA0", Offset = "0x1123FA0")]
		public bool un_quick_selection;
	}
}
