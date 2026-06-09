using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015F1 RID: 5617
	[Token(Token = "0x20015F1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF644", Offset = "0x10EF644")]
	public class UIHudMatchResultItemBaseController : UIEasyListItemController
	{
		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060063F3 RID: 25587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008EE")]
		protected List<EMatchResultPlayerInfoType> InfoTypeList
		{
			[Token(Token = "0x60063F3")]
			[Address(RVA = "0x17A884C", Offset = "0x17A884C", VA = "0x7BBBFA884C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060063F4 RID: 25588 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		// (set) Token: 0x060063F5 RID: 25589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EF")]
		public ulong TargetAccountID
		{
			[Token(Token = "0x60063F4")]
			[Address(RVA = "0x17A88C0", Offset = "0x17A88C0", VA = "0x7BBBFA88C0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60063F5")]
			[Address(RVA = "0x17A88C8", Offset = "0x17A88C8", VA = "0x7BBBFA88C8")]
			protected set
			{
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060063F6 RID: 25590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F0")]
		private FMatchResultPlayerData PlayerInfo
		{
			[Token(Token = "0x60063F6")]
			[Address(RVA = "0x17A88D0", Offset = "0x17A88D0", VA = "0x7BBBFA88D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060063F7 RID: 25591 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		[Token(Token = "0x170008F1")]
		public bool HasLike
		{
			[Token(Token = "0x60063F7")]
			[Address(RVA = "0x17A88D8", Offset = "0x17A88D8", VA = "0x7BBBFA88D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (set) Token: 0x060063F8 RID: 25592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F2")]
		protected UIButton AddFriendBtn
		{
			[Token(Token = "0x60063F8")]
			[Address(RVA = "0x17A88F8", Offset = "0x17A88F8", VA = "0x7BBBFA88F8")]
			set
			{
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (set) Token: 0x060063F9 RID: 25593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F3")]
		protected UIButton ReportBtn
		{
			[Token(Token = "0x60063F9")]
			[Address(RVA = "0x17A89AC", Offset = "0x17A89AC", VA = "0x7BBBFA89AC")]
			set
			{
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (set) Token: 0x060063FA RID: 25594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F4")]
		protected UILabel LikeNum
		{
			[Token(Token = "0x60063FA")]
			[Address(RVA = "0x17A8A64", Offset = "0x17A8A64", VA = "0x7BBBFA8A64")]
			set
			{
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (set) Token: 0x060063FB RID: 25595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F5")]
		protected UIButton LikeBtn
		{
			[Token(Token = "0x60063FB")]
			[Address(RVA = "0x17A8AB4", Offset = "0x17A8AB4", VA = "0x7BBBFA8AB4")]
			set
			{
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (set) Token: 0x060063FC RID: 25596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F6")]
		protected GameObject LikeVFX
		{
			[Token(Token = "0x60063FC")]
			[Address(RVA = "0x17A8B6C", Offset = "0x17A8B6C", VA = "0x7BBBFA8B6C")]
			set
			{
			}
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FD")]
		[Address(RVA = "0x17A8BA4", Offset = "0x17A8BA4", VA = "0x7BBBFA8BA4")]
		public void SetInfoTypeList(List<EMatchResultPlayerInfoType> list)
		{
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FE")]
		[Address(RVA = "0x17A8BAC", Offset = "0x17A8BAC", VA = "0x7BBBFA8BAC")]
		public void SetPlayerData(TeammateStats stats)
		{
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FF")]
		[Address(RVA = "0x17A8E34", Offset = "0x17A8E34", VA = "0x7BBBFA8E34")]
		public void SetPlayerLikedCount(uint count)
		{
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006400")]
		[Address(RVA = "0x17A8F28", Offset = "0x17A8F28", VA = "0x7BBBFA8F28")]
		public void ShowAddFriendButton(bool show)
		{
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006401")]
		[Address(RVA = "0x17A910C", Offset = "0x17A910C", VA = "0x7BBBFA910C")]
		public void ShowReportButton(bool show)
		{
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006402")]
		[Address(RVA = "0x17A9250", Offset = "0x17A9250", VA = "0x7BBBFA9250")]
		public void ShowLikeContainer(bool show)
		{
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006403")]
		[Address(RVA = "0x17A947C", Offset = "0x17A947C", VA = "0x7BBBFA947C")]
		public void SetGradeInfo(bool isMVP, bool win, string gradeTxt = "", bool hideScroe = false)
		{
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006404")]
		[Address(RVA = "0x17A963C", Offset = "0x17A963C", VA = "0x7BBBFA963C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006405")]
		[Address(RVA = "0x17A9708", Offset = "0x17A9708", VA = "0x7BBBFA9708", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006406")]
		[Address(RVA = "0x17A970C", Offset = "0x17A970C", VA = "0x7BBBFA970C", Slot = "34")]
		protected virtual void OnSetPlayerData(TeammateStats data)
		{
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006407")]
		[Address(RVA = "0x17A9710", Offset = "0x17A9710", VA = "0x7BBBFA9710")]
		protected void UpdateInfoData(UILabel infoTxt, TeammateStats player, int index)
		{
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006408")]
		[Address(RVA = "0x17A9F38", Offset = "0x17A9F38", VA = "0x7BBBFA9F38", Slot = "35")]
		protected virtual void OnClickAddFriendBtn()
		{
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006409")]
		[Address(RVA = "0x17AA128", Offset = "0x17AA128", VA = "0x7BBBFAA128")]
		private void OnClickReportBtn()
		{
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640A")]
		[Address(RVA = "0x17AA324", Offset = "0x17AA324", VA = "0x7BBBFAA324")]
		private void OnClickLikeBtn()
		{
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640B")]
		[Address(RVA = "0x17A8D18", Offset = "0x17A8D18", VA = "0x7BBBFA8D18")]
		private void SetIsSelf(bool self)
		{
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640C")]
		[Address(RVA = "0x17AA54C", Offset = "0x17AA54C", VA = "0x7BBBFAA54C")]
		private void OnReportCheatSent(object[] param)
		{
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640D")]
		[Address(RVA = "0x17A982C", Offset = "0x17A982C", VA = "0x7BBBFA982C")]
		public static void SetMatchResultPlayerInfoData(UILabel label, TeammateStats player, EMatchResultPlayerInfoType type)
		{
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640E")]
		[Address(RVA = "0x17AA664", Offset = "0x17AA664", VA = "0x7BBBFAA664")]
		public UIHudMatchResultItemBaseController()
		{
		}

		// Token: 0x040082B9 RID: 33465
		[Token(Token = "0x40082B9")]
		[FieldOffset(Offset = "0x70")]
		private List<EMatchResultPlayerInfoType> m_InfoTypeList;

		// Token: 0x040082BA RID: 33466
		[Token(Token = "0x40082BA")]
		[FieldOffset(Offset = "0x78")]
		private ulong m_TargetAccountID;

		// Token: 0x040082BB RID: 33467
		[Token(Token = "0x40082BB")]
		[FieldOffset(Offset = "0x80")]
		private {QAb\u0082~u TargetPlayerID;

		// Token: 0x040082BC RID: 33468
		[Token(Token = "0x40082BC")]
		[FieldOffset(Offset = "0x98")]
		private string TargetName;

		// Token: 0x040082BD RID: 33469
		[Token(Token = "0x40082BD")]
		[FieldOffset(Offset = "0xA0")]
		public Func<ulong, FMatchResultPlayerData> fnGetPlayerMatchResultData;

		// Token: 0x040082BE RID: 33470
		[Token(Token = "0x40082BE")]
		[FieldOffset(Offset = "0xA8")]
		private FMatchResultPlayerData m_PlayerInfo;

		// Token: 0x040082BF RID: 33471
		[Token(Token = "0x40082BF")]
		[FieldOffset(Offset = "0xB0")]
		protected bool AutoShowAddFriendAfterLike;

		// Token: 0x040082C0 RID: 33472
		[Token(Token = "0x40082C0")]
		[FieldOffset(Offset = "0xB8")]
		private UIButton m_AddFriendBtn;

		// Token: 0x040082C1 RID: 33473
		[Token(Token = "0x40082C1")]
		[FieldOffset(Offset = "0xC0")]
		private UIButton m_ReportBtn;

		// Token: 0x040082C2 RID: 33474
		[Token(Token = "0x40082C2")]
		[FieldOffset(Offset = "0xC8")]
		private UILabel m_LikeNum;

		// Token: 0x040082C3 RID: 33475
		[Token(Token = "0x40082C3")]
		[FieldOffset(Offset = "0xD0")]
		private UIButton m_LikeBtn;

		// Token: 0x040082C4 RID: 33476
		[Token(Token = "0x40082C4")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject m_LikeVFX;

		// Token: 0x040082C5 RID: 33477
		[Token(Token = "0x40082C5")]
		[FieldOffset(Offset = "0xE0")]
		protected GameObject SelfBG;

		// Token: 0x040082C6 RID: 33478
		[Token(Token = "0x40082C6")]
		[FieldOffset(Offset = "0xE8")]
		protected GameObject WinMVPGrade;

		// Token: 0x040082C7 RID: 33479
		[Token(Token = "0x40082C7")]
		[FieldOffset(Offset = "0xF0")]
		protected GameObject FailMVPGrade;

		// Token: 0x040082C8 RID: 33480
		[Token(Token = "0x40082C8")]
		[FieldOffset(Offset = "0xF8")]
		protected UILabel NormalGrade;
	}
}
