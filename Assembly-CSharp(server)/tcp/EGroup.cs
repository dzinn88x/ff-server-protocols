using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	[ProtoContract]
	public class EGroup
	{
		// Token: 0x06001D14 RID: 7444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x24A2D40", Offset = "0x24A2D40", VA = "0x7BBCCA2D40")]
		public EGroup()
		{
		}

		// Token: 0x0200048A RID: 1162
		[Token(Token = "0x200048A")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001543 RID: 5443
			[Token(Token = "0x4001543")]
			Proto_NONE,
			// Token: 0x04001544 RID: 5444
			[Token(Token = "0x4001544")]
			Proto_CREATE,
			// Token: 0x04001545 RID: 5445
			[Token(Token = "0x4001545")]
			Proto_INVITE,
			// Token: 0x04001546 RID: 5446
			[Token(Token = "0x4001546")]
			Proto_INVITE_NTF,
			// Token: 0x04001547 RID: 5447
			[Token(Token = "0x4001547")]
			Proto_ACCEPT,
			// Token: 0x04001548 RID: 5448
			[Token(Token = "0x4001548")]
			Proto_REFUSE,
			// Token: 0x04001549 RID: 5449
			[Token(Token = "0x4001549")]
			Proto_JOIN_NTF,
			// Token: 0x0400154A RID: 5450
			[Token(Token = "0x400154A")]
			Proto_LEAVE,
			// Token: 0x0400154B RID: 5451
			[Token(Token = "0x400154B")]
			Proto_LEAVE_NTF,
			// Token: 0x0400154C RID: 5452
			[Token(Token = "0x400154C")]
			Proto_START,
			// Token: 0x0400154D RID: 5453
			[Token(Token = "0x400154D")]
			Proto_START_NTF,
			// Token: 0x0400154E RID: 5454
			[Token(Token = "0x400154E")]
			Proto_STOP,
			// Token: 0x0400154F RID: 5455
			[Token(Token = "0x400154F")]
			Proto_STOP_NTF,
			// Token: 0x04001550 RID: 5456
			[Token(Token = "0x4001550")]
			Proto_DISMISS_NTF,
			// Token: 0x04001551 RID: 5457
			[Token(Token = "0x4001551")]
			Proto_GROUPINFO,
			// Token: 0x04001552 RID: 5458
			[Token(Token = "0x4001552")]
			Proto_READY,
			// Token: 0x04001553 RID: 5459
			[Token(Token = "0x4001553")]
			Proto_READY_NTF,
			// Token: 0x04001554 RID: 5460
			[Token(Token = "0x4001554")]
			Proto_CHANGE,
			// Token: 0x04001555 RID: 5461
			[Token(Token = "0x4001555")]
			Proto_CHANGE_NTF,
			// Token: 0x04001556 RID: 5462
			[Token(Token = "0x4001556")]
			Proto_JOINROOM,
			// Token: 0x04001557 RID: 5463
			[Token(Token = "0x4001557")]
			Proto_SPECTATEROOM,
			// Token: 0x04001558 RID: 5464
			[Token(Token = "0x4001558")]
			Proto_SHOWEMOTE,
			// Token: 0x04001559 RID: 5465
			[Token(Token = "0x4001559")]
			Proto_SHOWEMOTE_NTF,
			// Token: 0x0400155A RID: 5466
			[Token(Token = "0x400155A")]
			Proto_SHOWPETACTION,
			// Token: 0x0400155B RID: 5467
			[Token(Token = "0x400155B")]
			Proto_SHOWPETACTION_NTF,
			// Token: 0x0400155C RID: 5468
			[Token(Token = "0x400155C")]
			Proto_CHECKPLAYER,
			// Token: 0x0400155D RID: 5469
			[Token(Token = "0x400155D")]
			Proto_ANTIADDICTION_NFT,
			// Token: 0x0400155E RID: 5470
			[Token(Token = "0x400155E")]
			proto_TEAMMATEHEATING_NFT,
			// Token: 0x0400155F RID: 5471
			[Token(Token = "0x400155F")]
			Proto_CHANGEMAP_NTF,
			// Token: 0x04001560 RID: 5472
			[Token(Token = "0x4001560")]
			Proto_CHANGEAVAILABLEMAPS,
			// Token: 0x04001561 RID: 5473
			[Token(Token = "0x4001561")]
			Proto_CHANGEAVAILABLEMAPS_NTF,
			// Token: 0x04001562 RID: 5474
			[Token(Token = "0x4001562")]
			Proto_GETGROUPCODE,
			// Token: 0x04001563 RID: 5475
			[Token(Token = "0x4001563")]
			Proto_GETGROUPCODE_NTF,
			// Token: 0x04001564 RID: 5476
			[Token(Token = "0x4001564")]
			Proto_JOIN,
			// Token: 0x04001565 RID: 5477
			[Token(Token = "0x4001565")]
			Proto_JOINREQUEST_NTF,
			// Token: 0x04001566 RID: 5478
			[Token(Token = "0x4001566")]
			Proto_KICKOUT,
			// Token: 0x04001567 RID: 5479
			[Token(Token = "0x4001567")]
			Proto_CHANGEPUBPVT,
			// Token: 0x04001568 RID: 5480
			[Token(Token = "0x4001568")]
			Proto_CHANGEPUBPVT_NTF,
			// Token: 0x04001569 RID: 5481
			[Token(Token = "0x4001569")]
			Proto_ACCEPTJOIN,
			// Token: 0x0400156A RID: 5482
			[Token(Token = "0x400156A")]
			Proto_CSRANKINGBAN_NTF
		}

		// Token: 0x0200048B RID: 1163
		[Token(Token = "0x200048B")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x0400156C RID: 5484
			[Token(Token = "0x400156C")]
			ErrCode_SUSS,
			// Token: 0x0400156D RID: 5485
			[Token(Token = "0x400156D")]
			ErrCode_GROUPEXISTED,
			// Token: 0x0400156E RID: 5486
			[Token(Token = "0x400156E")]
			ErrCode_NOGROUP,
			// Token: 0x0400156F RID: 5487
			[Token(Token = "0x400156F")]
			ErrCode_ALREADYINVITED,
			// Token: 0x04001570 RID: 5488
			[Token(Token = "0x4001570")]
			ErrCode_NOTINVITED,
			// Token: 0x04001571 RID: 5489
			[Token(Token = "0x4001571")]
			ErrCode_REACHMAXINVITEE,
			// Token: 0x04001572 RID: 5490
			[Token(Token = "0x4001572")]
			ErrCode_ALREADYINGROUP,
			// Token: 0x04001573 RID: 5491
			[Token(Token = "0x4001573")]
			ErrCode_NOTINGROUP,
			// Token: 0x04001574 RID: 5492
			[Token(Token = "0x4001574")]
			ErrCode_REACHMAXMEMBER,
			// Token: 0x04001575 RID: 5493
			[Token(Token = "0x4001575")]
			ErrCode_GROUPINGAME,
			// Token: 0x04001576 RID: 5494
			[Token(Token = "0x4001576")]
			ErrCode_GROUPNOTINGAME,
			// Token: 0x04001577 RID: 5495
			[Token(Token = "0x4001577")]
			ErrCode_CANNOTINVITESELF,
			// Token: 0x04001578 RID: 5496
			[Token(Token = "0x4001578")]
			ErrCode_CANNOTINVITEOTHERREGION,
			// Token: 0x04001579 RID: 5497
			[Token(Token = "0x4001579")]
			ErrCode_GROUPNOTREADY,
			// Token: 0x0400157A RID: 5498
			[Token(Token = "0x400157A")]
			ErrCode_INVALIDGROUPMODE,
			// Token: 0x0400157B RID: 5499
			[Token(Token = "0x400157B")]
			ErrCode_AUTOGROUPTIMEOUT,
			// Token: 0x0400157C RID: 5500
			[Token(Token = "0x400157C")]
			ErrCode_NOSUCHPOOL,
			// Token: 0x0400157D RID: 5501
			[Token(Token = "0x400157D")]
			ErrCode_CREATEGROUPFAIL,
			// Token: 0x0400157E RID: 5502
			[Token(Token = "0x400157E")]
			ErrCode_INVALIDRANDOMMAPCONFIG,
			// Token: 0x0400157F RID: 5503
			[Token(Token = "0x400157F")]
			ErrCode_INVITEEALREADYINGROUP,
			// Token: 0x04001580 RID: 5504
			[Token(Token = "0x4001580")]
			ErrCode_INVITEEALREADYINROOM,
			// Token: 0x04001581 RID: 5505
			[Token(Token = "0x4001581")]
			ErrCode_INVITEEALREADYINGAME,
			// Token: 0x04001582 RID: 5506
			[Token(Token = "0x4001582")]
			ErrCode_INVITEEALREADYOFFLINE,
			// Token: 0x04001583 RID: 5507
			[Token(Token = "0x4001583")]
			ErrCode_INVALIDEMOTE,
			// Token: 0x04001584 RID: 5508
			[Token(Token = "0x4001584")]
			ErrCode_RANKINGMATCHLEVELLIMIT,
			// Token: 0x04001585 RID: 5509
			[Token(Token = "0x4001585")]
			ErrCode_NEGATIVEGEMS,
			// Token: 0x04001586 RID: 5510
			[Token(Token = "0x4001586")]
			ErrCode_ANTIADDICTIONBAN,
			// Token: 0x04001587 RID: 5511
			[Token(Token = "0x4001587")]
			ErrCode_NOTCHAMPIONTEAMMEMBER,
			// Token: 0x04001588 RID: 5512
			[Token(Token = "0x4001588")]
			ErrCode_INVITERNOTINGROUP,
			// Token: 0x04001589 RID: 5513
			[Token(Token = "0x4001589")]
			ErrCode_INVALIDCHAMPIONTEAM,
			// Token: 0x0400158A RID: 5514
			[Token(Token = "0x400158A")]
			ErrCode_NOTQUALIFIEDFORCHAMP,
			// Token: 0x0400158B RID: 5515
			[Token(Token = "0x400158B")]
			ErrCode_INVITEEALREADYINTRAINING,
			// Token: 0x0400158C RID: 5516
			[Token(Token = "0x400158C")]
			ErrCode_NOTQUALIFIEDFORTRAIN,
			// Token: 0x0400158D RID: 5517
			[Token(Token = "0x400158D")]
			ErrCode_MAPINVALIDFORSOMEMEMBERS,
			// Token: 0x0400158E RID: 5518
			[Token(Token = "0x400158E")]
			ErrCode_NOTQUALIFIEDFORGENGROUPCODE,
			// Token: 0x0400158F RID: 5519
			[Token(Token = "0x400158F")]
			ErrCode_NOTQUALIFIEDFORUSEGROUPCODE,
			// Token: 0x04001590 RID: 5520
			[Token(Token = "0x4001590")]
			ErrCode_NOAVAILABLEGROUPCODE,
			// Token: 0x04001591 RID: 5521
			[Token(Token = "0x4001591")]
			ErrCode_NOTGROUPCAPTAIN,
			// Token: 0x04001592 RID: 5522
			[Token(Token = "0x4001592")]
			ErrCode_DIFFERENTGROUPS,
			// Token: 0x04001593 RID: 5523
			[Token(Token = "0x4001593")]
			ErrCode_ALREADYINMATCHMAKING,
			// Token: 0x04001594 RID: 5524
			[Token(Token = "0x4001594")]
			ErrCode_CANNOTJOINSELF,
			// Token: 0x04001595 RID: 5525
			[Token(Token = "0x4001595")]
			ErrCode_CANNOTJOINOTHERREGION,
			// Token: 0x04001596 RID: 5526
			[Token(Token = "0x4001596")]
			ErrCode_JOINNONEXISTENTGROUP,
			// Token: 0x04001597 RID: 5527
			[Token(Token = "0x4001597")]
			ErrCode_PRIVATEGROUP,
			// Token: 0x04001598 RID: 5528
			[Token(Token = "0x4001598")]
			ErrCode_CANNOTKICKSELF,
			// Token: 0x04001599 RID: 5529
			[Token(Token = "0x4001599")]
			ErrCode_CREATEPLAYERFAIL,
			// Token: 0x0400159A RID: 5530
			[Token(Token = "0x400159A")]
			ErrCode_SELFNOTREADY,
			// Token: 0x0400159B RID: 5531
			[Token(Token = "0x400159B")]
			ErrCode_JOINERALREADYINGROUP,
			// Token: 0x0400159C RID: 5532
			[Token(Token = "0x400159C")]
			ErrCode_CSRANKINGBANNED,
			// Token: 0x0400159D RID: 5533
			[Token(Token = "0x400159D")]
			ErrCode_RANKINGMATCHREGISTERTIMELIMIT,
			// Token: 0x0400159E RID: 5534
			[Token(Token = "0x400159E")]
			ErrCode_GROUPSECRETCODENOTMATCH,
			// Token: 0x0400159F RID: 5535
			[Token(Token = "0x400159F")]
			ErrCode_GROUPNOTIDLEFORBIDCHANGEMODE
		}

		// Token: 0x0200048C RID: 1164
		[Token(Token = "0x200048C")]
		[ProtoContract]
		public enum LeaveReason
		{
			// Token: 0x040015A1 RID: 5537
			[Token(Token = "0x40015A1")]
			LeaveReason_NORMAL,
			// Token: 0x040015A2 RID: 5538
			[Token(Token = "0x40015A2")]
			LeaveReason_OFFLINE,
			// Token: 0x040015A3 RID: 5539
			[Token(Token = "0x40015A3")]
			LeaveReason_DROPMATCH,
			// Token: 0x040015A4 RID: 5540
			[Token(Token = "0x40015A4")]
			LeaveReason_ALLJOINROOM,
			// Token: 0x040015A5 RID: 5541
			[Token(Token = "0x40015A5")]
			LeaveReason_SOLOJOINROOM,
			// Token: 0x040015A6 RID: 5542
			[Token(Token = "0x40015A6")]
			LeaveReason_KICKOUT
		}

		// Token: 0x0200048D RID: 1165
		[Token(Token = "0x200048D")]
		[ProtoContract]
		public enum PlayerState
		{
			// Token: 0x040015A8 RID: 5544
			[Token(Token = "0x40015A8")]
			PlayerState_IDLE,
			// Token: 0x040015A9 RID: 5545
			[Token(Token = "0x40015A9")]
			PlayerState_MATCHMAKING,
			// Token: 0x040015AA RID: 5546
			[Token(Token = "0x40015AA")]
			PlayerState_INGAME,
			// Token: 0x040015AB RID: 5547
			[Token(Token = "0x40015AB")]
			PlayerState_AUTOGROUP
		}

		// Token: 0x0200048E RID: 1166
		[Token(Token = "0x200048E")]
		[ProtoContract]
		public enum State
		{
			// Token: 0x040015AD RID: 5549
			[Token(Token = "0x40015AD")]
			State_IDLE,
			// Token: 0x040015AE RID: 5550
			[Token(Token = "0x40015AE")]
			State_MATCHMAKING,
			// Token: 0x040015AF RID: 5551
			[Token(Token = "0x40015AF")]
			State_INGAME,
			// Token: 0x040015B0 RID: 5552
			[Token(Token = "0x40015B0")]
			State_AUTOGROUP
		}

		// Token: 0x0200048F RID: 1167
		[Token(Token = "0x200048F")]
		[ProtoContract]
		public enum CreateFromType
		{
			// Token: 0x040015B2 RID: 5554
			[Token(Token = "0x40015B2")]
			CreateFromType_NONE,
			// Token: 0x040015B3 RID: 5555
			[Token(Token = "0x40015B3")]
			CreateFromType_OWNSELF,
			// Token: 0x040015B4 RID: 5556
			[Token(Token = "0x40015B4")]
			CreateFromType_GROUP,
			// Token: 0x040015B5 RID: 5557
			[Token(Token = "0x40015B5")]
			CreateFromType_RESERVATION
		}

		// Token: 0x02000490 RID: 1168
		[Token(Token = "0x2000490")]
		[ProtoContract]
		public enum JoinFromType
		{
			// Token: 0x040015B7 RID: 5559
			[Token(Token = "0x40015B7")]
			JoinFromType_NONE,
			// Token: 0x040015B8 RID: 5560
			[Token(Token = "0x40015B8")]
			JoinFromType_GROUP
		}

		// Token: 0x02000491 RID: 1169
		[Token(Token = "0x2000491")]
		[ProtoContract]
		public enum InviteChannelType
		{
			// Token: 0x040015BA RID: 5562
			[Token(Token = "0x40015BA")]
			InviteChannelType_PLAYER,
			// Token: 0x040015BB RID: 5563
			[Token(Token = "0x40015BB")]
			InviteChannelType_WORLD,
			// Token: 0x040015BC RID: 5564
			[Token(Token = "0x40015BC")]
			InviteChannelType_GUILD
		}

		// Token: 0x02000492 RID: 1170
		[Token(Token = "0x2000492")]
		[ProtoContract]
		public enum InviteeType
		{
			// Token: 0x040015BE RID: 5566
			[Token(Token = "0x40015BE")]
			InviteeType_NONE,
			// Token: 0x040015BF RID: 5567
			[Token(Token = "0x40015BF")]
			InviteeType_FRIEND,
			// Token: 0x040015C0 RID: 5568
			[Token(Token = "0x40015C0")]
			InviteeType_GUILD,
			// Token: 0x040015C1 RID: 5569
			[Token(Token = "0x40015C1")]
			InviteeType_MATCHGROUP,
			// Token: 0x040015C2 RID: 5570
			[Token(Token = "0x40015C2")]
			InviteeType_MATCHKILLER,
			// Token: 0x040015C3 RID: 5571
			[Token(Token = "0x40015C3")]
			InviteeType_MATCHCHICKEN,
			// Token: 0x040015C4 RID: 5572
			[Token(Token = "0x40015C4")]
			InviteeType_CHAMPIONSHIP,
			// Token: 0x040015C5 RID: 5573
			[Token(Token = "0x40015C5")]
			InviteeType_REVENGER,
			// Token: 0x040015C6 RID: 5574
			[Token(Token = "0x40015C6")]
			InviteeType_CUP
		}

		// Token: 0x02000493 RID: 1171
		[Token(Token = "0x2000493")]
		[ProtoContract]
		public enum PubPvtStatus
		{
			// Token: 0x040015C8 RID: 5576
			[Token(Token = "0x40015C8")]
			PubPvtStatus_NONE,
			// Token: 0x040015C9 RID: 5577
			[Token(Token = "0x40015C9")]
			PubPvtStatus_PUBLIC,
			// Token: 0x040015CA RID: 5578
			[Token(Token = "0x40015CA")]
			PubPvtStatus_PRIVATE
		}

		// Token: 0x02000494 RID: 1172
		[Token(Token = "0x2000494")]
		[ProtoContract]
		public enum RoomType
		{
			// Token: 0x040015CC RID: 5580
			[Token(Token = "0x40015CC")]
			Type_NONE,
			// Token: 0x040015CD RID: 5581
			[Token(Token = "0x40015CD")]
			Type_CASUAL,
			// Token: 0x040015CE RID: 5582
			[Token(Token = "0x40015CE")]
			Type_LEAGUE_NORMAL,
			// Token: 0x040015CF RID: 5583
			[Token(Token = "0x40015CF")]
			Type_LEAGUE_OFFICIAL,
			// Token: 0x040015D0 RID: 5584
			[Token(Token = "0x40015D0")]
			Type_CHAMPIONSHIP,
			// Token: 0x040015D1 RID: 5585
			[Token(Token = "0x40015D1")]
			Type_LEAGUE_ULTIMATE,
			// Token: 0x040015D2 RID: 5586
			[Token(Token = "0x40015D2")]
			Type_LEAGUE_BATCH
		}
	}
}
