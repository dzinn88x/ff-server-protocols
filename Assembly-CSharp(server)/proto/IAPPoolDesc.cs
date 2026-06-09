using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2000AA1")]
	[ProtoContract]
	public class IAPPoolDesc
	{
		// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x21BB30C", Offset = "0x21BB30C", VA = "0x7BBC9BB30C")]
		public IAPPoolDesc()
		{
		}

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112592C", Offset = "0x112592C")]
		public uint bundle_pool_id;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125940", Offset = "0x1125940")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125940", Offset = "0x1125940")]
		public string start_time;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125990", Offset = "0x1125990")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125990", Offset = "0x1125990")]
		public string end_time;

		// Token: 0x040032E1 RID: 13025
		[Token(Token = "0x40032E1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11259E0", Offset = "0x11259E0")]
		public uint exist_time;

		// Token: 0x040032E2 RID: 13026
		[Token(Token = "0x40032E2")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11259F4", Offset = "0x11259F4")]
		public uint cd_time;

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125A08", Offset = "0x1125A08")]
		public uint match_mode;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125A1C", Offset = "0x1125A1C")]
		public uint game_mode;

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125A30", Offset = "0x1125A30")]
		public uint map_id;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125A44", Offset = "0x1125A44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125A44", Offset = "0x1125A44")]
		public string group_mode;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125A94", Offset = "0x1125A94")]
		public uint rank;

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125AA8", Offset = "0x1125AA8")]
		public uint match_time;

		// Token: 0x040032E9 RID: 13033
		[Token(Token = "0x40032E9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125ABC", Offset = "0x1125ABC")]
		public float drop_rate;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125AD0", Offset = "0x1125AD0")]
		public uint is_ios_review;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125AE4", Offset = "0x1125AE4")]
		public uint min_player_level;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125AF8", Offset = "0x1125AF8")]
		public uint max_player_level;

		// Token: 0x040032ED RID: 13037
		[Token(Token = "0x40032ED")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125B0C", Offset = "0x1125B0C")]
		public uint min_ranking_level;

		// Token: 0x040032EE RID: 13038
		[Token(Token = "0x40032EE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125B20", Offset = "0x1125B20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125B20", Offset = "0x1125B20")]
		public string is_ep_unlock;

		// Token: 0x040032EF RID: 13039
		[Token(Token = "0x40032EF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125B70", Offset = "0x1125B70")]
		public uint[] paid_levels;

		// Token: 0x040032F0 RID: 13040
		[Token(Token = "0x40032F0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125BAC", Offset = "0x1125BAC")]
		public uint veteran_class;

		// Token: 0x040032F1 RID: 13041
		[Token(Token = "0x40032F1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125BC0", Offset = "0x1125BC0")]
		public List<string> melon_pi_api_classes;

		// Token: 0x040032F2 RID: 13042
		[Token(Token = "0x40032F2")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125BD4", Offset = "0x1125BD4")]
		public EStore.IapSpecialDropType special_type;

		// Token: 0x040032F3 RID: 13043
		[Token(Token = "0x40032F3")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125BE8", Offset = "0x1125BE8")]
		public uint special_type_num;

		// Token: 0x040032F4 RID: 13044
		[Token(Token = "0x40032F4")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125BFC", Offset = "0x1125BFC")]
		public EStore.IapDropSituation drop_situation;

		// Token: 0x040032F5 RID: 13045
		[Token(Token = "0x40032F5")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125C10", Offset = "0x1125C10")]
		public uint drop_situation_desc;

		// Token: 0x040032F6 RID: 13046
		[Token(Token = "0x40032F6")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125C24", Offset = "0x1125C24")]
		public List<string> choco_api;
	}
}
