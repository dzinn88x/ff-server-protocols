using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C7 RID: 2503
	[Token(Token = "0x20009C7")]
	[ProtoContract]
	public enum EPChallenge_Condition_Type
	{
		// Token: 0x04002CD3 RID: 11475
		[Token(Token = "0x4002CD3")]
		CH_NONE,
		// Token: 0x04002CD4 RID: 11476
		[Token(Token = "0x4002CD4")]
		CH_KILL_WEAPON,
		// Token: 0x04002CD5 RID: 11477
		[Token(Token = "0x4002CD5")]
		CH_KILL_CAR,
		// Token: 0x04002CD6 RID: 11478
		[Token(Token = "0x4002CD6")]
		CH_KILL,
		// Token: 0x04002CD7 RID: 11479
		[Token(Token = "0x4002CD7")]
		CH_DAMAGE,
		// Token: 0x04002CD8 RID: 11480
		[Token(Token = "0x4002CD8")]
		CH_GRENADE,
		// Token: 0x04002CD9 RID: 11481
		[Token(Token = "0x4002CD9")]
		CH_ITEM_COLLECT,
		// Token: 0x04002CDA RID: 11482
		[Token(Token = "0x4002CDA")]
		CH_LAND,
		// Token: 0x04002CDB RID: 11483
		[Token(Token = "0x4002CDB")]
		CH_AIRDROP,
		// Token: 0x04002CDC RID: 11484
		[Token(Token = "0x4002CDC")]
		CH_MOVE,
		// Token: 0x04002CDD RID: 11485
		[Token(Token = "0x4002CDD")]
		CH_MOVE_CAR,
		// Token: 0x04002CDE RID: 11486
		[Token(Token = "0x4002CDE")]
		CH_HP_PKG,
		// Token: 0x04002CDF RID: 11487
		[Token(Token = "0x4002CDF")]
		CH_MOVE_CAR_TIME,
		// Token: 0x04002CE0 RID: 11488
		[Token(Token = "0x4002CE0")]
		CH_MATCH_BUDDY,
		// Token: 0x04002CE1 RID: 11489
		[Token(Token = "0x4002CE1")]
		CH_MATCH,
		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		CH_SEASON_RANK_LEVEL,
		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		CH_WIN,
		// Token: 0x04002CE4 RID: 11492
		[Token(Token = "0x4002CE4")]
		CH_RANK_OVER,
		// Token: 0x04002CE5 RID: 11493
		[Token(Token = "0x4002CE5")]
		CH_MATCH_TIME,
		// Token: 0x04002CE6 RID: 11494
		[Token(Token = "0x4002CE6")]
		CH_MATCH_CLAN,
		// Token: 0x04002CE7 RID: 11495
		[Token(Token = "0x4002CE7")]
		CH_SURVIVAL_TIME,
		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		CH_LOADOUT,
		// Token: 0x04002CE9 RID: 11497
		[Token(Token = "0x4002CE9")]
		CH_CAREPACKAGE,
		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		CH_TREASURE,
		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		CH_KILL_HEADSHOT,
		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		CH_LOTTERY,
		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		CH_KIll_SWIMMING,
		// Token: 0x04002CEE RID: 11502
		[Token(Token = "0x4002CEE")]
		CH_MOVE_SWIM,
		// Token: 0x04002CEF RID: 11503
		[Token(Token = "0x4002CEF")]
		CH_DAMAGE_STROP,
		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		CH_KILL_WEAPON_SKIN,
		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		CH_KILL_DAMAGE_SKIN,
		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		CH_REVIVAL,
		// Token: 0x04002CF3 RID: 11507
		[Token(Token = "0x4002CF3")]
		CH_KILL_ORDER,
		// Token: 0x04002CF4 RID: 11508
		[Token(Token = "0x4002CF4")]
		CH_MOVE_STROP,
		// Token: 0x04002CF5 RID: 11509
		[Token(Token = "0x4002CF5")]
		CH_KILL_WEAPON_HEAD,
		// Token: 0x04002CF6 RID: 11510
		[Token(Token = "0x4002CF6")]
		CH_DAMAGE_WEAPON,
		// Token: 0x04002CF7 RID: 11511
		[Token(Token = "0x4002CF7")]
		CH_KILL_OILDRUM,
		// Token: 0x04002CF8 RID: 11512
		[Token(Token = "0x4002CF8")]
		CH_KILL_VEHICLE_EXPLODE,
		// Token: 0x04002CF9 RID: 11513
		[Token(Token = "0x4002CF9")]
		CH_RANK_NO_KILL,
		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		CH_RANK_NO_DAMAGE,
		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		CH_KILL_CAMOUFLAGE,
		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		CH_ICE_WALL,
		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		CH_KILL_VEHICLE,
		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		CH_KILL_POSE,
		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		CH_SMOG_OIL_DRUM,
		// Token: 0x04002D00 RID: 11520
		[Token(Token = "0x4002D00")]
		CH_KILL_UAV,
		// Token: 0x04002D01 RID: 11521
		[Token(Token = "0x4002D01")]
		CH_DIFF_DBOX,
		// Token: 0x04002D02 RID: 11522
		[Token(Token = "0x4002D02")]
		CH_EMOTE,
		// Token: 0x04002D03 RID: 11523
		[Token(Token = "0x4002D03")]
		CH_KILL_DISTANCE,
		// Token: 0x04002D04 RID: 11524
		[Token(Token = "0x4002D04")]
		CH_LOCATION_LAND,
		// Token: 0x04002D05 RID: 11525
		[Token(Token = "0x4002D05")]
		CH_LOCATION_KILL,
		// Token: 0x04002D06 RID: 11526
		[Token(Token = "0x4002D06")]
		CH_LOCATION_DAMAGE,
		// Token: 0x04002D07 RID: 11527
		[Token(Token = "0x4002D07")]
		CH_LOCATION_KILL_WEAPON,
		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		CH_LOCATION_EMOTE,
		// Token: 0x04002D09 RID: 11529
		[Token(Token = "0x4002D09")]
		CH_LOCATION_VEHICLE,
		// Token: 0x04002D0A RID: 11530
		[Token(Token = "0x4002D0A")]
		CH_LOCATION_REVIVAL,
		// Token: 0x04002D0B RID: 11531
		[Token(Token = "0x4002D0B")]
		CH_START_KILL,
		// Token: 0x04002D0C RID: 11532
		[Token(Token = "0x4002D0C")]
		CH_END_KILL,
		// Token: 0x04002D0D RID: 11533
		[Token(Token = "0x4002D0D")]
		CH_DAMAGE_OILDRUM,
		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		CH_KILL_LOW_HP,
		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		CH_KILL_HIGH,
		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		CH_DAMAGE_HIGH,
		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		CH_DAMAGE_DIFF_WEAPON,
		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		CH_WEAPON_DISTANCE,
		// Token: 0x04002D13 RID: 11539
		[Token(Token = "0x4002D13")]
		CH_KILL_DISTANCE_WEAPON,
		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		CH_RANK_MAP,
		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		CH_TEAMMATE_KILL,
		// Token: 0x04002D16 RID: 11542
		[Token(Token = "0x4002D16")]
		CH_TEAMMATE_DAMAGE,
		// Token: 0x04002D17 RID: 11543
		[Token(Token = "0x4002D17")]
		CH_TEAMMATE_HP_PKG,
		// Token: 0x04002D18 RID: 11544
		[Token(Token = "0x4002D18")]
		CH_TEAMMATE_HEADSHOTKILL,
		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		CH_LOGIN,
		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		CH_RESTORE = 72,
		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		CH_BE_RESTORED
	}
}
