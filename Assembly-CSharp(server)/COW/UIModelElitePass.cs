using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001E47 RID: 7751
	[Token(Token = "0x2001E47")]
	internal class UIModelElitePass : UIBaseModel
	{
		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x0600A9BE RID: 43454 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		[Token(Token = "0x17000B21")]
		public uint CurEPEventID
		{
			[Token(Token = "0x600A9BE")]
			[Address(RVA = "0x2348FBC", Offset = "0x2348FBC", VA = "0x7BBCB48FBC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600A9BF RID: 43455 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		[Token(Token = "0x17000B22")]
		public uint CurEPEventBadgeItemID
		{
			[Token(Token = "0x600A9BF")]
			[Address(RVA = "0x2332234", Offset = "0x2332234", VA = "0x7BBCB32234")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600A9C0 RID: 43456 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
		// (set) Token: 0x0600A9C1 RID: 43457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B23")]
		public uint EPBadgeCount
		{
			[Token(Token = "0x600A9C0")]
			[Address(RVA = "0x233223C", Offset = "0x233223C", VA = "0x7BBCB3223C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145FBC", Offset = "0x1145FBC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9C1")]
			[Address(RVA = "0x2348FC4", Offset = "0x2348FC4", VA = "0x7BBCB48FC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145FCC", Offset = "0x1145FCC")]
			set
			{
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600A9C2 RID: 43458 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
		// (set) Token: 0x0600A9C3 RID: 43459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B24")]
		public uint EPDebrisCnt
		{
			[Token(Token = "0x600A9C2")]
			[Address(RVA = "0x2348FCC", Offset = "0x2348FCC", VA = "0x7BBCB48FCC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9C3")]
			[Address(RVA = "0x2348FD4", Offset = "0x2348FD4", VA = "0x7BBCB48FD4")]
			set
			{
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600A9C4 RID: 43460 RVA: 0x0002E308 File Offset: 0x0002C508
		// (set) Token: 0x0600A9C5 RID: 43461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B25")]
		public uint LastGameGotEPDebrisCache
		{
			[Token(Token = "0x600A9C4")]
			[Address(RVA = "0x2348FDC", Offset = "0x2348FDC", VA = "0x7BBCB48FDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145FDC", Offset = "0x1145FDC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9C5")]
			[Address(RVA = "0x2348FE4", Offset = "0x2348FE4", VA = "0x7BBCB48FE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145FEC", Offset = "0x1145FEC")]
			set
			{
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600A9C6 RID: 43462 RVA: 0x0002E320 File Offset: 0x0002C520
		[Token(Token = "0x17000B26")]
		public bool IsEP
		{
			[Token(Token = "0x600A9C6")]
			[Address(RVA = "0x2332244", Offset = "0x2332244", VA = "0x7BBCB32244")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600A9C7 RID: 43463 RVA: 0x0002E338 File Offset: 0x0002C538
		[Token(Token = "0x17000B27")]
		public bool IsFPChallenge
		{
			[Token(Token = "0x600A9C7")]
			[Address(RVA = "0x2348FEC", Offset = "0x2348FEC", VA = "0x7BBCB48FEC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600A9C8 RID: 43464 RVA: 0x0002E350 File Offset: 0x0002C550
		[Token(Token = "0x17000B28")]
		public uint CurFPChallengeItem
		{
			[Token(Token = "0x600A9C8")]
			[Address(RVA = "0x2348FF4", Offset = "0x2348FF4", VA = "0x7BBCB48FF4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600A9C9 RID: 43465 RVA: 0x0002E368 File Offset: 0x0002C568
		[Token(Token = "0x17000B29")]
		public uint PurchaseBadgeCountToday
		{
			[Token(Token = "0x600A9C9")]
			[Address(RVA = "0x2348FFC", Offset = "0x2348FFC", VA = "0x7BBCB48FFC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600A9CA RID: 43466 RVA: 0x0002E380 File Offset: 0x0002C580
		[Token(Token = "0x17000B2A")]
		public ulong CurEventEndTime
		{
			[Token(Token = "0x600A9CA")]
			[Address(RVA = "0x2349004", Offset = "0x2349004", VA = "0x7BBCB49004")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600A9CB RID: 43467 RVA: 0x0002E398 File Offset: 0x0002C598
		[Token(Token = "0x17000B2B")]
		public ulong DailyResetTime
		{
			[Token(Token = "0x600A9CB")]
			[Address(RVA = "0x234900C", Offset = "0x234900C", VA = "0x7BBCB4900C")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x0600A9CC RID: 43468 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
		// (set) Token: 0x0600A9CD RID: 43469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2C")]
		public bool NeedShowChallengeInLobby
		{
			[Token(Token = "0x600A9CC")]
			[Address(RVA = "0x2349014", Offset = "0x2349014", VA = "0x7BBCB49014")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A9CD")]
			[Address(RVA = "0x234901C", Offset = "0x234901C", VA = "0x7BBCB4901C")]
			set
			{
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600A9CE RID: 43470 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		// (set) Token: 0x0600A9CF RID: 43471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2D")]
		public uint PreorderedEPID
		{
			[Token(Token = "0x600A9CE")]
			[Address(RVA = "0x2349028", Offset = "0x2349028", VA = "0x7BBCB49028")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145FFC", Offset = "0x1145FFC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9CF")]
			[Address(RVA = "0x2349030", Offset = "0x2349030", VA = "0x7BBCB49030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114600C", Offset = "0x114600C")]
			private set
			{
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x0600A9D0 RID: 43472 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
		// (set) Token: 0x0600A9D1 RID: 43473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2E")]
		public ulong PreorderStartTime
		{
			[Token(Token = "0x600A9D0")]
			[Address(RVA = "0x2349038", Offset = "0x2349038", VA = "0x7BBCB49038")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114601C", Offset = "0x114601C")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600A9D1")]
			[Address(RVA = "0x2349040", Offset = "0x2349040", VA = "0x7BBCB49040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114602C", Offset = "0x114602C")]
			private set
			{
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		// (set) Token: 0x0600A9D3 RID: 43475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2F")]
		public ulong PreorderEndTime
		{
			[Token(Token = "0x600A9D2")]
			[Address(RVA = "0x2349048", Offset = "0x2349048", VA = "0x7BBCB49048")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114603C", Offset = "0x114603C")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600A9D3")]
			[Address(RVA = "0x2349050", Offset = "0x2349050", VA = "0x7BBCB49050")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114604C", Offset = "0x114604C")]
			private set
			{
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600A9D4 RID: 43476 RVA: 0x0002E410 File Offset: 0x0002C610
		// (set) Token: 0x0600A9D5 RID: 43477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B30")]
		public uint ChallengeDate
		{
			[Token(Token = "0x600A9D4")]
			[Address(RVA = "0x2349058", Offset = "0x2349058", VA = "0x7BBCB49058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114605C", Offset = "0x114605C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9D5")]
			[Address(RVA = "0x2349060", Offset = "0x2349060", VA = "0x7BBCB49060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114606C", Offset = "0x114606C")]
			private set
			{
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B31")]
		public string VideoUrlStr
		{
			[Token(Token = "0x600A9D6")]
			[Address(RVA = "0x2349068", Offset = "0x2349068", VA = "0x7BBCB49068")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600A9D7 RID: 43479 RVA: 0x0002E428 File Offset: 0x0002C628
		// (set) Token: 0x0600A9D8 RID: 43480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B32")]
		public uint DailyChallengeCompleteCnt
		{
			[Token(Token = "0x600A9D7")]
			[Address(RVA = "0x2349070", Offset = "0x2349070", VA = "0x7BBCB49070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114607C", Offset = "0x114607C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9D8")]
			[Address(RVA = "0x2349078", Offset = "0x2349078", VA = "0x7BBCB49078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114608C", Offset = "0x114608C")]
			private set
			{
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600A9D9 RID: 43481 RVA: 0x0002E440 File Offset: 0x0002C640
		// (set) Token: 0x0600A9DA RID: 43482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B33")]
		public uint EliteChallengeCompleteCnt
		{
			[Token(Token = "0x600A9D9")]
			[Address(RVA = "0x2349080", Offset = "0x2349080", VA = "0x7BBCB49080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114609C", Offset = "0x114609C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9DA")]
			[Address(RVA = "0x2349088", Offset = "0x2349088", VA = "0x7BBCB49088")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11460AC", Offset = "0x11460AC")]
			private set
			{
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x0600A9DB RID: 43483 RVA: 0x0002E458 File Offset: 0x0002C658
		// (set) Token: 0x0600A9DC RID: 43484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B34")]
		public uint VeteranChallengeCompleteCnt
		{
			[Token(Token = "0x600A9DB")]
			[Address(RVA = "0x2349090", Offset = "0x2349090", VA = "0x7BBCB49090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11460BC", Offset = "0x11460BC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9DC")]
			[Address(RVA = "0x2349098", Offset = "0x2349098", VA = "0x7BBCB49098")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11460CC", Offset = "0x11460CC")]
			private set
			{
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x0600A9DD RID: 43485 RVA: 0x0002E470 File Offset: 0x0002C670
		// (set) Token: 0x0600A9DE RID: 43486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B35")]
		public bool isPurchasedByBundle
		{
			[Token(Token = "0x600A9DD")]
			[Address(RVA = "0x23490A0", Offset = "0x23490A0", VA = "0x7BBCB490A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11460DC", Offset = "0x11460DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A9DE")]
			[Address(RVA = "0x23490A8", Offset = "0x23490A8", VA = "0x7BBCB490A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11460EC", Offset = "0x11460EC")]
			private set
			{
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x0600A9DF RID: 43487 RVA: 0x0002E488 File Offset: 0x0002C688
		// (set) Token: 0x0600A9E0 RID: 43488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B36")]
		public bool isEPPurchased
		{
			[Token(Token = "0x600A9DF")]
			[Address(RVA = "0x23490B4", Offset = "0x23490B4", VA = "0x7BBCB490B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11460FC", Offset = "0x11460FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A9E0")]
			[Address(RVA = "0x23490BC", Offset = "0x23490BC", VA = "0x7BBCB490BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114610C", Offset = "0x114610C")]
			set
			{
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x0600A9E1 RID: 43489 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
		// (set) Token: 0x0600A9E2 RID: 43490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B37")]
		public bool isPurchasedBySubscribe
		{
			[Token(Token = "0x600A9E1")]
			[Address(RVA = "0x23490C8", Offset = "0x23490C8", VA = "0x7BBCB490C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114611C", Offset = "0x114611C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A9E2")]
			[Address(RVA = "0x23490D0", Offset = "0x23490D0", VA = "0x7BBCB490D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114612C", Offset = "0x114612C")]
			set
			{
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600A9E3 RID: 43491 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
		// (set) Token: 0x0600A9E4 RID: 43492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B38")]
		public uint MyPurchasedEPSeasonCount
		{
			[Token(Token = "0x600A9E3")]
			[Address(RVA = "0x23490DC", Offset = "0x23490DC", VA = "0x7BBCB490DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114613C", Offset = "0x114613C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9E4")]
			[Address(RVA = "0x23490E4", Offset = "0x23490E4", VA = "0x7BBCB490E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114614C", Offset = "0x114614C")]
			private set
			{
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600A9E5 RID: 43493 RVA: 0x0002E4D0 File Offset: 0x0002C6D0
		// (set) Token: 0x0600A9E6 RID: 43494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B39")]
		public uint MaxRewardClaimedBadge
		{
			[Token(Token = "0x600A9E5")]
			[Address(RVA = "0x23490EC", Offset = "0x23490EC", VA = "0x7BBCB490EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114615C", Offset = "0x114615C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A9E6")]
			[Address(RVA = "0x23490F4", Offset = "0x23490F4", VA = "0x7BBCB490F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114616C", Offset = "0x114616C")]
			set
			{
			}
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		[Token(Token = "0x600A9E7")]
		[Address(RVA = "0x23490FC", Offset = "0x23490FC", VA = "0x7BBCB490FC", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E8")]
		[Address(RVA = "0x2349104", Offset = "0x2349104", VA = "0x7BBCB49104")]
		public void GetEPEventInfoFromServer(uint httpOp = 0U)
		{
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600A9E9 RID: 43497 RVA: 0x0002E500 File Offset: 0x0002C700
		// (set) Token: 0x0600A9EA RID: 43498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3A")]
		public bool IsFirstOpenCurEP
		{
			[Token(Token = "0x600A9E9")]
			[Address(RVA = "0x2349284", Offset = "0x2349284", VA = "0x7BBCB49284")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A9EA")]
			[Address(RVA = "0x234928C", Offset = "0x234928C", VA = "0x7BBCB4928C")]
			set
			{
			}
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x0002E518 File Offset: 0x0002C718
		[Token(Token = "0x600A9EB")]
		[Address(RVA = "0x2349298", Offset = "0x2349298", VA = "0x7BBCB49298")]
		public bool IsEntranceOpen(EEpEntrance type)
		{
			return default(bool);
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9EC")]
		[Address(RVA = "0x234938C", Offset = "0x234938C", VA = "0x7BBCB4938C")]
		public void GetEPDebrisRewardLastMatch()
		{
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9ED")]
		[Address(RVA = "0x234950C", Offset = "0x234950C", VA = "0x7BBCB4950C")]
		public void GetEPVideoUrlFromServer()
		{
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x0002E530 File Offset: 0x0002C730
		[Token(Token = "0x600A9EE")]
		[Address(RVA = "0x2349720", Offset = "0x2349720", VA = "0x7BBCB49720")]
		public bool IsNextEPPreorder()
		{
			return default(bool);
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9EF")]
		[Address(RVA = "0x23497AC", Offset = "0x23497AC", VA = "0x7BBCB497AC")]
		public void GetDailyQuestRewards(uint processId)
		{
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F0")]
		[Address(RVA = "0x234998C", Offset = "0x234998C", VA = "0x7BBCB4998C")]
		public void ClaimReward(uint unlockID, bool isEP, bool isMaxReward = false)
		{
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F1")]
		[Address(RVA = "0x2349A84", Offset = "0x2349A84", VA = "0x7BBCB49A84")]
		public void ClaimReward(List<unlock> claimList, bool isAutoClaim = false, bool isMaxReward = false)
		{
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F2")]
		[Address(RVA = "0x2349D00", Offset = "0x2349D00", VA = "0x7BBCB49D00")]
		public void PurchaseEP(bool isBundle)
		{
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F3")]
		[Address(RVA = "0x234A414", Offset = "0x234A414", VA = "0x7BBCB4A414")]
		public void TryAutoClaimUpgradeReward(uint badgeCount)
		{
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F4")]
		[Address(RVA = "0x234A6CC", Offset = "0x234A6CC", VA = "0x7BBCB4A6CC")]
		public void PurchaseBadge(int count, uint price)
		{
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F5")]
		[Address(RVA = "0x234A18C", Offset = "0x234A18C", VA = "0x7BBCB4A18C")]
		private void ShowCoinsNotEnoughPopup()
		{
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F6")]
		[Address(RVA = "0x234A39C", Offset = "0x234A39C", VA = "0x7BBCB4A39C")]
		private void ShowGemsNotEnoughPopup()
		{
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F7")]
		[Address(RVA = "0x234A9C0", Offset = "0x234A9C0", VA = "0x7BBCB4A9C0")]
		public void ClaimChallengeReward(List<uint> challengeIDs, ChallengeType challengeType, uint challengeGroup)
		{
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F8")]
		[Address(RVA = "0x234ABFC", Offset = "0x234ABFC", VA = "0x7BBCB4ABFC")]
		public void ClaimQuestReward(List<uint> questIDs, EPQuestType type, uint groupID = 0U)
		{
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9F9")]
		[Address(RVA = "0x234AE38", Offset = "0x234AE38", VA = "0x7BBCB4AE38")]
		public void ClaimEPWeeklyQuestReward(uint weekId, uint boxId)
		{
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9FA")]
		[Address(RVA = "0x234B04C", Offset = "0x234B04C", VA = "0x7BBCB4B04C")]
		public void PreorderNextEP()
		{
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x0002E548 File Offset: 0x0002C748
		[Token(Token = "0x600A9FB")]
		[Address(RVA = "0x234B1C0", Offset = "0x234B1C0", VA = "0x7BBCB4B1C0")]
		public bool NeedShowClaimAll()
		{
			return default(bool);
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9FC")]
		[Address(RVA = "0x234B400", Offset = "0x234B400", VA = "0x7BBCB4B400")]
		public void ClaimAll()
		{
		}

		// Token: 0x0600A9FD RID: 43517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9FD")]
		[Address(RVA = "0x234B890", Offset = "0x234B890", VA = "0x7BBCB4B890")]
		public void UpdateSpecialChallengesUnlocked(ChallengeIDs msg)
		{
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9FE")]
		[Address(RVA = "0x234B950", Offset = "0x234B950", VA = "0x7BBCB4B950", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A9FF RID: 43519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9FF")]
		[Address(RVA = "0x234BBD8", Offset = "0x234BBD8", VA = "0x7BBCB4BBD8", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600AA00 RID: 43520 RVA: 0x0002E560 File Offset: 0x0002C760
		[Token(Token = "0x17000B3B")]
		public bool PreorderSubscriptionEnabled
		{
			[Token(Token = "0x600AA00")]
			[Address(RVA = "0x234BC18", Offset = "0x234BC18", VA = "0x7BBCB4BC18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x0002E578 File Offset: 0x0002C778
		[Token(Token = "0x17000B3C")]
		public bool PlayerCanSubscribeForPreorder
		{
			[Token(Token = "0x600AA01")]
			[Address(RVA = "0x234BE24", Offset = "0x234BE24", VA = "0x7BBCB4BE24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x0600AA02 RID: 43522 RVA: 0x0002E590 File Offset: 0x0002C790
		// (set) Token: 0x0600AA03 RID: 43523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3D")]
		public ulong SubscribeStartTime
		{
			[Token(Token = "0x600AA02")]
			[Address(RVA = "0x234C180", Offset = "0x234C180", VA = "0x7BBCB4C180")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600AA03")]
			[Address(RVA = "0x234C218", Offset = "0x234C218", VA = "0x7BBCB4C218")]
			private set
			{
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x0600AA04 RID: 43524 RVA: 0x0002E5A8 File Offset: 0x0002C7A8
		// (set) Token: 0x0600AA05 RID: 43525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3E")]
		public ulong SubscribeEndTime
		{
			[Token(Token = "0x600AA04")]
			[Address(RVA = "0x234C220", Offset = "0x234C220", VA = "0x7BBCB4C220")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600AA05")]
			[Address(RVA = "0x234C2B8", Offset = "0x234C2B8", VA = "0x7BBCB4C2B8")]
			private set
			{
			}
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		[Token(Token = "0x600AA06")]
		[Address(RVA = "0x234BEBC", Offset = "0x234BEBC", VA = "0x7BBCB4BEBC")]
		public bool WithinSubscribablePeriod()
		{
			return default(bool);
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		[Token(Token = "0x600AA07")]
		[Address(RVA = "0x234BE70", Offset = "0x234BE70", VA = "0x7BBCB4BE70")]
		public bool WithinOverdueSubscribablePeriod()
		{
			return default(bool);
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA08")]
		[Address(RVA = "0x234C2C0", Offset = "0x234C2C0", VA = "0x7BBCB4C2C0")]
		public EPSubscriptions GetPreorderSubscriptionConfig()
		{
			return null;
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA09")]
		[Address(RVA = "0x234BAA0", Offset = "0x234BAA0", VA = "0x7BBCB4BAA0")]
		private string GetPreorderSubscriptionProductIdentifier()
		{
			return null;
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA0A")]
		[Address(RVA = "0x234C54C", Offset = "0x234C54C", VA = "0x7BBCB4C54C")]
		public PayItemData GetPreorderSubscriptionProduct_CSV()
		{
			return null;
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA0B")]
		[Address(RVA = "0x234C728", Offset = "0x234C728", VA = "0x7BBCB4C728")]
		public PayItemData GetPreorderSubscriptionProduct_SDK()
		{
			return null;
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x0002E5F0 File Offset: 0x0002C7F0
		[Token(Token = "0x600AA0C")]
		[Address(RVA = "0x234C85C", Offset = "0x234C85C", VA = "0x7BBCB4C85C")]
		public long GetPreorderSubscriptionCountdown_Seconds()
		{
			return 0L;
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA0D")]
		[Address(RVA = "0x234C8D8", Offset = "0x234C8D8", VA = "0x7BBCB4C8D8")]
		public void SubscribeForPreorder()
		{
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA0E")]
		[Address(RVA = "0x234CC40", Offset = "0x234CC40", VA = "0x7BBCB4CC40")]
		private void OnSubscribeForPreorder(bool success, string productIdentifier, long rebateId)
		{
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA0F")]
		[Address(RVA = "0x234CCC4", Offset = "0x234CCC4", VA = "0x7BBCB4CCC4")]
		private void OnGetSubscriptionProduct()
		{
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA10")]
		[Address(RVA = "0x234CD34", Offset = "0x234CD34", VA = "0x7BBCB4CD34")]
		public void OnSubscribed(string subscriptionProductIdentifier)
		{
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA11")]
		[Address(RVA = "0x234D068", Offset = "0x234D068", VA = "0x7BBCB4D068")]
		public void ShowSubscriptionHint(Vector3 position)
		{
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x0600AA12 RID: 43538 RVA: 0x0002E608 File Offset: 0x0002C808
		// (set) Token: 0x0600AA13 RID: 43539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3F")]
		public bool? SubscriptionBonusAvailable
		{
			[Token(Token = "0x600AA12")]
			[Address(RVA = "0x234D174", Offset = "0x234D174", VA = "0x7BBCB4D174")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114617C", Offset = "0x114617C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AA13")]
			[Address(RVA = "0x234BC10", Offset = "0x234BC10", VA = "0x7BBCB4BC10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114618C", Offset = "0x114618C")]
			private set
			{
			}
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA14")]
		[Address(RVA = "0x234D17C", Offset = "0x234D17C", VA = "0x7BBCB4D17C")]
		public void FetchSubscriptionBonusStatus(bool silence = false)
		{
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x0002E620 File Offset: 0x0002C820
		[Token(Token = "0x600AA15")]
		[Address(RVA = "0x234D398", Offset = "0x234D398", VA = "0x7BBCB4D398")]
		public int UpdateEPRelatedRedDot()
		{
			return 0;
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA16")]
		[Address(RVA = "0x234D518", Offset = "0x234D518", VA = "0x7BBCB4D518")]
		public void RequestGetEPDocumentInfo()
		{
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA17")]
		[Address(RVA = "0x234D68C", Offset = "0x234D68C", VA = "0x7BBCB4D68C")]
		public UIModelElitePass()
		{
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA18")]
		[Address(RVA = "0x234D704", Offset = "0x234D704", VA = "0x7BBCB4D704")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114619C", Offset = "0x114619C")]
		private void <GetEPEventInfoFromServer>b__105_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA19")]
		[Address(RVA = "0x234DF68", Offset = "0x234DF68", VA = "0x7BBCB4DF68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11461AC", Offset = "0x11461AC")]
		private void <GetEPDebrisRewardLastMatch>b__111_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1A")]
		[Address(RVA = "0x234E0BC", Offset = "0x234E0BC", VA = "0x7BBCB4E0BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11461BC", Offset = "0x11461BC")]
		private void <GetEPVideoUrlFromServer>b__112_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1B")]
		[Address(RVA = "0x234E1CC", Offset = "0x234E1CC", VA = "0x7BBCB4E1CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11461CC", Offset = "0x11461CC")]
		private void <PreorderNextEP>b__126_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1C")]
		[Address(RVA = "0x234E298", Offset = "0x234E298", VA = "0x7BBCB4E298")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11461DC", Offset = "0x11461DC")]
		private void <FetchSubscriptionBonusStatus>b__162_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1D")]
		[Address(RVA = "0x234E3CC", Offset = "0x234E3CC", VA = "0x7BBCB4E3CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11461EC", Offset = "0x11461EC")]
		private void <RequestGetEPDocumentInfo>b__165_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AED6 RID: 44758
		[Token(Token = "0x400AED6")]
		public const uint PropID_ElitePassInfoChange = 1U;

		// Token: 0x0400AED7 RID: 44759
		[Token(Token = "0x400AED7")]
		public const uint PropID_ElitePassUnlock = 2U;

		// Token: 0x0400AED8 RID: 44760
		[Token(Token = "0x400AED8")]
		public const uint PropID_ElitePassClaimedReward = 4U;

		// Token: 0x0400AED9 RID: 44761
		[Token(Token = "0x400AED9")]
		public const uint PropID_ElitePassClaimedBadge = 8U;

		// Token: 0x0400AEDA RID: 44762
		[Token(Token = "0x400AEDA")]
		public const uint PropID_ElitePassVideo = 16U;

		// Token: 0x0400AEDB RID: 44763
		[Token(Token = "0x400AEDB")]
		public const uint PropID_ElitePassSubscriptionUpdate = 32U;

		// Token: 0x0400AEDC RID: 44764
		[Token(Token = "0x400AEDC")]
		public const uint PropID_ElitePassSubscribed = 64U;

		// Token: 0x0400AEDD RID: 44765
		[Token(Token = "0x400AEDD")]
		public const uint PropID_ElitePassSpecialChallengeChange = 128U;

		// Token: 0x0400AEDE RID: 44766
		[Token(Token = "0x400AEDE")]
		public const uint PropID_ElitePassSubscriptionBonusUpdate = 256U;

		// Token: 0x0400AEDF RID: 44767
		[Token(Token = "0x400AEDF")]
		public const uint PropID_ElitePassClaimedDailyReward = 512U;

		// Token: 0x0400AEE0 RID: 44768
		[Token(Token = "0x400AEE0")]
		public const uint PropID_ElitePassClaimedQuestReward = 1024U;

		// Token: 0x0400AEE1 RID: 44769
		[Token(Token = "0x400AEE1")]
		public const uint PropID_ElitePassDocument = 2048U;

		// Token: 0x0400AEE2 RID: 44770
		[Token(Token = "0x400AEE2")]
		public const uint PropID_ElitePassWeeklyRewardClaimed = 4096U;

		// Token: 0x0400AEE3 RID: 44771
		[Token(Token = "0x400AEE3")]
		[FieldOffset(Offset = "0x18")]
		private uint m_CurEPEventID;

		// Token: 0x0400AEE4 RID: 44772
		[Token(Token = "0x400AEE4")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_CurEPEventBadgeItemID;

		// Token: 0x0400AEE5 RID: 44773
		[Token(Token = "0x400AEE5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF3C", Offset = "0x112FF3C")]
		private uint <EPBadgeCount>k__BackingField;

		// Token: 0x0400AEE6 RID: 44774
		[Token(Token = "0x400AEE6")]
		[FieldOffset(Offset = "0x24")]
		private uint m_EPDebrisCnt;

		// Token: 0x0400AEE7 RID: 44775
		[Token(Token = "0x400AEE7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF4C", Offset = "0x112FF4C")]
		private uint <LastGameGotEPDebrisCache>k__BackingField;

		// Token: 0x0400AEE8 RID: 44776
		[Token(Token = "0x400AEE8")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_IsEP;

		// Token: 0x0400AEE9 RID: 44777
		[Token(Token = "0x400AEE9")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_IsFPChallenge;

		// Token: 0x0400AEEA RID: 44778
		[Token(Token = "0x400AEEA")]
		[FieldOffset(Offset = "0x30")]
		private uint m_CurFPChallengeItem;

		// Token: 0x0400AEEB RID: 44779
		[Token(Token = "0x400AEEB")]
		[FieldOffset(Offset = "0x34")]
		private uint m_PurchaseBadgeCountToday;

		// Token: 0x0400AEEC RID: 44780
		[Token(Token = "0x400AEEC")]
		[FieldOffset(Offset = "0x38")]
		private ulong m_CurEventEndTime;

		// Token: 0x0400AEED RID: 44781
		[Token(Token = "0x400AEED")]
		[FieldOffset(Offset = "0x40")]
		private ulong m_DailyResetTime;

		// Token: 0x0400AEEE RID: 44782
		[Token(Token = "0x400AEEE")]
		[FieldOffset(Offset = "0x48")]
		private bool m_NeedShowChallengeInLobby;

		// Token: 0x0400AEEF RID: 44783
		[Token(Token = "0x400AEEF")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF5C", Offset = "0x112FF5C")]
		private uint <PreorderedEPID>k__BackingField;

		// Token: 0x0400AEF0 RID: 44784
		[Token(Token = "0x400AEF0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF6C", Offset = "0x112FF6C")]
		private ulong <PreorderStartTime>k__BackingField;

		// Token: 0x0400AEF1 RID: 44785
		[Token(Token = "0x400AEF1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF7C", Offset = "0x112FF7C")]
		private ulong <PreorderEndTime>k__BackingField;

		// Token: 0x0400AEF2 RID: 44786
		[Token(Token = "0x400AEF2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF8C", Offset = "0x112FF8C")]
		private uint <ChallengeDate>k__BackingField;

		// Token: 0x0400AEF3 RID: 44787
		[Token(Token = "0x400AEF3")]
		[FieldOffset(Offset = "0x68")]
		private string m_VideoUrlStr;

		// Token: 0x0400AEF4 RID: 44788
		[Token(Token = "0x400AEF4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF9C", Offset = "0x112FF9C")]
		private uint <DailyChallengeCompleteCnt>k__BackingField;

		// Token: 0x0400AEF5 RID: 44789
		[Token(Token = "0x400AEF5")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FFAC", Offset = "0x112FFAC")]
		private uint <EliteChallengeCompleteCnt>k__BackingField;

		// Token: 0x0400AEF6 RID: 44790
		[Token(Token = "0x400AEF6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FFBC", Offset = "0x112FFBC")]
		private uint <VeteranChallengeCompleteCnt>k__BackingField;

		// Token: 0x0400AEF7 RID: 44791
		[Token(Token = "0x400AEF7")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FFCC", Offset = "0x112FFCC")]
		private bool <isPurchasedByBundle>k__BackingField;

		// Token: 0x0400AEF8 RID: 44792
		[Token(Token = "0x400AEF8")]
		[FieldOffset(Offset = "0x7D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FFDC", Offset = "0x112FFDC")]
		private bool <isEPPurchased>k__BackingField;

		// Token: 0x0400AEF9 RID: 44793
		[Token(Token = "0x400AEF9")]
		[FieldOffset(Offset = "0x7E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FFEC", Offset = "0x112FFEC")]
		private bool <isPurchasedBySubscribe>k__BackingField;

		// Token: 0x0400AEFA RID: 44794
		[Token(Token = "0x400AEFA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FFFC", Offset = "0x112FFFC")]
		private uint <MyPurchasedEPSeasonCount>k__BackingField;

		// Token: 0x0400AEFB RID: 44795
		[Token(Token = "0x400AEFB")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113000C", Offset = "0x113000C")]
		private uint <MaxRewardClaimedBadge>k__BackingField;

		// Token: 0x0400AEFC RID: 44796
		[Token(Token = "0x400AEFC")]
		[FieldOffset(Offset = "0x88")]
		private bool m_HasShowCurEPCG;

		// Token: 0x0400AEFD RID: 44797
		[Token(Token = "0x400AEFD")]
		[FieldOffset(Offset = "0x90")]
		private CSGetWeeklyProcessRewardsReq m_PendingGetWeeklyProcessRewardsReq;

		// Token: 0x0400AEFE RID: 44798
		[Token(Token = "0x400AEFE")]
		[FieldOffset(Offset = "0x98")]
		private ulong m_SubscribeStartTime;

		// Token: 0x0400AEFF RID: 44799
		[Token(Token = "0x400AEFF")]
		[FieldOffset(Offset = "0xA0")]
		private ulong m_SubscribeEndTime;

		// Token: 0x0400AF00 RID: 44800
		[Token(Token = "0x400AF00")]
		private const string DEFAULT_REGION = "default";

		// Token: 0x0400AF01 RID: 44801
		[Token(Token = "0x400AF01")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_ProcessingSubscription;

		// Token: 0x0400AF02 RID: 44802
		[Token(Token = "0x400AF02")]
		[FieldOffset(Offset = "0xA9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113001C", Offset = "0x113001C")]
		private bool? <SubscriptionBonusAvailable>k__BackingField;

		// Token: 0x02001E48 RID: 7752
		[Token(Token = "0x2001E48")]
		private class ElitePassSubscriptionDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x0600AA1E RID: 43550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B40")]
			public static UIModelElitePass.ElitePassSubscriptionDelegate I
			{
				[Token(Token = "0x600AA1E")]
				[Address(RVA = "0x23A5700", Offset = "0x23A5700", VA = "0x7BBCBA5700")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x0600AA1F RID: 43551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B41")]
			public override string Name
			{
				[Token(Token = "0x600AA1F")]
				[Address(RVA = "0x23A5788", Offset = "0x23A5788", VA = "0x7BBCBA5788", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600AA20 RID: 43552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA20")]
			[Address(RVA = "0x23A57D0", Offset = "0x23A57D0", VA = "0x7BBCBA57D0", Slot = "9")]
			public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x0600AA21 RID: 43553 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AA21")]
			[Address(RVA = "0x23A58F8", Offset = "0x23A58F8", VA = "0x7BBCBA58F8", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600AA22 RID: 43554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA22")]
			[Address(RVA = "0x23A5780", Offset = "0x23A5780", VA = "0x7BBCBA5780")]
			public ElitePassSubscriptionDelegate()
			{
			}

			// Token: 0x0400AF03 RID: 44803
			[Token(Token = "0x400AF03")]
			[FieldOffset(Offset = "0x0")]
			private static UIModelElitePass.ElitePassSubscriptionDelegate _I;

			// Token: 0x0400AF04 RID: 44804
			[Token(Token = "0x400AF04")]
			[FieldOffset(Offset = "0x20")]
			private string LastSubscribedProductIdentifier;
		}

		// Token: 0x02001E49 RID: 7753
		[Token(Token = "0x2001E49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC5A4", Offset = "0x10FC5A4")]
		private sealed class <>c__DisplayClass114_0
		{
			// Token: 0x0600AA23 RID: 43555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA23")]
			[Address(RVA = "0x23A46D0", Offset = "0x23A46D0", VA = "0x7BBCBA46D0")]
			public <>c__DisplayClass114_0()
			{
			}

			// Token: 0x0600AA24 RID: 43556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA24")]
			[Address(RVA = "0x23A46D8", Offset = "0x23A46D8", VA = "0x7BBCBA46D8")]
			internal void <GetDailyQuestRewards>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF05 RID: 44805
			[Token(Token = "0x400AF05")]
			[FieldOffset(Offset = "0x10")]
			public uint processId;

			// Token: 0x0400AF06 RID: 44806
			[Token(Token = "0x400AF06")]
			[FieldOffset(Offset = "0x18")]
			public UIModelElitePass <>4__this;
		}

		// Token: 0x02001E4A RID: 7754
		[Token(Token = "0x2001E4A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC5B4", Offset = "0x10FC5B4")]
		private sealed class <>c__DisplayClass116_0
		{
			// Token: 0x0600AA25 RID: 43557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA25")]
			[Address(RVA = "0x23A4870", Offset = "0x23A4870", VA = "0x7BBCBA4870")]
			public <>c__DisplayClass116_0()
			{
			}

			// Token: 0x0600AA26 RID: 43558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA26")]
			[Address(RVA = "0x23A4878", Offset = "0x23A4878", VA = "0x7BBCBA4878")]
			internal void <ClaimReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF07 RID: 44807
			[Token(Token = "0x400AF07")]
			[FieldOffset(Offset = "0x10")]
			public UIModelElitePass <>4__this;

			// Token: 0x0400AF08 RID: 44808
			[Token(Token = "0x400AF08")]
			[FieldOffset(Offset = "0x18")]
			public List<unlock> claimList;

			// Token: 0x0400AF09 RID: 44809
			[Token(Token = "0x400AF09")]
			[FieldOffset(Offset = "0x20")]
			public bool isAutoClaim;

			// Token: 0x0400AF0A RID: 44810
			[Token(Token = "0x400AF0A")]
			[FieldOffset(Offset = "0x21")]
			public bool isMaxReward;
		}

		// Token: 0x02001E4B RID: 7755
		[Token(Token = "0x2001E4B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC5C4", Offset = "0x10FC5C4")]
		private sealed class <>c__DisplayClass117_0
		{
			// Token: 0x0600AA27 RID: 43559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA27")]
			[Address(RVA = "0x23A4A28", Offset = "0x23A4A28", VA = "0x7BBCBA4A28")]
			public <>c__DisplayClass117_0()
			{
			}

			// Token: 0x0600AA28 RID: 43560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA28")]
			[Address(RVA = "0x23A4A30", Offset = "0x23A4A30", VA = "0x7BBCBA4A30")]
			internal void <PurchaseEP>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF0B RID: 44811
			[Token(Token = "0x400AF0B")]
			[FieldOffset(Offset = "0x10")]
			public UIModelElitePass <>4__this;

			// Token: 0x0400AF0C RID: 44812
			[Token(Token = "0x400AF0C")]
			[FieldOffset(Offset = "0x18")]
			public bool isBundle;

			// Token: 0x0400AF0D RID: 44813
			[Token(Token = "0x400AF0D")]
			[FieldOffset(Offset = "0x1C")]
			public uint before;
		}

		// Token: 0x02001E4C RID: 7756
		[Token(Token = "0x2001E4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC5D4", Offset = "0x10FC5D4")]
		private sealed class <>c__DisplayClass119_0
		{
			// Token: 0x0600AA29 RID: 43561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA29")]
			[Address(RVA = "0x23A4C78", Offset = "0x23A4C78", VA = "0x7BBCBA4C78")]
			public <>c__DisplayClass119_0()
			{
			}

			// Token: 0x0600AA2A RID: 43562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA2A")]
			[Address(RVA = "0x23A4C80", Offset = "0x23A4C80", VA = "0x7BBCBA4C80")]
			internal void <PurchaseBadge>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF0E RID: 44814
			[Token(Token = "0x400AF0E")]
			[FieldOffset(Offset = "0x10")]
			public UIModelElitePass <>4__this;

			// Token: 0x0400AF0F RID: 44815
			[Token(Token = "0x400AF0F")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}

		// Token: 0x02001E4D RID: 7757
		[Token(Token = "0x2001E4D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC5E4", Offset = "0x10FC5E4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AA2C RID: 43564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA2C")]
			[Address(RVA = "0x23A46B0", Offset = "0x23A46B0", VA = "0x7BBCBA46B0")]
			public <>c()
			{
			}

			// Token: 0x0600AA2D RID: 43565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AA2D")]
			[Address(RVA = "0x23A46B8", Offset = "0x23A46B8", VA = "0x7BBCBA46B8")]
			internal CommonRewardItemInfo <PurchaseBadge>b__119_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600AA2E RID: 43566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AA2E")]
			[Address(RVA = "0x23A46C4", Offset = "0x23A46C4", VA = "0x7BBCBA46C4")]
			internal CommonRewardItemInfo <ClaimEPWeeklyQuestReward>b__125_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400AF10 RID: 44816
			[Token(Token = "0x400AF10")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelElitePass.<>c <>9;

			// Token: 0x0400AF11 RID: 44817
			[Token(Token = "0x400AF11")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__119_1;

			// Token: 0x0400AF12 RID: 44818
			[Token(Token = "0x400AF12")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__125_1;
		}

		// Token: 0x02001E4E RID: 7758
		[Token(Token = "0x2001E4E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC5F4", Offset = "0x10FC5F4")]
		private sealed class <>c__DisplayClass122_0
		{
			// Token: 0x0600AA2F RID: 43567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA2F")]
			[Address(RVA = "0x23A500C", Offset = "0x23A500C", VA = "0x7BBCBA500C")]
			public <>c__DisplayClass122_0()
			{
			}

			// Token: 0x0600AA30 RID: 43568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA30")]
			[Address(RVA = "0x23A5014", Offset = "0x23A5014", VA = "0x7BBCBA5014")]
			internal void <ClaimChallengeReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF13 RID: 44819
			[Token(Token = "0x400AF13")]
			[FieldOffset(Offset = "0x10")]
			public UIModelElitePass <>4__this;

			// Token: 0x0400AF14 RID: 44820
			[Token(Token = "0x400AF14")]
			[FieldOffset(Offset = "0x18")]
			public List<uint> challengeIDs;

			// Token: 0x0400AF15 RID: 44821
			[Token(Token = "0x400AF15")]
			[FieldOffset(Offset = "0x20")]
			public ChallengeType challengeType;

			// Token: 0x0400AF16 RID: 44822
			[Token(Token = "0x400AF16")]
			[FieldOffset(Offset = "0x24")]
			public uint challengeGroup;
		}

		// Token: 0x02001E4F RID: 7759
		[Token(Token = "0x2001E4F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC604", Offset = "0x10FC604")]
		private sealed class <>c__DisplayClass123_0
		{
			// Token: 0x0600AA31 RID: 43569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA31")]
			[Address(RVA = "0x23A51CC", Offset = "0x23A51CC", VA = "0x7BBCBA51CC")]
			public <>c__DisplayClass123_0()
			{
			}

			// Token: 0x0600AA32 RID: 43570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA32")]
			[Address(RVA = "0x23A51D4", Offset = "0x23A51D4", VA = "0x7BBCBA51D4")]
			internal void <ClaimQuestReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF17 RID: 44823
			[Token(Token = "0x400AF17")]
			[FieldOffset(Offset = "0x10")]
			public UIModelElitePass <>4__this;

			// Token: 0x0400AF18 RID: 44824
			[Token(Token = "0x400AF18")]
			[FieldOffset(Offset = "0x18")]
			public List<uint> questIDs;

			// Token: 0x0400AF19 RID: 44825
			[Token(Token = "0x400AF19")]
			[FieldOffset(Offset = "0x20")]
			public EPQuestType type;

			// Token: 0x0400AF1A RID: 44826
			[Token(Token = "0x400AF1A")]
			[FieldOffset(Offset = "0x24")]
			public uint groupID;
		}

		// Token: 0x02001E50 RID: 7760
		[Token(Token = "0x2001E50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC614", Offset = "0x10FC614")]
		private sealed class <>c__DisplayClass125_0
		{
			// Token: 0x0600AA33 RID: 43571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA33")]
			[Address(RVA = "0x23A538C", Offset = "0x23A538C", VA = "0x7BBCBA538C")]
			public <>c__DisplayClass125_0()
			{
			}

			// Token: 0x0600AA34 RID: 43572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA34")]
			[Address(RVA = "0x23A5394", Offset = "0x23A5394", VA = "0x7BBCBA5394")]
			internal void <ClaimEPWeeklyQuestReward>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400AF1B RID: 44827
			[Token(Token = "0x400AF1B")]
			[FieldOffset(Offset = "0x10")]
			public UIModelElitePass <>4__this;

			// Token: 0x0400AF1C RID: 44828
			[Token(Token = "0x400AF1C")]
			[FieldOffset(Offset = "0x18")]
			public uint weekId;

			// Token: 0x0400AF1D RID: 44829
			[Token(Token = "0x400AF1D")]
			[FieldOffset(Offset = "0x1C")]
			public uint boxId;
		}
	}
}
