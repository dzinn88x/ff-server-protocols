using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE0 RID: 2784
	[Token(Token = "0x2000AE0")]
	[ProtoContract]
	public class ChampionshipSettingDesc
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x21B8198", Offset = "0x21B8198", VA = "0x7BBC9B8198")]
		public ChampionshipSettingDesc()
		{
		}

		// Token: 0x04003447 RID: 13383
		[Token(Token = "0x4003447")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128294", Offset = "0x1128294")]
		public uint championship_type;

		// Token: 0x04003448 RID: 13384
		[Token(Token = "0x4003448")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11282A8", Offset = "0x11282A8")]
		public uint championship_id;

		// Token: 0x04003449 RID: 13385
		[Token(Token = "0x4003449")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11282BC", Offset = "0x11282BC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11282BC", Offset = "0x11282BC")]
		public string trial_match_name;

		// Token: 0x0400344A RID: 13386
		[Token(Token = "0x400344A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112830C", Offset = "0x112830C")]
		public uint trial_match_num;

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128320", Offset = "0x1128320")]
		public uint trial_match_choose_num;

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128334", Offset = "0x1128334")]
		public uint final_match_choose_num;

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128348", Offset = "0x1128348")]
		public uint min_match_num;

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112835C", Offset = "0x112835C")]
		public uint limited_item_type;

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128370", Offset = "0x1128370")]
		public uint limited_item_id;

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128384", Offset = "0x1128384")]
		public uint limited_item_num;

		// Token: 0x04003451 RID: 13393
		[Token(Token = "0x4003451")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128398", Offset = "0x1128398")]
		public uint seniority_list;

		// Token: 0x04003452 RID: 13394
		[Token(Token = "0x4003452")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11283AC", Offset = "0x11283AC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11283AC", Offset = "0x11283AC")]
		public string clan_icon_id;

		// Token: 0x04003453 RID: 13395
		[Token(Token = "0x4003453")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11283FC", Offset = "0x11283FC")]
		public bool is_animation_open;

		// Token: 0x04003454 RID: 13396
		[Token(Token = "0x4003454")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128410", Offset = "0x1128410")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128410", Offset = "0x1128410")]
		public string login_animation_resource;

		// Token: 0x04003455 RID: 13397
		[Token(Token = "0x4003455")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128460", Offset = "0x1128460")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128460", Offset = "0x1128460")]
		public string lobby_resource;

		// Token: 0x04003456 RID: 13398
		[Token(Token = "0x4003456")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11284B0", Offset = "0x11284B0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11284B0", Offset = "0x11284B0")]
		public string homepage_resource;

		// Token: 0x04003457 RID: 13399
		[Token(Token = "0x4003457")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128500", Offset = "0x1128500")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128500", Offset = "0x1128500")]
		public string mode_name;

		// Token: 0x04003458 RID: 13400
		[Token(Token = "0x4003458")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128550", Offset = "0x1128550")]
		public bool is_result_ani_open;

		// Token: 0x04003459 RID: 13401
		[Token(Token = "0x4003459")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128564", Offset = "0x1128564")]
		public bool is_notice_open;

		// Token: 0x0400345A RID: 13402
		[Token(Token = "0x400345A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128578", Offset = "0x1128578")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128578", Offset = "0x1128578")]
		public string notice_cdn1;

		// Token: 0x0400345B RID: 13403
		[Token(Token = "0x400345B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11285C8", Offset = "0x11285C8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11285C8", Offset = "0x11285C8")]
		public string notice_cdn2;

		// Token: 0x0400345C RID: 13404
		[Token(Token = "0x400345C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128618", Offset = "0x1128618")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128618", Offset = "0x1128618")]
		public string notice_cdn3;

		// Token: 0x0400345D RID: 13405
		[Token(Token = "0x400345D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128668", Offset = "0x1128668")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128668", Offset = "0x1128668")]
		public string notice_cdn4;

		// Token: 0x0400345E RID: 13406
		[Token(Token = "0x400345E")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11286B8", Offset = "0x11286B8")]
		public bool senior_team_only;

		// Token: 0x0400345F RID: 13407
		[Token(Token = "0x400345F")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11286CC", Offset = "0x11286CC")]
		public uint team_scale_type;

		// Token: 0x04003460 RID: 13408
		[Token(Token = "0x4003460")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11286E0", Offset = "0x11286E0")]
		public uint game_mode;

		// Token: 0x04003461 RID: 13409
		[Token(Token = "0x4003461")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11286F4", Offset = "0x11286F4")]
		public bool disable_weapon_skin;

		// Token: 0x04003462 RID: 13410
		[Token(Token = "0x4003462")]
		[FieldOffset(Offset = "0xA5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128708", Offset = "0x1128708")]
		public bool is_replay_on;

		// Token: 0x04003463 RID: 13411
		[Token(Token = "0x4003463")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112871C", Offset = "0x112871C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112871C", Offset = "0x112871C")]
		public string preview_resource;

		// Token: 0x04003464 RID: 13412
		[Token(Token = "0x4003464")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112876C", Offset = "0x112876C")]
		public uint go_pos1;

		// Token: 0x04003465 RID: 13413
		[Token(Token = "0x4003465")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128780", Offset = "0x1128780")]
		public uint sub_pos1;

		// Token: 0x04003466 RID: 13414
		[Token(Token = "0x4003466")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128794", Offset = "0x1128794")]
		public uint go_pos2;

		// Token: 0x04003467 RID: 13415
		[Token(Token = "0x4003467")]
		[FieldOffset(Offset = "0xBC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11287A8", Offset = "0x11287A8")]
		public uint sub_pos2;

		// Token: 0x04003468 RID: 13416
		[Token(Token = "0x4003468")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11287BC", Offset = "0x11287BC")]
		public uint go_pos3;

		// Token: 0x04003469 RID: 13417
		[Token(Token = "0x4003469")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11287D0", Offset = "0x11287D0")]
		public uint sub_pos3;

		// Token: 0x0400346A RID: 13418
		[Token(Token = "0x400346A")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11287E4", Offset = "0x11287E4")]
		public uint go_pos4;

		// Token: 0x0400346B RID: 13419
		[Token(Token = "0x400346B")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11287F8", Offset = "0x11287F8")]
		public uint sub_pos4;

		// Token: 0x0400346C RID: 13420
		[Token(Token = "0x400346C")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112880C", Offset = "0x112880C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112880C", Offset = "0x112880C")]
		public string notice_cdn5;

		// Token: 0x0400346D RID: 13421
		[Token(Token = "0x400346D")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112885C", Offset = "0x112885C")]
		public uint go_pos5;

		// Token: 0x0400346E RID: 13422
		[Token(Token = "0x400346E")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128870", Offset = "0x1128870")]
		public uint sub_pos5;

		// Token: 0x0400346F RID: 13423
		[Token(Token = "0x400346F")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128884", Offset = "0x1128884")]
		public uint leaderboard_local_size;

		// Token: 0x04003470 RID: 13424
		[Token(Token = "0x4003470")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128898", Offset = "0x1128898")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128898", Offset = "0x1128898")]
		public string language;
	}
}
