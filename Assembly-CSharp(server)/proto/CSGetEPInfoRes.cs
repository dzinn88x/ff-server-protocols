using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200087E RID: 2174
	[Token(Token = "0x200087E")]
	[ProtoContract]
	public class CSGetEPInfoRes
	{
		// Token: 0x0600258C RID: 9612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258C")]
		[Address(RVA = "0x21B31E8", Offset = "0x21B31E8", VA = "0x7BBC9B31E8")]
		public CSGetEPInfoRes()
		{
		}

		// Token: 0x040028A3 RID: 10403
		[Token(Token = "0x40028A3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113628", Offset = "0x1113628")]
		public bool owned_pass;

		// Token: 0x040028A4 RID: 10404
		[Token(Token = "0x40028A4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111363C", Offset = "0x111363C")]
		public List<RewardStatus> rewards;

		// Token: 0x040028A5 RID: 10405
		[Token(Token = "0x40028A5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113650", Offset = "0x1113650")]
		public List<ChallengeStatus> challenges;

		// Token: 0x040028A6 RID: 10406
		[Token(Token = "0x40028A6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113664", Offset = "0x1113664")]
		public uint ep_event_id;

		// Token: 0x040028A7 RID: 10407
		[Token(Token = "0x40028A7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113678", Offset = "0x1113678")]
		public long start_time;

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111368C", Offset = "0x111368C")]
		public long end_time;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11136A0", Offset = "0x11136A0")]
		public uint ep_badge;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11136B4", Offset = "0x11136B4")]
		public uint gold_limit_improved;

		// Token: 0x040028AB RID: 10411
		[Token(Token = "0x40028AB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11136C8", Offset = "0x11136C8")]
		public uint fp_challenge_item;

		// Token: 0x040028AC RID: 10412
		[Token(Token = "0x40028AC")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11136DC", Offset = "0x11136DC")]
		public bool owned_fp_challenge;

		// Token: 0x040028AD RID: 10413
		[Token(Token = "0x40028AD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11136F0", Offset = "0x11136F0")]
		public uint purchase_badge_count_today;

		// Token: 0x040028AE RID: 10414
		[Token(Token = "0x40028AE")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113704", Offset = "0x1113704")]
		public uint week;

		// Token: 0x040028AF RID: 10415
		[Token(Token = "0x40028AF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113718", Offset = "0x1113718")]
		public long daily_reset_time;

		// Token: 0x040028B0 RID: 10416
		[Token(Token = "0x40028B0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111372C", Offset = "0x111372C")]
		public uint epid_preorder;

		// Token: 0x040028B1 RID: 10417
		[Token(Token = "0x40028B1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113740", Offset = "0x1113740")]
		public long ep_preorder_start_time;

		// Token: 0x040028B2 RID: 10418
		[Token(Token = "0x40028B2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113754", Offset = "0x1113754")]
		public long ep_preorder_end_time;

		// Token: 0x040028B3 RID: 10419
		[Token(Token = "0x40028B3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113768", Offset = "0x1113768")]
		public uint daily_challenge_completed_cnt;

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111377C", Offset = "0x111377C")]
		public uint elite_challenge_completed_cnt;

		// Token: 0x040028B5 RID: 10421
		[Token(Token = "0x40028B5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113790", Offset = "0x1113790")]
		public uint veteran_challenge_completed_cnt;

		// Token: 0x040028B6 RID: 10422
		[Token(Token = "0x40028B6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11137A4", Offset = "0x11137A4")]
		public long subscription_start_time;

		// Token: 0x040028B7 RID: 10423
		[Token(Token = "0x40028B7")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11137B8", Offset = "0x11137B8")]
		public long subscription_end_time;

		// Token: 0x040028B8 RID: 10424
		[Token(Token = "0x40028B8")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11137CC", Offset = "0x11137CC")]
		public uint purchase_ep_count;

		// Token: 0x040028B9 RID: 10425
		[Token(Token = "0x40028B9")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11137E0", Offset = "0x11137E0")]
		public uint ep_max_reward_claimed_badge;

		// Token: 0x040028BA RID: 10426
		[Token(Token = "0x40028BA")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11137F4", Offset = "0x11137F4")]
		public List<DailyQuestRewardsStatus> daily_rewards_status;

		// Token: 0x040028BB RID: 10427
		[Token(Token = "0x40028BB")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113808", Offset = "0x1113808")]
		public List<WeeklyProcess> weekly_process;
	}
}
