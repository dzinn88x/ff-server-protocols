using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006A1 RID: 1697
	[Token(Token = "0x20006A1")]
	[ProtoContract]
	public class ELimitedEvent
	{
		// Token: 0x060023D8 RID: 9176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x21B9840", Offset = "0x21B9840", VA = "0x7BBC9B9840")]
		public ELimitedEvent()
		{
		}

		// Token: 0x020006A2 RID: 1698
		[Token(Token = "0x20006A2")]
		[ProtoContract]
		public enum StoreType
		{
			// Token: 0x04002144 RID: 8516
			[Token(Token = "0x4002144")]
			StoreType_NONE,
			// Token: 0x04002145 RID: 8517
			[Token(Token = "0x4002145")]
			StoreType_BRINGER,
			// Token: 0x04002146 RID: 8518
			[Token(Token = "0x4002146")]
			StoreType_LIBERI,
			// Token: 0x04002147 RID: 8519
			[Token(Token = "0x4002147")]
			StoreType_ANNIVERSARY,
			// Token: 0x04002148 RID: 8520
			[Token(Token = "0x4002148")]
			StoreType_BOOYAHDAY,
			// Token: 0x04002149 RID: 8521
			[Token(Token = "0x4002149")]
			StoreType_MVP,
			// Token: 0x0400214A RID: 8522
			[Token(Token = "0x400214A")]
			StoreType_GOLIATH,
			// Token: 0x0400214B RID: 8523
			[Token(Token = "0x400214B")]
			StoreType_FFWS
		}

		// Token: 0x020006A3 RID: 1699
		[Token(Token = "0x20006A3")]
		[ProtoContract]
		public enum EventID
		{
			// Token: 0x0400214D RID: 8525
			[Token(Token = "0x400214D")]
			EventID_NONE,
			// Token: 0x0400214E RID: 8526
			[Token(Token = "0x400214E")]
			EventID_RAMPAGE,
			// Token: 0x0400214F RID: 8527
			[Token(Token = "0x400214F")]
			EventID_ANNIVERSARY,
			// Token: 0x04002150 RID: 8528
			[Token(Token = "0x4002150")]
			EventID_MONEYHEIST,
			// Token: 0x04002151 RID: 8529
			[Token(Token = "0x4002151")]
			EventID_BOOYAHDAY,
			// Token: 0x04002152 RID: 8530
			[Token(Token = "0x4002152")]
			EventID_BOUNTY,
			// Token: 0x04002153 RID: 8531
			[Token(Token = "0x4002153")]
			EventID_BERMUDA,
			// Token: 0x04002154 RID: 8532
			[Token(Token = "0x4002154")]
			EventID_MEGAPUNCH,
			// Token: 0x04002155 RID: 8533
			[Token(Token = "0x4002155")]
			EventID_MVP,
			// Token: 0x04002156 RID: 8534
			[Token(Token = "0x4002156")]
			EventID_GOLIATH,
			// Token: 0x04002157 RID: 8535
			[Token(Token = "0x4002157")]
			EventID_FFWS,
			// Token: 0x04002158 RID: 8536
			[Token(Token = "0x4002158")]
			EventID_SUPERFIGHTER,
			// Token: 0x04002159 RID: 8537
			[Token(Token = "0x4002159")]
			EventID_SUPERCAR
		}

		// Token: 0x020006A4 RID: 1700
		[Token(Token = "0x20006A4")]
		[ProtoContract]
		public enum EventState
		{
			// Token: 0x0400215B RID: 8539
			[Token(Token = "0x400215B")]
			EventState_NONE,
			// Token: 0x0400215C RID: 8540
			[Token(Token = "0x400215C")]
			EventState_WARMUP,
			// Token: 0x0400215D RID: 8541
			[Token(Token = "0x400215D")]
			EventState_PROCESS,
			// Token: 0x0400215E RID: 8542
			[Token(Token = "0x400215E")]
			EventState_SETTLE,
			// Token: 0x0400215F RID: 8543
			[Token(Token = "0x400215F")]
			EventState_SPAN
		}

		// Token: 0x020006A5 RID: 1701
		[Token(Token = "0x20006A5")]
		[ProtoContract]
		public enum ProcessType
		{
			// Token: 0x04002161 RID: 8545
			[Token(Token = "0x4002161")]
			ProcessType_NONE,
			// Token: 0x04002162 RID: 8546
			[Token(Token = "0x4002162")]
			ProcessType_BRINGER,
			// Token: 0x04002163 RID: 8547
			[Token(Token = "0x4002163")]
			ProcessType_LIBERI,
			// Token: 0x04002164 RID: 8548
			[Token(Token = "0x4002164")]
			ProcessType_NODE,
			// Token: 0x04002165 RID: 8549
			[Token(Token = "0x4002165")]
			ProcessType_BOUNTY_WARMUP,
			// Token: 0x04002166 RID: 8550
			[Token(Token = "0x4002166")]
			ProcessType_BOUNTY_POPULARITY,
			// Token: 0x04002167 RID: 8551
			[Token(Token = "0x4002167")]
			ProcessType_BOUNTY_MAIN_PERCENT
		}

		// Token: 0x020006A6 RID: 1702
		[Token(Token = "0x20006A6")]
		[ProtoContract]
		public enum RampageFaction
		{
			// Token: 0x04002169 RID: 8553
			[Token(Token = "0x4002169")]
			RampageFaction_NONE,
			// Token: 0x0400216A RID: 8554
			[Token(Token = "0x400216A")]
			RampageFaction_BRINGER,
			// Token: 0x0400216B RID: 8555
			[Token(Token = "0x400216B")]
			RampageFaction_LIBERI
		}

		// Token: 0x020006A7 RID: 1703
		[Token(Token = "0x20006A7")]
		[ProtoContract]
		public enum NodeStatus
		{
			// Token: 0x0400216D RID: 8557
			[Token(Token = "0x400216D")]
			NodeStatus_NONE,
			// Token: 0x0400216E RID: 8558
			[Token(Token = "0x400216E")]
			NodeStatus_LOCKED,
			// Token: 0x0400216F RID: 8559
			[Token(Token = "0x400216F")]
			NodeStatus_UNLOCKED,
			// Token: 0x04002170 RID: 8560
			[Token(Token = "0x4002170")]
			NodeStatus_CLAIMED
		}

		// Token: 0x020006A8 RID: 1704
		[Token(Token = "0x20006A8")]
		[ProtoContract]
		public enum NodeType
		{
			// Token: 0x04002172 RID: 8562
			[Token(Token = "0x4002172")]
			NodeTYPE_NONE,
			// Token: 0x04002173 RID: 8563
			[Token(Token = "0x4002173")]
			NodeType_NORMAL,
			// Token: 0x04002174 RID: 8564
			[Token(Token = "0x4002174")]
			NodeType_ANNIVERSARY
		}

		// Token: 0x020006A9 RID: 1705
		[Token(Token = "0x20006A9")]
		[ProtoContract]
		public enum MoenyHeistHelp
		{
			// Token: 0x04002176 RID: 8566
			[Token(Token = "0x4002176")]
			MoenyHeistHelp_NONE,
			// Token: 0x04002177 RID: 8567
			[Token(Token = "0x4002177")]
			MoenyHeistHelp_FOR_OTHER,
			// Token: 0x04002178 RID: 8568
			[Token(Token = "0x4002178")]
			MoenyHeistHelp_FOR_SELF
		}

		// Token: 0x020006AA RID: 1706
		[Token(Token = "0x20006AA")]
		[ProtoContract]
		public enum MoneyHeistAwardType
		{
			// Token: 0x0400217A RID: 8570
			[Token(Token = "0x400217A")]
			MoneyHeistAwardType_NONE,
			// Token: 0x0400217B RID: 8571
			[Token(Token = "0x400217B")]
			MoneyHeistAwardType_NORMAL,
			// Token: 0x0400217C RID: 8572
			[Token(Token = "0x400217C")]
			MoneyHeistAwardType_BIG
		}

		// Token: 0x020006AB RID: 1707
		[Token(Token = "0x20006AB")]
		[ProtoContract]
		public enum MoneyHesitSpeedChangeType
		{
			// Token: 0x0400217E RID: 8574
			[Token(Token = "0x400217E")]
			MoneyHeistSpeedChangeType_NONE,
			// Token: 0x0400217F RID: 8575
			[Token(Token = "0x400217F")]
			MoneyHeistSpeedChangeType_TASK,
			// Token: 0x04002180 RID: 8576
			[Token(Token = "0x4002180")]
			MoneyHeistSpeedChangeType_TOKEN,
			// Token: 0x04002181 RID: 8577
			[Token(Token = "0x4002181")]
			MoneyHeistSpeedChangeType_FRIEND
		}

		// Token: 0x020006AC RID: 1708
		[Token(Token = "0x20006AC")]
		[ProtoContract]
		public enum LeaderboardType
		{
			// Token: 0x04002183 RID: 8579
			[Token(Token = "0x4002183")]
			LeaderboardType_NONE,
			// Token: 0x04002184 RID: 8580
			[Token(Token = "0x4002184")]
			LeaderboardType_BOOYAH_GAME,
			// Token: 0x04002185 RID: 8581
			[Token(Token = "0x4002185")]
			LeaderboardType_BOOYAH_CHESS
		}

		// Token: 0x020006AD RID: 1709
		[Token(Token = "0x20006AD")]
		[ProtoContract]
		public enum BooyahAwardStatus
		{
			// Token: 0x04002187 RID: 8583
			[Token(Token = "0x4002187")]
			BooyahAwardStats_INIT,
			// Token: 0x04002188 RID: 8584
			[Token(Token = "0x4002188")]
			BooyahAwardStats_AWARDED
		}

		// Token: 0x020006AE RID: 1710
		[Token(Token = "0x20006AE")]
		[ProtoContract]
		public enum GoliathGroupJoinSource
		{
			// Token: 0x0400218A RID: 8586
			[Token(Token = "0x400218A")]
			GoliathGroupJoinSource_NONE,
			// Token: 0x0400218B RID: 8587
			[Token(Token = "0x400218B")]
			GoliathGroupJoinSource_FRIEND,
			// Token: 0x0400218C RID: 8588
			[Token(Token = "0x400218C")]
			GoliathGroupJoinSource_SEARCH,
			// Token: 0x0400218D RID: 8589
			[Token(Token = "0x400218D")]
			GoliathGroupJoinSource_WORLD,
			// Token: 0x0400218E RID: 8590
			[Token(Token = "0x400218E")]
			GoliathGroupJoinSource_SHARE,
			// Token: 0x0400218F RID: 8591
			[Token(Token = "0x400218F")]
			GoliathGroupJoinSource_ClAN
		}

		// Token: 0x020006AF RID: 1711
		[Token(Token = "0x20006AF")]
		[ProtoContract]
		public enum SuperFighterManner
		{
			// Token: 0x04002191 RID: 8593
			[Token(Token = "0x4002191")]
			SuperFighterManner_NONE,
			// Token: 0x04002192 RID: 8594
			[Token(Token = "0x4002192")]
			SuperFighterManner_LIGHT,
			// Token: 0x04002193 RID: 8595
			[Token(Token = "0x4002193")]
			SuperFighterManner_HEAVY,
			// Token: 0x04002194 RID: 8596
			[Token(Token = "0x4002194")]
			SuperFighterManner_UNIQUE
		}

		// Token: 0x020006B0 RID: 1712
		[Token(Token = "0x20006B0")]
		[ProtoContract]
		public enum SuperFighterResult
		{
			// Token: 0x04002196 RID: 8598
			[Token(Token = "0x4002196")]
			SuperFighterResult_NONE,
			// Token: 0x04002197 RID: 8599
			[Token(Token = "0x4002197")]
			SuperFighterResult_WIN,
			// Token: 0x04002198 RID: 8600
			[Token(Token = "0x4002198")]
			SuperFighterResult_LOSE
		}

		// Token: 0x020006B1 RID: 1713
		[Token(Token = "0x20006B1")]
		[ProtoContract]
		public enum FFWSGuessingAwardStatus
		{
			// Token: 0x0400219A RID: 8602
			[Token(Token = "0x400219A")]
			FFWSGuessingAwardStats_INIT,
			// Token: 0x0400219B RID: 8603
			[Token(Token = "0x400219B")]
			FFWSGuessingAwardStats_AWARDED
		}

		// Token: 0x020006B2 RID: 1714
		[Token(Token = "0x20006B2")]
		[ProtoContract]
		public enum FFWSGuessingAwardType
		{
			// Token: 0x0400219D RID: 8605
			[Token(Token = "0x400219D")]
			FFWSGuessingAwardType_NONE,
			// Token: 0x0400219E RID: 8606
			[Token(Token = "0x400219E")]
			FFWSGuessingAwardType_WIN,
			// Token: 0x0400219F RID: 8607
			[Token(Token = "0x400219F")]
			FFWSGuessingAwardType_LOSE
		}
	}
}
