using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F7 RID: 1783
	[Token(Token = "0x20006F7")]
	[ProtoContract]
	public class MatchIncome
	{
		// Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x21BC50C", Offset = "0x21BC50C", VA = "0x7BBC9BC50C")]
		public MatchIncome()
		{
		}

		// Token: 0x040022C4 RID: 8900
		[Token(Token = "0x40022C4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F10", Offset = "0x1109F10")]
		public uint exp;

		// Token: 0x040022C5 RID: 8901
		[Token(Token = "0x40022C5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F24", Offset = "0x1109F24")]
		public uint coins;

		// Token: 0x040022C6 RID: 8902
		[Token(Token = "0x40022C6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F38", Offset = "0x1109F38")]
		public uint rank_points;

		// Token: 0x040022C7 RID: 8903
		[Token(Token = "0x40022C7")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F4C", Offset = "0x1109F4C")]
		public uint kill_points;

		// Token: 0x040022C8 RID: 8904
		[Token(Token = "0x40022C8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F60", Offset = "0x1109F60")]
		public uint damage_points;

		// Token: 0x040022C9 RID: 8905
		[Token(Token = "0x40022C9")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F74", Offset = "0x1109F74")]
		public uint level_before;

		// Token: 0x040022CA RID: 8906
		[Token(Token = "0x40022CA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F88", Offset = "0x1109F88")]
		public uint level_after;

		// Token: 0x040022CB RID: 8907
		[Token(Token = "0x40022CB")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109F9C", Offset = "0x1109F9C")]
		public uint exp_before;

		// Token: 0x040022CC RID: 8908
		[Token(Token = "0x40022CC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109FB0", Offset = "0x1109FB0")]
		public uint exp_after;

		// Token: 0x040022CD RID: 8909
		[Token(Token = "0x40022CD")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109FC4", Offset = "0x1109FC4")]
		public uint coins_before;

		// Token: 0x040022CE RID: 8910
		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109FD8", Offset = "0x1109FD8")]
		public uint coins_after;

		// Token: 0x040022CF RID: 8911
		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109FEC", Offset = "0x1109FEC")]
		public uint coins_gained_today;

		// Token: 0x040022D0 RID: 8912
		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A000", Offset = "0x110A000")]
		public uint coins_gain_limit;

		// Token: 0x040022D1 RID: 8913
		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A014", Offset = "0x110A014")]
		public int mmr_delta;

		// Token: 0x040022D2 RID: 8914
		[Token(Token = "0x40022D2")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A028", Offset = "0x110A028")]
		public int ranking_points_delta;

		// Token: 0x040022D3 RID: 8915
		[Token(Token = "0x40022D3")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A03C", Offset = "0x110A03C")]
		public int ranking_points_before;

		// Token: 0x040022D4 RID: 8916
		[Token(Token = "0x40022D4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A050", Offset = "0x110A050")]
		public int ranking_points_after;

		// Token: 0x040022D5 RID: 8917
		[Token(Token = "0x40022D5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A064", Offset = "0x110A064")]
		public AwardData level_rewards;

		// Token: 0x040022D6 RID: 8918
		[Token(Token = "0x40022D6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A078", Offset = "0x110A078")]
		public uint daily_reward_exp;

		// Token: 0x040022D7 RID: 8919
		[Token(Token = "0x40022D7")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A08C", Offset = "0x110A08C")]
		public uint daily_reward_coins;

		// Token: 0x040022D8 RID: 8920
		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A0A0", Offset = "0x110A0A0")]
		public uint rank_before;

		// Token: 0x040022D9 RID: 8921
		[Token(Token = "0x40022D9")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A0B4", Offset = "0x110A0B4")]
		public uint rank_after;

		// Token: 0x040022DA RID: 8922
		[Token(Token = "0x40022DA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A0C8", Offset = "0x110A0C8")]
		public bool has_rank_upgrade_rewards;

		// Token: 0x040022DB RID: 8923
		[Token(Token = "0x40022DB")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A0DC", Offset = "0x110A0DC")]
		public bool is_rank;

		// Token: 0x040022DC RID: 8924
		[Token(Token = "0x40022DC")]
		[FieldOffset(Offset = "0x72")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A0F0", Offset = "0x110A0F0")]
		public bool is_logout_match;

		// Token: 0x040022DD RID: 8925
		[Token(Token = "0x40022DD")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A104", Offset = "0x110A104")]
		public uint honor_point_delta;

		// Token: 0x040022DE RID: 8926
		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A118", Offset = "0x110A118")]
		public List<GameDrop> game_drops;

		// Token: 0x040022DF RID: 8927
		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A12C", Offset = "0x110A12C")]
		public bool is_loss_prevented;

		// Token: 0x040022E0 RID: 8928
		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A140", Offset = "0x110A140")]
		public uint coin_limit_event_bonus;

		// Token: 0x040022E1 RID: 8929
		[Token(Token = "0x40022E1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A154", Offset = "0x110A154")]
		public uint debris_limit_event_bonus;

		// Token: 0x040022E2 RID: 8930
		[Token(Token = "0x40022E2")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A168", Offset = "0x110A168")]
		public RankingPointsDetail ranking_points_detail;

		// Token: 0x040022E3 RID: 8931
		[Token(Token = "0x40022E3")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A17C", Offset = "0x110A17C")]
		public uint race_point_delta;

		// Token: 0x040022E4 RID: 8932
		[Token(Token = "0x40022E4")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A190", Offset = "0x110A190")]
		public uint ranking_token_id;

		// Token: 0x040022E5 RID: 8933
		[Token(Token = "0x40022E5")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A1A4", Offset = "0x110A1A4")]
		public uint ranking_token_delta;

		// Token: 0x040022E6 RID: 8934
		[Token(Token = "0x40022E6")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A1B8", Offset = "0x110A1B8")]
		public uint ranking_token_num;

		// Token: 0x040022E7 RID: 8935
		[Token(Token = "0x40022E7")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A1CC", Offset = "0x110A1CC")]
		public CoinsDetail coins_detail;

		// Token: 0x040022E8 RID: 8936
		[Token(Token = "0x40022E8")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A1E0", Offset = "0x110A1E0")]
		public ExpDetail exp_detail;

		// Token: 0x040022E9 RID: 8937
		[Token(Token = "0x40022E9")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A1F4", Offset = "0x110A1F4")]
		public PetExpDetail pet_exp_detail;

		// Token: 0x040022EA RID: 8938
		[Token(Token = "0x40022EA")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A208", Offset = "0x110A208")]
		public List<DebrisDetail> debris_detail;

		// Token: 0x040022EB RID: 8939
		[Token(Token = "0x40022EB")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A21C", Offset = "0x110A21C")]
		public List<IngameItem> ingame_items;

		// Token: 0x040022EC RID: 8940
		[Token(Token = "0x40022EC")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A230", Offset = "0x110A230")]
		public uint ranking_token_max;

		// Token: 0x040022ED RID: 8941
		[Token(Token = "0x40022ED")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A244", Offset = "0x110A244")]
		public bool is_double_ranking_point_activity;

		// Token: 0x040022EE RID: 8942
		[Token(Token = "0x40022EE")]
		[FieldOffset(Offset = "0xD5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A258", Offset = "0x110A258")]
		public bool is_double_token_activity;

		// Token: 0x040022EF RID: 8943
		[Token(Token = "0x40022EF")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A26C", Offset = "0x110A26C")]
		public uint double_ranking_point_card_id;

		// Token: 0x040022F0 RID: 8944
		[Token(Token = "0x40022F0")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A280", Offset = "0x110A280")]
		public uint chip_num;

		// Token: 0x040022F1 RID: 8945
		[Token(Token = "0x40022F1")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A294", Offset = "0x110A294")]
		public uint no_deduct_card_id;

		// Token: 0x040022F2 RID: 8946
		[Token(Token = "0x40022F2")]
		[FieldOffset(Offset = "0xE4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A2A8", Offset = "0x110A2A8")]
		public bool is_championship;

		// Token: 0x040022F3 RID: 8947
		[Token(Token = "0x40022F3")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A2BC", Offset = "0x110A2BC")]
		public uint[] linkage_award_ids;

		// Token: 0x040022F4 RID: 8948
		[Token(Token = "0x40022F4")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A2F8", Offset = "0x110A2F8")]
		public bool is_cs_rank;

		// Token: 0x040022F5 RID: 8949
		[Token(Token = "0x40022F5")]
		[FieldOffset(Offset = "0xF1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A30C", Offset = "0x110A30C")]
		public bool is_cs_rank_protect;

		// Token: 0x040022F6 RID: 8950
		[Token(Token = "0x40022F6")]
		[FieldOffset(Offset = "0xF2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A320", Offset = "0x110A320")]
		public bool is_cs_streak_bonus;

		// Token: 0x040022F7 RID: 8951
		[Token(Token = "0x40022F7")]
		[FieldOffset(Offset = "0xF4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A334", Offset = "0x110A334")]
		public float random_map_rp_param;

		// Token: 0x040022F8 RID: 8952
		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A348", Offset = "0x110A348")]
		public uint pre_cs_star_protect_points;

		// Token: 0x040022F9 RID: 8953
		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0xFC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A35C", Offset = "0x110A35C")]
		public uint cur_cs_star_protect_points;

		// Token: 0x040022FA RID: 8954
		[Token(Token = "0x40022FA")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A370", Offset = "0x110A370")]
		public bool is_cs_star_protect;

		// Token: 0x040022FB RID: 8955
		[Token(Token = "0x40022FB")]
		[FieldOffset(Offset = "0x104")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A384", Offset = "0x110A384")]
		public uint pre_br_heroic_count;

		// Token: 0x040022FC RID: 8956
		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A398", Offset = "0x110A398")]
		public uint after_br_heroic_count;

		// Token: 0x040022FD RID: 8957
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x10C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A3AC", Offset = "0x110A3AC")]
		public uint pre_cs_heroic_count;

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A3C0", Offset = "0x110A3C0")]
		public uint after_cs_heroic_count;
	}
}
