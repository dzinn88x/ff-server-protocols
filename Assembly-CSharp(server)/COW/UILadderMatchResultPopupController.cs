using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001532 RID: 5426
	[Token(Token = "0x2001532")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE3DC", Offset = "0x10EE3DC")]
	internal class UILadderMatchResultPopupController : UIPopupWindowController
	{
		// Token: 0x06005D97 RID: 23959 RVA: 0x0001B2A0 File Offset: 0x000194A0
		[Token(Token = "0x6005D97")]
		[Address(RVA = "0x1E8DC40", Offset = "0x1E8DC40", VA = "0x7BBC68DC40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D98")]
		[Address(RVA = "0x1E8DC90", Offset = "0x1E8DC90", VA = "0x7BBC68DC90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D99")]
		[Address(RVA = "0x1E8E100", Offset = "0x1E8E100", VA = "0x7BBC68E100")]
		private void CheckCanSpeed()
		{
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9A")]
		[Address(RVA = "0x1E8E1EC", Offset = "0x1E8E1EC", VA = "0x7BBC68E1EC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9B")]
		[Address(RVA = "0x1E8E288", Offset = "0x1E8E288", VA = "0x7BBC68E288", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9C")]
		[Address(RVA = "0x1E8E400", Offset = "0x1E8E400", VA = "0x7BBC68E400")]
		public void SetResultAttachData(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0x1E8EEB0", Offset = "0x1E8EEB0", VA = "0x7BBC68EEB0")]
		public void SetResultData(int start_point, int end_point, uint start_rank, uint end_rank, bool m_isAddPoints, bool _isDoubleScoreActivity, bool _isDoubleTokenActivity, uint DoubleScoreCardId, uint NoDuctCardId)
		{
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x0001B2B8 File Offset: 0x000194B8
		[Token(Token = "0x6005D9E")]
		[Address(RVA = "0x1E908F0", Offset = "0x1E908F0", VA = "0x7BBC6908F0")]
		private bool ShowConfrimBtn(float time)
		{
			return default(bool);
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9F")]
		[Address(RVA = "0x1E8FDC4", Offset = "0x1E8FDC4", VA = "0x7BBC68FDC4")]
		private void InitCoinShowInfo()
		{
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA0")]
		[Address(RVA = "0x1E90068", Offset = "0x1E90068", VA = "0x7BBC690068")]
		private void InitProgressShowInfo(bool isStartMaxRank, bool isEndMaxRank)
		{
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x0001B2D0 File Offset: 0x000194D0
		[Token(Token = "0x6005DA1")]
		[Address(RVA = "0x1E90CF4", Offset = "0x1E90CF4", VA = "0x7BBC690CF4")]
		private bool UpdateLevelIcon(float time)
		{
			return default(bool);
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x0001B2E8 File Offset: 0x000194E8
		[Token(Token = "0x6005DA2")]
		[Address(RVA = "0x1E91020", Offset = "0x1E91020", VA = "0x7BBC691020")]
		private bool UpdateDetailScoreLabel(float time)
		{
			return default(bool);
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x0001B300 File Offset: 0x00019500
		[Token(Token = "0x6005DA3")]
		[Address(RVA = "0x1E915D4", Offset = "0x1E915D4", VA = "0x7BBC6915D4")]
		private bool UpdateProgreesBar(float time)
		{
			return default(bool);
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA4")]
		[Address(RVA = "0x1E9198C", Offset = "0x1E9198C", VA = "0x7BBC69198C")]
		private void Update()
		{
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA5")]
		[Address(RVA = "0x1E8FAF0", Offset = "0x1E8FAF0", VA = "0x7BBC68FAF0")]
		private void RefreshOldHeroicLevelStarObj(int rankScore)
		{
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA6")]
		[Address(RVA = "0x1E90A30", Offset = "0x1E90A30", VA = "0x7BBC690A30")]
		private void RefreshNewHeroicLevelStarObj(int rankScore)
		{
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0x1E91F48", Offset = "0x1E91F48", VA = "0x7BBC691F48")]
		public void PlayAnimationSound()
		{
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0x1E91F4C", Offset = "0x1E91F4C", VA = "0x7BBC691F4C")]
		public UILadderMatchResultPopupController()
		{
		}

		// Token: 0x04007F2A RID: 32554
		[Token(Token = "0x4007F2A")]
		[FieldOffset(Offset = "0x98")]
		private LadderMatchResultPopupView m_View;

		// Token: 0x04007F2B RID: 32555
		[Token(Token = "0x4007F2B")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 shine_offset;

		// Token: 0x04007F2C RID: 32556
		[Token(Token = "0x4007F2C")]
		public const float progressAnimSpeedSingle = 2f;

		// Token: 0x04007F2D RID: 32557
		[Token(Token = "0x4007F2D")]
		public const float ScoreAnimSpeedSingle = 4f;

		// Token: 0x04007F2E RID: 32558
		[Token(Token = "0x4007F2E")]
		public const float progressAnimSpeedMulti = 4f;

		// Token: 0x04007F2F RID: 32559
		[Token(Token = "0x4007F2F")]
		private const float animationSpeedSingle = 1f;

		// Token: 0x04007F30 RID: 32560
		[Token(Token = "0x4007F30")]
		private const float animationSpeedMulti = 3f;

		// Token: 0x04007F31 RID: 32561
		[Token(Token = "0x4007F31")]
		private const float label_delay_time = 0.3f;

		// Token: 0x04007F32 RID: 32562
		[Token(Token = "0x4007F32")]
		[FieldOffset(Offset = "0xAC")]
		private int StartPoint;

		// Token: 0x04007F33 RID: 32563
		[Token(Token = "0x4007F33")]
		[FieldOffset(Offset = "0xB0")]
		private int EndPoint;

		// Token: 0x04007F34 RID: 32564
		[Token(Token = "0x4007F34")]
		[FieldOffset(Offset = "0xB4")]
		private uint StartRank;

		// Token: 0x04007F35 RID: 32565
		[Token(Token = "0x4007F35")]
		[FieldOffset(Offset = "0xB8")]
		private uint EndRank;

		// Token: 0x04007F36 RID: 32566
		[Token(Token = "0x4007F36")]
		[FieldOffset(Offset = "0xBC")]
		private int AddCoin;

		// Token: 0x04007F37 RID: 32567
		[Token(Token = "0x4007F37")]
		[FieldOffset(Offset = "0xC0")]
		private int GetCoin;

		// Token: 0x04007F38 RID: 32568
		[Token(Token = "0x4007F38")]
		[FieldOffset(Offset = "0xC4")]
		private int LimitCoin;

		// Token: 0x04007F39 RID: 32569
		[Token(Token = "0x4007F39")]
		[FieldOffset(Offset = "0xC8")]
		private bool Protect_Open;

		// Token: 0x04007F3A RID: 32570
		[Token(Token = "0x4007F3A")]
		[FieldOffset(Offset = "0xCC")]
		private uint ServivedTime;

		// Token: 0x04007F3B RID: 32571
		[Token(Token = "0x4007F3B")]
		private const int LABELCOUNT = 5;

		// Token: 0x04007F3C RID: 32572
		[Token(Token = "0x4007F3C")]
		[FieldOffset(Offset = "0xD0")]
		private int LabelShowIndex;

		// Token: 0x04007F3D RID: 32573
		[Token(Token = "0x4007F3D")]
		[FieldOffset(Offset = "0xD8")]
		private int[] start_add_num;

		// Token: 0x04007F3E RID: 32574
		[Token(Token = "0x4007F3E")]
		[FieldOffset(Offset = "0xE0")]
		private int[] end_num;

		// Token: 0x04007F3F RID: 32575
		[Token(Token = "0x4007F3F")]
		[FieldOffset(Offset = "0xE8")]
		private string[] deltaStr;

		// Token: 0x04007F40 RID: 32576
		[Token(Token = "0x4007F40")]
		[FieldOffset(Offset = "0xF0")]
		private UILabel[] labelList;

		// Token: 0x04007F41 RID: 32577
		[Token(Token = "0x4007F41")]
		[FieldOffset(Offset = "0xF8")]
		private LadderLevelData startRankData;

		// Token: 0x04007F42 RID: 32578
		[Token(Token = "0x4007F42")]
		[FieldOffset(Offset = "0x100")]
		private LadderLevelData endRankData;

		// Token: 0x04007F43 RID: 32579
		[Token(Token = "0x4007F43")]
		[FieldOffset(Offset = "0x108")]
		private UILadderMatchResultPopupController.AnmationDelegate animationStruct;

		// Token: 0x04007F44 RID: 32580
		[Token(Token = "0x4007F44")]
		private const int FIRST_WIN_SCORE = 0;

		// Token: 0x04007F45 RID: 32581
		[Token(Token = "0x4007F45")]
		private const int RANK_SCORE = 1;

		// Token: 0x04007F46 RID: 32582
		[Token(Token = "0x4007F46")]
		private const int BATTLE_SCORE = 2;

		// Token: 0x04007F47 RID: 32583
		[Token(Token = "0x4007F47")]
		private const int MAP_SCORE = 3;

		// Token: 0x04007F48 RID: 32584
		[Token(Token = "0x4007F48")]
		private const int FINAL_SCORE = 4;

		// Token: 0x04007F49 RID: 32585
		[Token(Token = "0x4007F49")]
		[FieldOffset(Offset = "0x110")]
		private bool isCurrentPeakRank;

		// Token: 0x04007F4A RID: 32586
		[Token(Token = "0x4007F4A")]
		[FieldOffset(Offset = "0x111")]
		private bool isLastPeakRank;

		// Token: 0x04007F4B RID: 32587
		[Token(Token = "0x4007F4B")]
		[FieldOffset(Offset = "0x118")]
		private PeakRankData peakRankData;

		// Token: 0x04007F4C RID: 32588
		[Token(Token = "0x4007F4C")]
		[FieldOffset(Offset = "0x120")]
		private AnimatorStateInfo currentAnimationInfo;

		// Token: 0x04007F4D RID: 32589
		[Token(Token = "0x4007F4D")]
		[FieldOffset(Offset = "0x148")]
		private List<UILadderMatchResultPopupController.AnmationDelegate> animationSequence;

		// Token: 0x04007F4E RID: 32590
		[Token(Token = "0x4007F4E")]
		[FieldOffset(Offset = "0x150")]
		private int now_count;

		// Token: 0x04007F4F RID: 32591
		[Token(Token = "0x4007F4F")]
		[FieldOffset(Offset = "0x154")]
		private bool isUpgrade;

		// Token: 0x04007F50 RID: 32592
		[Token(Token = "0x4007F50")]
		[FieldOffset(Offset = "0x158")]
		private Queue<UILadderMatchResultPopupController.ProgressInfo> progress_info_list;

		// Token: 0x04007F51 RID: 32593
		[Token(Token = "0x4007F51")]
		[FieldOffset(Offset = "0x160")]
		private bool start_show_flag;

		// Token: 0x04007F52 RID: 32594
		[Token(Token = "0x4007F52")]
		[FieldOffset(Offset = "0x164")]
		private float GrowingTime;

		// Token: 0x04007F53 RID: 32595
		[Token(Token = "0x4007F53")]
		private const float ScoreProgressShowTime = 4f;

		// Token: 0x04007F54 RID: 32596
		[Token(Token = "0x4007F54")]
		private const float ScoreDetailShowTime = 2.8f;

		// Token: 0x04007F55 RID: 32597
		[Token(Token = "0x4007F55")]
		[FieldOffset(Offset = "0x168")]
		private float BtnShowTime;

		// Token: 0x04007F56 RID: 32598
		[Token(Token = "0x4007F56")]
		[FieldOffset(Offset = "0x16C")]
		private float LevelUpTime;

		// Token: 0x04007F57 RID: 32599
		[Token(Token = "0x4007F57")]
		[FieldOffset(Offset = "0x170")]
		private float labeldelayShowTime;

		// Token: 0x04007F58 RID: 32600
		[Token(Token = "0x4007F58")]
		[FieldOffset(Offset = "0x174")]
		private UILadderMatchResultPopupController.ProgressInfo current_info;

		// Token: 0x04007F59 RID: 32601
		[Token(Token = "0x4007F59")]
		[FieldOffset(Offset = "0x184")]
		private bool current_info_flag;

		// Token: 0x04007F5A RID: 32602
		[Token(Token = "0x4007F5A")]
		[FieldOffset(Offset = "0x185")]
		private bool isProgressShow;

		// Token: 0x04007F5B RID: 32603
		[Token(Token = "0x4007F5B")]
		[FieldOffset(Offset = "0x188")]
		private float levelUpShowTime;

		// Token: 0x04007F5C RID: 32604
		[Token(Token = "0x4007F5C")]
		[FieldOffset(Offset = "0x190")]
		private List<GameObject> m_OldHeroicLevelStarObjs;

		// Token: 0x04007F5D RID: 32605
		[Token(Token = "0x4007F5D")]
		[FieldOffset(Offset = "0x198")]
		private List<GameObject> m_NewHeroicLevelStarObjs;

		// Token: 0x02001533 RID: 5427
		// (Invoke) Token: 0x06005DAA RID: 23978
		[Token(Token = "0x2001533")]
		private delegate bool AnmationDelegate(float changeTime);

		// Token: 0x02001534 RID: 5428
		[Token(Token = "0x2001534")]
		private struct ProgressInfo
		{
			// Token: 0x04007F5E RID: 32606
			[Token(Token = "0x4007F5E")]
			[FieldOffset(Offset = "0x0")]
			public float CurPercentage;

			// Token: 0x04007F5F RID: 32607
			[Token(Token = "0x4007F5F")]
			[FieldOffset(Offset = "0x4")]
			public float StartProgressValue;

			// Token: 0x04007F60 RID: 32608
			[Token(Token = "0x4007F60")]
			[FieldOffset(Offset = "0x8")]
			public float EndProgressValue;

			// Token: 0x04007F61 RID: 32609
			[Token(Token = "0x4007F61")]
			[FieldOffset(Offset = "0xC")]
			public float speedValue;
		}
	}
}
