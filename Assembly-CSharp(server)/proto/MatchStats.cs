using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F8 RID: 1784
	[Token(Token = "0x20006F8")]
	[ProtoContract]
	public class MatchStats
	{
		// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x21BC5D8", Offset = "0x21BC5D8", VA = "0x7BBC9BC5D8")]
		public MatchStats()
		{
		}

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A3D4", Offset = "0x110A3D4")]
		public ulong account_id;

		// Token: 0x04002300 RID: 8960
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A3E8", Offset = "0x110A3E8")]
		public ulong group_id;

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A3FC", Offset = "0x110A3FC")]
		public uint survival_time;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A410", Offset = "0x110A410")]
		public uint rank;

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A424", Offset = "0x110A424")]
		public uint kills;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A438", Offset = "0x110A438")]
		public uint damage;

		// Token: 0x04002305 RID: 8965
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A44C", Offset = "0x110A44C")]
		public uint moving_distance;

		// Token: 0x04002306 RID: 8966
		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A460", Offset = "0x110A460")]
		public uint revival_count;

		// Token: 0x04002307 RID: 8967
		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A474", Offset = "0x110A474")]
		public uint vehicle_kills;

		// Token: 0x04002308 RID: 8968
		[Token(Token = "0x4002308")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A488", Offset = "0x110A488")]
		public uint headshot_count;

		// Token: 0x04002309 RID: 8969
		[Token(Token = "0x4002309")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A49C", Offset = "0x110A49C")]
		public uint headshot_kills;

		// Token: 0x0400230A RID: 8970
		[Token(Token = "0x400230A")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A4B0", Offset = "0x110A4B0")]
		public uint knockdown_count;

		// Token: 0x0400230B RID: 8971
		[Token(Token = "0x400230B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A4C4", Offset = "0x110A4C4")]
		public uint pickup_count;

		// Token: 0x0400230C RID: 8972
		[Token(Token = "0x400230C")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A4D8", Offset = "0x110A4D8")]
		public uint assists;

		// Token: 0x0400230D RID: 8973
		[Token(Token = "0x400230D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A4EC", Offset = "0x110A4EC")]
		public bool is_survive;

		// Token: 0x0400230E RID: 8974
		[Token(Token = "0x400230E")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A500", Offset = "0x110A500")]
		public uint out_index;

		// Token: 0x0400230F RID: 8975
		[Token(Token = "0x400230F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A514", Offset = "0x110A514")]
		public int ranking_points;

		// Token: 0x04002310 RID: 8976
		[Token(Token = "0x4002310")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A528", Offset = "0x110A528")]
		public MatchPlayer killer;

		// Token: 0x04002311 RID: 8977
		[Token(Token = "0x4002311")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A53C", Offset = "0x110A53C")]
		public List<MatchPlayer> killed_players;

		// Token: 0x04002312 RID: 8978
		[Token(Token = "0x4002312")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A550", Offset = "0x110A550")]
		public uint down_count;

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A564", Offset = "0x110A564")]
		public uint[] achievements;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A5A0", Offset = "0x110A5A0")]
		public uint kill_bots;

		// Token: 0x04002315 RID: 8981
		[Token(Token = "0x4002315")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A5B4", Offset = "0x110A5B4")]
		public bool enable_achievements;

		// Token: 0x04002316 RID: 8982
		[Token(Token = "0x4002316")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A5C8", Offset = "0x110A5C8")]
		public uint avatar_id;

		// Token: 0x04002317 RID: 8983
		[Token(Token = "0x4002317")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A5DC", Offset = "0x110A5DC")]
		public List<TeammateStats> teammates;

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A5F0", Offset = "0x110A5F0")]
		public int avg_ranking_points;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A604", Offset = "0x110A604")]
		public uint fratricide_damage;

		// Token: 0x0400231A RID: 8986
		[Token(Token = "0x400231A")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A618", Offset = "0x110A618")]
		public uint direct_kills;

		// Token: 0x0400231B RID: 8987
		[Token(Token = "0x400231B")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A62C", Offset = "0x110A62C")]
		public uint group_mode;

		// Token: 0x0400231C RID: 8988
		[Token(Token = "0x400231C")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A640", Offset = "0x110A640")]
		public uint match_mode;

		// Token: 0x0400231D RID: 8989
		[Token(Token = "0x400231D")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A654", Offset = "0x110A654")]
		public uint player_count;

		// Token: 0x0400231E RID: 8990
		[Token(Token = "0x400231E")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A668", Offset = "0x110A668")]
		public uint banner_id;

		// Token: 0x0400231F RID: 8991
		[Token(Token = "0x400231F")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A67C", Offset = "0x110A67C")]
		public uint head_pic;

		// Token: 0x04002320 RID: 8992
		[Token(Token = "0x4002320")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110A690", Offset = "0x110A690")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A690", Offset = "0x110A690")]
		public string clan_name;

		// Token: 0x04002321 RID: 8993
		[Token(Token = "0x4002321")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A6E0", Offset = "0x110A6E0")]
		public uint level;

		// Token: 0x04002322 RID: 8994
		[Token(Token = "0x4002322")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A6F4", Offset = "0x110A6F4")]
		public uint season_rank;

		// Token: 0x04002323 RID: 8995
		[Token(Token = "0x4002323")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A708", Offset = "0x110A708")]
		public uint game_mode;

		// Token: 0x04002324 RID: 8996
		[Token(Token = "0x4002324")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A71C", Offset = "0x110A71C")]
		public uint map_id;

		// Token: 0x04002325 RID: 8997
		[Token(Token = "0x4002325")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A730", Offset = "0x110A730")]
		public bool has_elite_pass;

		// Token: 0x04002326 RID: 8998
		[Token(Token = "0x4002326")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A744", Offset = "0x110A744")]
		public uint badge_id;

		// Token: 0x04002327 RID: 8999
		[Token(Token = "0x4002327")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A758", Offset = "0x110A758")]
		public uint badge_cnt;

		// Token: 0x04002328 RID: 9000
		[Token(Token = "0x4002328")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A76C", Offset = "0x110A76C")]
		public uint[] clothes_id;

		// Token: 0x04002329 RID: 9001
		[Token(Token = "0x4002329")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A7A8", Offset = "0x110A7A8")]
		public ulong real_group_id;

		// Token: 0x0400232A RID: 9002
		[Token(Token = "0x400232A")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A7BC", Offset = "0x110A7BC")]
		public uint ep_goldlimit_bonus;

		// Token: 0x0400232B RID: 9003
		[Token(Token = "0x400232B")]
		[FieldOffset(Offset = "0xF4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A7D0", Offset = "0x110A7D0")]
		public uint liked;

		// Token: 0x0400232C RID: 9004
		[Token(Token = "0x400232C")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A7E4", Offset = "0x110A7E4")]
		public uint real_player_rank;

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0xFC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A7F8", Offset = "0x110A7F8")]
		public uint real_player_count;

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A80C", Offset = "0x110A80C")]
		public bool show_rank;

		// Token: 0x0400232F RID: 9007
		[Token(Token = "0x400232F")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A820", Offset = "0x110A820")]
		public List<RedEnvelope> use_red_envelope;

		// Token: 0x04002330 RID: 9008
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A834", Offset = "0x110A834")]
		public List<ReceivedRedEnvelope> received_red_envelope;

		// Token: 0x04002331 RID: 9009
		[Token(Token = "0x4002331")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A848", Offset = "0x110A848")]
		public uint pet_id;

		// Token: 0x04002332 RID: 9010
		[Token(Token = "0x4002332")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A85C", Offset = "0x110A85C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110A85C", Offset = "0x110A85C")]
		public string pet_name;

		// Token: 0x04002333 RID: 9011
		[Token(Token = "0x4002333")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A8AC", Offset = "0x110A8AC")]
		public List<Item> ingame_items;

		// Token: 0x04002334 RID: 9012
		[Token(Token = "0x4002334")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A8C0", Offset = "0x110A8C0")]
		public uint difficulty;

		// Token: 0x04002335 RID: 9013
		[Token(Token = "0x4002335")]
		[FieldOffset(Offset = "0x134")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A8D4", Offset = "0x110A8D4")]
		public uint ai_type;

		// Token: 0x04002336 RID: 9014
		[Token(Token = "0x4002336")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A8E8", Offset = "0x110A8E8")]
		public uint pve_primary_weapon_skin;

		// Token: 0x04002337 RID: 9015
		[Token(Token = "0x4002337")]
		[FieldOffset(Offset = "0x13C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A8FC", Offset = "0x110A8FC")]
		public uint pet_skin_id;

		// Token: 0x04002338 RID: 9016
		[Token(Token = "0x4002338")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A910", Offset = "0x110A910")]
		public ReviveTokenUsed used_revive_tokens;

		// Token: 0x04002339 RID: 9017
		[Token(Token = "0x4002339")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A924", Offset = "0x110A924")]
		public uint hack_reason;

		// Token: 0x0400233A RID: 9018
		[Token(Token = "0x400233A")]
		[FieldOffset(Offset = "0x14C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A938", Offset = "0x110A938")]
		public bool sit_on_throne;

		// Token: 0x0400233B RID: 9019
		[Token(Token = "0x400233B")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A94C", Offset = "0x110A94C")]
		public EStats.WinnerTakesAllCurrencyType wta_curr_type;

		// Token: 0x0400233C RID: 9020
		[Token(Token = "0x400233C")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A960", Offset = "0x110A960")]
		public WarmGameInfo warm_game;

		// Token: 0x0400233D RID: 9021
		[Token(Token = "0x400233D")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A974", Offset = "0x110A974")]
		public uint role;

		// Token: 0x0400233E RID: 9022
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0x164")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A988", Offset = "0x110A988")]
		public uint championship_type;

		// Token: 0x0400233F RID: 9023
		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x168")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A99C", Offset = "0x110A99C")]
		public LinkageInfo linkage_info;

		// Token: 0x04002340 RID: 9024
		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x170")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A9B0", Offset = "0x110A9B0")]
		public uint revenge_success_times;

		// Token: 0x04002341 RID: 9025
		[Token(Token = "0x4002341")]
		[FieldOffset(Offset = "0x174")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A9C4", Offset = "0x110A9C4")]
		public uint game_round;

		// Token: 0x04002342 RID: 9026
		[Token(Token = "0x4002342")]
		[FieldOffset(Offset = "0x178")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110A9D8", Offset = "0x110A9D8")]
		public uint[] teams_game_point;

		// Token: 0x04002343 RID: 9027
		[Token(Token = "0x4002343")]
		[FieldOffset(Offset = "0x180")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AA14", Offset = "0x110AA14")]
		public List<TeammateStats> opponents;

		// Token: 0x04002344 RID: 9028
		[Token(Token = "0x4002344")]
		[FieldOffset(Offset = "0x188")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AA28", Offset = "0x110AA28")]
		public EAuth.ClientUsingVersion using_version;

		// Token: 0x04002345 RID: 9029
		[Token(Token = "0x4002345")]
		[FieldOffset(Offset = "0x18C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AA3C", Offset = "0x110AA3C")]
		public uint real_damage;

		// Token: 0x04002346 RID: 9030
		[Token(Token = "0x4002346")]
		[FieldOffset(Offset = "0x190")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AA50", Offset = "0x110AA50")]
		public uint settle_bomb;

		// Token: 0x04002347 RID: 9031
		[Token(Token = "0x4002347")]
		[FieldOffset(Offset = "0x194")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AA64", Offset = "0x110AA64")]
		public uint remove_bomb;

		// Token: 0x04002348 RID: 9032
		[Token(Token = "0x4002348")]
		[FieldOffset(Offset = "0x198")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AA78", Offset = "0x110AA78")]
		public uint deaths;

		// Token: 0x04002349 RID: 9033
		[Token(Token = "0x4002349")]
		[FieldOffset(Offset = "0x19C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AA8C", Offset = "0x110AA8C")]
		public uint mvp_count;

		// Token: 0x0400234A RID: 9034
		[Token(Token = "0x400234A")]
		[FieldOffset(Offset = "0x1A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AAA0", Offset = "0x110AAA0")]
		public uint double_kills;

		// Token: 0x0400234B RID: 9035
		[Token(Token = "0x400234B")]
		[FieldOffset(Offset = "0x1A4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AAB4", Offset = "0x110AAB4")]
		public uint triple_kills;

		// Token: 0x0400234C RID: 9036
		[Token(Token = "0x400234C")]
		[FieldOffset(Offset = "0x1A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AAC8", Offset = "0x110AAC8")]
		public uint four_kills;

		// Token: 0x0400234D RID: 9037
		[Token(Token = "0x400234D")]
		[FieldOffset(Offset = "0x1AC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AADC", Offset = "0x110AADC")]
		public uint newbie_choice;

		// Token: 0x0400234E RID: 9038
		[Token(Token = "0x400234E")]
		[FieldOffset(Offset = "0x1B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AAF0", Offset = "0x110AAF0")]
		public uint pin_id;

		// Token: 0x0400234F RID: 9039
		[Token(Token = "0x400234F")]
		[FieldOffset(Offset = "0x1B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB04", Offset = "0x110AB04")]
		public uint cs_ranking_hang_ups;

		// Token: 0x04002350 RID: 9040
		[Token(Token = "0x4002350")]
		[FieldOffset(Offset = "0x1B8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB18", Offset = "0x110AB18")]
		public uint random_map_cnt;

		// Token: 0x04002351 RID: 9041
		[Token(Token = "0x4002351")]
		[FieldOffset(Offset = "0x1BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB2C", Offset = "0x110AB2C")]
		public int cs_star_protect_points;

		// Token: 0x04002352 RID: 9042
		[Token(Token = "0x4002352")]
		[FieldOffset(Offset = "0x1C0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB40", Offset = "0x110AB40")]
		public uint hacker_tag;

		// Token: 0x04002353 RID: 9043
		[Token(Token = "0x4002353")]
		[FieldOffset(Offset = "0x1C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB54", Offset = "0x110AB54")]
		public uint banned_duration;

		// Token: 0x04002354 RID: 9044
		[Token(Token = "0x4002354")]
		[FieldOffset(Offset = "0x1C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB68", Offset = "0x110AB68")]
		public bool online_cs_rank_settle;

		// Token: 0x04002355 RID: 9045
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x1CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB7C", Offset = "0x110AB7C")]
		public uint battle_time;

		// Token: 0x04002356 RID: 9046
		[Token(Token = "0x4002356")]
		[FieldOffset(Offset = "0x1D0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AB90", Offset = "0x110AB90")]
		public uint society_time;

		// Token: 0x04002357 RID: 9047
		[Token(Token = "0x4002357")]
		[FieldOffset(Offset = "0x1D4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ABA4", Offset = "0x110ABA4")]
		public bool is_cs_rank_draw;

		// Token: 0x04002358 RID: 9048
		[Token(Token = "0x4002358")]
		[FieldOffset(Offset = "0x1D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ABB8", Offset = "0x110ABB8")]
		public uint num_kill_smaller_than_1m;

		// Token: 0x04002359 RID: 9049
		[Token(Token = "0x4002359")]
		[FieldOffset(Offset = "0x1DC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ABCC", Offset = "0x110ABCC")]
		public uint num_kill_smaller_than_2m;

		// Token: 0x0400235A RID: 9050
		[Token(Token = "0x400235A")]
		[FieldOffset(Offset = "0x1E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ABE0", Offset = "0x110ABE0")]
		public uint num_kill_greater_than_10m;

		// Token: 0x0400235B RID: 9051
		[Token(Token = "0x400235B")]
		[FieldOffset(Offset = "0x1E4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ABF4", Offset = "0x110ABF4")]
		public uint num_kill_greater_than_50m;

		// Token: 0x0400235C RID: 9052
		[Token(Token = "0x400235C")]
		[FieldOffset(Offset = "0x1E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC08", Offset = "0x110AC08")]
		public uint num_kill_greater_than_100m;

		// Token: 0x0400235D RID: 9053
		[Token(Token = "0x400235D")]
		[FieldOffset(Offset = "0x1EC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC1C", Offset = "0x110AC1C")]
		public uint num_kill_greater_than_500m;

		// Token: 0x0400235E RID: 9054
		[Token(Token = "0x400235E")]
		[FieldOffset(Offset = "0x1F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC30", Offset = "0x110AC30")]
		public uint num_different_weapon_kill;

		// Token: 0x0400235F RID: 9055
		[Token(Token = "0x400235F")]
		[FieldOffset(Offset = "0x1F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC44", Offset = "0x110AC44")]
		public uint num_kill_better_rank_player;

		// Token: 0x04002360 RID: 9056
		[Token(Token = "0x4002360")]
		[FieldOffset(Offset = "0x1F8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC58", Offset = "0x110AC58")]
		public uint avg_kill_rest_hp;

		// Token: 0x04002361 RID: 9057
		[Token(Token = "0x4002361")]
		[FieldOffset(Offset = "0x1FC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC6C", Offset = "0x110AC6C")]
		public uint total_shot;

		// Token: 0x04002362 RID: 9058
		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0x200")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC80", Offset = "0x110AC80")]
		public bool has_swum;

		// Token: 0x04002363 RID: 9059
		[Token(Token = "0x4002363")]
		[FieldOffset(Offset = "0x204")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AC94", Offset = "0x110AC94")]
		public uint grenade_use;

		// Token: 0x04002364 RID: 9060
		[Token(Token = "0x4002364")]
		[FieldOffset(Offset = "0x208")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ACA8", Offset = "0x110ACA8")]
		public uint kill_swimming_count;

		// Token: 0x04002365 RID: 9061
		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0x20C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ACBC", Offset = "0x110ACBC")]
		public uint medkit_use;

		// Token: 0x04002366 RID: 9062
		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0x210")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ACD0", Offset = "0x110ACD0")]
		public uint mushroom_recovery;

		// Token: 0x04002367 RID: 9063
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x214")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ACE4", Offset = "0x110ACE4")]
		public uint mushroom_use;

		// Token: 0x04002368 RID: 9064
		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0x218")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ACF8", Offset = "0x110ACF8")]
		public uint ob_count;

		// Token: 0x04002369 RID: 9065
		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x21C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD0C", Offset = "0x110AD0C")]
		public uint offline_seconds;

		// Token: 0x0400236A RID: 9066
		[Token(Token = "0x400236A")]
		[FieldOffset(Offset = "0x220")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD20", Offset = "0x110AD20")]
		public uint offline_times;

		// Token: 0x0400236B RID: 9067
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0x224")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD34", Offset = "0x110AD34")]
		public uint vehicle_time;

		// Token: 0x0400236C RID: 9068
		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0x228")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD48", Offset = "0x110AD48")]
		public uint strop_use_count;

		// Token: 0x0400236D RID: 9069
		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0x22C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD5C", Offset = "0x110AD5C")]
		public float aim_rot_speed;

		// Token: 0x0400236E RID: 9070
		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0x230")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD70", Offset = "0x110AD70")]
		public float auto_aim_count;

		// Token: 0x0400236F RID: 9071
		[Token(Token = "0x400236F")]
		[FieldOffset(Offset = "0x238")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD84", Offset = "0x110AD84")]
		public GainedTrainingToken gained_training_token;

		// Token: 0x04002370 RID: 9072
		[Token(Token = "0x4002370")]
		[FieldOffset(Offset = "0x240")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AD98", Offset = "0x110AD98")]
		public uint[] kills_distance;

		// Token: 0x04002371 RID: 9073
		[Token(Token = "0x4002371")]
		[FieldOffset(Offset = "0x248")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ADD4", Offset = "0x110ADD4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110ADD4", Offset = "0x110ADD4")]
		public string group_name;

		// Token: 0x04002372 RID: 9074
		[Token(Token = "0x4002372")]
		[FieldOffset(Offset = "0x250")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AE24", Offset = "0x110AE24")]
		public uint group_icon;

		// Token: 0x04002373 RID: 9075
		[Token(Token = "0x4002373")]
		[FieldOffset(Offset = "0x258")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AE38", Offset = "0x110AE38")]
		public uint[] battle_tags;

		// Token: 0x04002374 RID: 9076
		[Token(Token = "0x4002374")]
		[FieldOffset(Offset = "0x260")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AE74", Offset = "0x110AE74")]
		public uint restore_count;

		// Token: 0x04002375 RID: 9077
		[Token(Token = "0x4002375")]
		[FieldOffset(Offset = "0x264")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110AE88", Offset = "0x110AE88")]
		public uint be_restored_count;
	}
}
