using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A94 RID: 2708
	[Token(Token = "0x2000A94")]
	[ProtoContract]
	public class ChestTypeDesc
	{
		// Token: 0x0600279E RID: 10142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x21B84B8", Offset = "0x21B84B8", VA = "0x7BBC9B84B8")]
		public ChestTypeDesc()
		{
		}

		// Token: 0x0400321B RID: 12827
		[Token(Token = "0x400321B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123FB4", Offset = "0x1123FB4")]
		public uint chest_id;

		// Token: 0x0400321C RID: 12828
		[Token(Token = "0x400321C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123FC8", Offset = "0x1123FC8")]
		public uint chest_sub_id;

		// Token: 0x0400321D RID: 12829
		[Token(Token = "0x400321D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123FDC", Offset = "0x1123FDC")]
		public uint chest_type;

		// Token: 0x0400321E RID: 12830
		[Token(Token = "0x400321E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123FF0", Offset = "0x1123FF0")]
		public uint priority;

		// Token: 0x0400321F RID: 12831
		[Token(Token = "0x400321F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124004", Offset = "0x1124004")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124004", Offset = "0x1124004")]
		public string start_time;

		// Token: 0x04003220 RID: 12832
		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124054", Offset = "0x1124054")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124054", Offset = "0x1124054")]
		public string end_time;

		// Token: 0x04003221 RID: 12833
		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11240A4", Offset = "0x11240A4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11240A4", Offset = "0x11240A4")]
		public string chest_name;

		// Token: 0x04003222 RID: 12834
		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11240F4", Offset = "0x11240F4")]
		public uint[] jackpot;

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124130", Offset = "0x1124130")]
		public bool first_reward_switch;

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124144", Offset = "0x1124144")]
		public uint first_reward_min;

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124158", Offset = "0x1124158")]
		public uint first_reward_max;

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112416C", Offset = "0x112416C")]
		public uint second_level_count;

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124180", Offset = "0x1124180")]
		public uint third_level_count;

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124194", Offset = "0x1124194")]
		public bool extra_reward_switch;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11241A8", Offset = "0x11241A8")]
		public uint[] extra_reward_reset_day;

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11241E4", Offset = "0x11241E4")]
		public uint rare_item_min;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11241F8", Offset = "0x11241F8")]
		public uint rare_item_max;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112420C", Offset = "0x112420C")]
		public uint chest_activity;

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124220", Offset = "0x1124220")]
		public long start_time_stamp;

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124234", Offset = "0x1124234")]
		public long end_time_stamp;

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124248", Offset = "0x1124248")]
		public bool drop_probability_switch;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[FieldOffset(Offset = "0x81")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112425C", Offset = "0x112425C")]
		public bool lucky_inherit_switch;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124270", Offset = "0x1124270")]
		public uint open_priority_switch;

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124284", Offset = "0x1124284")]
		public ELottery.Type type;

		// Token: 0x04003233 RID: 12851
		[Token(Token = "0x4003233")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124298", Offset = "0x1124298")]
		public uint forge_tab_id;

		// Token: 0x04003234 RID: 12852
		[Token(Token = "0x4003234")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11242AC", Offset = "0x11242AC")]
		public uint rare_item2_min;

		// Token: 0x04003235 RID: 12853
		[Token(Token = "0x4003235")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11242C0", Offset = "0x11242C0")]
		public uint rare_item2_max;

		// Token: 0x04003236 RID: 12854
		[Token(Token = "0x4003236")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11242D4", Offset = "0x11242D4")]
		public long drop_up_start_time;

		// Token: 0x04003237 RID: 12855
		[Token(Token = "0x4003237")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11242E8", Offset = "0x11242E8")]
		public long drop_up_end_time;

		// Token: 0x04003238 RID: 12856
		[Token(Token = "0x4003238")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11242FC", Offset = "0x11242FC")]
		public uint veteran_buff_num;

		// Token: 0x04003239 RID: 12857
		[Token(Token = "0x4003239")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124310", Offset = "0x1124310")]
		public uint veteran_buff_time;

		// Token: 0x0400323A RID: 12858
		[Token(Token = "0x400323A")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124324", Offset = "0x1124324")]
		public bool melonpi_switch;

		// Token: 0x0400323B RID: 12859
		[Token(Token = "0x400323B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124338", Offset = "0x1124338")]
		public long show_time_stamp;

		// Token: 0x0400323C RID: 12860
		[Token(Token = "0x400323C")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112434C", Offset = "0x112434C")]
		public uint[] buff_up_random;

		// Token: 0x0400323D RID: 12861
		[Token(Token = "0x400323D")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124388", Offset = "0x1124388")]
		public uint[] buff_up_probability;

		// Token: 0x0400323E RID: 12862
		[Token(Token = "0x400323E")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11243C4", Offset = "0x11243C4")]
		public uint[] buff_up_display;

		// Token: 0x0400323F RID: 12863
		[Token(Token = "0x400323F")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124400", Offset = "0x1124400")]
		public uint Luck_point_once;

		// Token: 0x04003240 RID: 12864
		[Token(Token = "0x4003240")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124414", Offset = "0x1124414")]
		public uint Luck_point_multi;

		// Token: 0x04003241 RID: 12865
		[Token(Token = "0x4003241")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124428", Offset = "0x1124428")]
		public uint Luck_point_buff;

		// Token: 0x04003242 RID: 12866
		[Token(Token = "0x4003242")]
		[FieldOffset(Offset = "0xE4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112443C", Offset = "0x112443C")]
		public uint Luck_point_reset;

		// Token: 0x04003243 RID: 12867
		[Token(Token = "0x4003243")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124450", Offset = "0x1124450")]
		public uint[] token_max;

		// Token: 0x04003244 RID: 12868
		[Token(Token = "0x4003244")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112448C", Offset = "0x112448C")]
		public uint[] token_min;

		// Token: 0x04003245 RID: 12869
		[Token(Token = "0x4003245")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11244C8", Offset = "0x11244C8")]
		public uint legend_cloth_id;
	}
}
