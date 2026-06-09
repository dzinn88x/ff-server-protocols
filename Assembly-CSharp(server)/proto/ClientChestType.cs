using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200086F RID: 2159
	[Token(Token = "0x200086F")]
	[ProtoContract]
	public class ClientChestType
	{
		// Token: 0x0600257D RID: 9597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257D")]
		[Address(RVA = "0x21B8C60", Offset = "0x21B8C60", VA = "0x7BBC9B8C60")]
		public ClientChestType()
		{
		}

		// Token: 0x0400283F RID: 10303
		[Token(Token = "0x400283F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112AE8", Offset = "0x1112AE8")]
		public uint chest_id;

		// Token: 0x04002840 RID: 10304
		[Token(Token = "0x4002840")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112AFC", Offset = "0x1112AFC")]
		public uint priority;

		// Token: 0x04002841 RID: 10305
		[Token(Token = "0x4002841")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112B10", Offset = "0x1112B10")]
		public uint coin_type;

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112B24", Offset = "0x1112B24")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112B24", Offset = "0x1112B24")]
		public string start_time;

		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112B74", Offset = "0x1112B74")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112B74", Offset = "0x1112B74")]
		public string end_time;

		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112BC4", Offset = "0x1112BC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112BC4", Offset = "0x1112BC4")]
		public string chest_name;

		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112C14", Offset = "0x1112C14")]
		public uint[] exchange_itemid;

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112C50", Offset = "0x1112C50")]
		public uint free_type;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112C64", Offset = "0x1112C64")]
		public uint chest_activity;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112C78", Offset = "0x1112C78")]
		public uint chest_model_id;

		// Token: 0x04002849 RID: 10313
		[Token(Token = "0x4002849")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112C8C", Offset = "0x1112C8C")]
		public long start_time_stamp;

		// Token: 0x0400284A RID: 10314
		[Token(Token = "0x400284A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112CA0", Offset = "0x1112CA0")]
		public long end_time_stamp;

		// Token: 0x0400284B RID: 10315
		[Token(Token = "0x400284B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112CB4", Offset = "0x1112CB4")]
		public uint once_price;

		// Token: 0x0400284C RID: 10316
		[Token(Token = "0x400284C")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112CC8", Offset = "0x1112CC8")]
		public uint ten_price;

		// Token: 0x0400284D RID: 10317
		[Token(Token = "0x400284D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112CDC", Offset = "0x1112CDC")]
		public uint exchange_once_num;

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112CF0", Offset = "0x1112CF0")]
		public uint exchange_ten_num;

		// Token: 0x0400284F RID: 10319
		[Token(Token = "0x400284F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D04", Offset = "0x1112D04")]
		public uint color_id;

		// Token: 0x04002850 RID: 10320
		[Token(Token = "0x4002850")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D18", Offset = "0x1112D18")]
		public bool extra_reward;

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D2C", Offset = "0x1112D2C")]
		public uint once_num;

		// Token: 0x04002852 RID: 10322
		[Token(Token = "0x4002852")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D40", Offset = "0x1112D40")]
		public uint ten_num;

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D54", Offset = "0x1112D54")]
		public long limit_start_time;

		// Token: 0x04002854 RID: 10324
		[Token(Token = "0x4002854")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D68", Offset = "0x1112D68")]
		public long limit_end_time;

		// Token: 0x04002855 RID: 10325
		[Token(Token = "0x4002855")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D7C", Offset = "0x1112D7C")]
		public uint limit_num_one;

		// Token: 0x04002856 RID: 10326
		[Token(Token = "0x4002856")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112D90", Offset = "0x1112D90")]
		public uint[] limit_price_one;

		// Token: 0x04002857 RID: 10327
		[Token(Token = "0x4002857")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112DCC", Offset = "0x1112DCC")]
		public uint limit_num_ten;

		// Token: 0x04002858 RID: 10328
		[Token(Token = "0x4002858")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112DE0", Offset = "0x1112DE0")]
		public uint[] limit_price_ten;

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112E1C", Offset = "0x1112E1C")]
		public long discount_start_time;

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112E30", Offset = "0x1112E30")]
		public long discount_end_time;

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112E44", Offset = "0x1112E44")]
		public uint discount_price_one;

		// Token: 0x0400285C RID: 10332
		[Token(Token = "0x400285C")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112E58", Offset = "0x1112E58")]
		public uint discount_price_ten;

		// Token: 0x0400285D RID: 10333
		[Token(Token = "0x400285D")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112E6C", Offset = "0x1112E6C")]
		public uint show_model_male;

		// Token: 0x0400285E RID: 10334
		[Token(Token = "0x400285E")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112E80", Offset = "0x1112E80")]
		public uint show_model_female;

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112E94", Offset = "0x1112E94")]
		public uint rare_item_max;

		// Token: 0x04002860 RID: 10336
		[Token(Token = "0x4002860")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112EA8", Offset = "0x1112EA8")]
		public uint first_reward_max;

		// Token: 0x04002861 RID: 10337
		[Token(Token = "0x4002861")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112EBC", Offset = "0x1112EBC")]
		public uint second_level_count;

		// Token: 0x04002862 RID: 10338
		[Token(Token = "0x4002862")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112ED0", Offset = "0x1112ED0")]
		public uint third_level_count;

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112EE4", Offset = "0x1112EE4")]
		public uint[] extra_reward_reset_day;

		// Token: 0x04002864 RID: 10340
		[Token(Token = "0x4002864")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112F20", Offset = "0x1112F20")]
		public uint chest_sub_id;

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		[FieldOffset(Offset = "0xEC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112F34", Offset = "0x1112F34")]
		public bool first_reward_switch;

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112F48", Offset = "0x1112F48")]
		public uint chest_model_id2;

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0xF4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112F5C", Offset = "0x1112F5C")]
		public bool drop_probability_switch;

		// Token: 0x04002868 RID: 10344
		[Token(Token = "0x4002868")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112F70", Offset = "0x1112F70")]
		public uint open_priority_switch;

		// Token: 0x04002869 RID: 10345
		[Token(Token = "0x4002869")]
		[FieldOffset(Offset = "0xFC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112F84", Offset = "0x1112F84")]
		public ELottery.Type type;

		// Token: 0x0400286A RID: 10346
		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112F98", Offset = "0x1112F98")]
		public uint forge_tab_id;

		// Token: 0x0400286B RID: 10347
		[Token(Token = "0x400286B")]
		[FieldOffset(Offset = "0x104")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112FAC", Offset = "0x1112FAC")]
		public uint extra_reward_icon;

		// Token: 0x0400286C RID: 10348
		[Token(Token = "0x400286C")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112FC0", Offset = "0x1112FC0")]
		public uint chest_hint_color;

		// Token: 0x0400286D RID: 10349
		[Token(Token = "0x400286D")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112FD4", Offset = "0x1112FD4")]
		public long drop_up_start_time;

		// Token: 0x0400286E RID: 10350
		[Token(Token = "0x400286E")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112FE8", Offset = "0x1112FE8")]
		public long drop_up_end_time;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112FFC", Offset = "0x1112FFC")]
		public uint limit_num;

		// Token: 0x04002870 RID: 10352
		[Token(Token = "0x4002870")]
		[FieldOffset(Offset = "0x124")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113010", Offset = "0x1113010")]
		public uint limit_type;

		// Token: 0x04002871 RID: 10353
		[Token(Token = "0x4002871")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113024", Offset = "0x1113024")]
		public uint drop_up_price;

		// Token: 0x04002872 RID: 10354
		[Token(Token = "0x4002872")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113038", Offset = "0x1113038")]
		public uint[] show_type;

		// Token: 0x04002873 RID: 10355
		[Token(Token = "0x4002873")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113074", Offset = "0x1113074")]
		public uint show_ui_color;

		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113088", Offset = "0x1113088")]
		public uint[] multi_once_price;

		// Token: 0x04002875 RID: 10357
		[Token(Token = "0x4002875")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11130C4", Offset = "0x11130C4")]
		public uint[] price_one_type;

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113100", Offset = "0x1113100")]
		public uint energy_gacha_buff_price;

		// Token: 0x04002877 RID: 10359
		[Token(Token = "0x4002877")]
		[FieldOffset(Offset = "0x154")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113114", Offset = "0x1113114")]
		public uint energy_gacha_buff_reset_price;

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113128", Offset = "0x1113128")]
		public uint legend_cloth_id;

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111313C", Offset = "0x111313C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111313C", Offset = "0x111313C")]
		public string bag_icon;
	}
}
