using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200209A RID: 8346
	[Token(Token = "0x200209A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDAEC", Offset = "0x10FDAEC")]
	internal class UIHudBanknoteLeaderboardController : UIBaseController
	{
		// Token: 0x0600BB8C RID: 48012 RVA: 0x00035148 File Offset: 0x00033348
		[Token(Token = "0x600BB8C")]
		[Address(RVA = "0x188C3E4", Offset = "0x188C3E4", VA = "0x7BBC08C3E4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BB8D RID: 48013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB8D")]
		[Address(RVA = "0x188C434", Offset = "0x188C434", VA = "0x7BBC08C434", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BB8E RID: 48014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB8E")]
		[Address(RVA = "0x188C750", Offset = "0x188C750", VA = "0x7BBC08C750", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600BB8F RID: 48015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB8F")]
		[Address(RVA = "0x188C7EC", Offset = "0x188C7EC", VA = "0x7BBC08C7EC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600BB90 RID: 48016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB90")]
		[Address(RVA = "0x188CA5C", Offset = "0x188CA5C", VA = "0x7BBC08CA5C")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600BB91 RID: 48017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB91")]
		[Address(RVA = "0x188CA6C", Offset = "0x188CA6C", VA = "0x7BBC08CA6C")]
		public void SetTitle(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
		{
		}

		// Token: 0x0600BB92 RID: 48018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB92")]
		[Address(RVA = "0x188CB4C", Offset = "0x188CB4C", VA = "0x7BBC08CB4C")]
		private void OnAddPlayer(params object[] param)
		{
		}

		// Token: 0x0600BB93 RID: 48019 RVA: 0x00035160 File Offset: 0x00033360
		[Token(Token = "0x600BB93")]
		[Address(RVA = "0x188D4E8", Offset = "0x188D4E8", VA = "0x7BBC08D4E8")]
		private bool IsTeamOnLeft({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x0600BB94 RID: 48020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB94")]
		[Address(RVA = "0x188D1A0", Offset = "0x188D1A0", VA = "0x7BBC08D1A0")]
		private void AddItemController({QAb\u0082~u pId, LeaderboardData dataInfo)
		{
		}

		// Token: 0x0600BB95 RID: 48021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB95")]
		[Address(RVA = "0x188DAF4", Offset = "0x188DAF4", VA = "0x7BBC08DAF4")]
		private void OnKillCountChanged(params object[] param)
		{
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB96")]
		[Address(RVA = "0x188DC8C", Offset = "0x188DC8C", VA = "0x7BBC08DC8C")]
		private void OnDMGChanged(params object[] param)
		{
		}

		// Token: 0x0600BB97 RID: 48023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB97")]
		[Address(RVA = "0x188DE24", Offset = "0x188DE24", VA = "0x7BBC08DE24")]
		private void OnSyncLeaderBoard(object[] data)
		{
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB98")]
		[Address(RVA = "0x188E074", Offset = "0x188E074", VA = "0x7BBC08E074")]
		private void OnCSNewPhaseStarted(params object[] param)
		{
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB99")]
		[Address(RVA = "0x188E128", Offset = "0x188E128", VA = "0x7BBC08E128")]
		private void OnFactionIDChanged(params object[] param)
		{
		}

		// Token: 0x0600BB9A RID: 48026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9A")]
		[Address(RVA = "0x188D710", Offset = "0x188D710", VA = "0x7BBC08D710")]
		private void UpdateFactionInfo()
		{
		}

		// Token: 0x0600BB9B RID: 48027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9B")]
		[Address(RVA = "0x188D614", Offset = "0x188D614", VA = "0x7BBC08D614")]
		private void UpdateFactionInfo(int localFactionID)
		{
		}

		// Token: 0x0600BB9C RID: 48028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9C")]
		[Address(RVA = "0x188E1C8", Offset = "0x188E1C8", VA = "0x7BBC08E1C8")]
		private void OnToggleRoundInfo(params object[] parap)
		{
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9D")]
		[Address(RVA = "0x188E224", Offset = "0x188E224", VA = "0x7BBC08E224")]
		public UIHudBanknoteLeaderboardController()
		{
		}

		// Token: 0x0400BC72 RID: 48242
		[Token(Token = "0x400BC72")]
		[FieldOffset(Offset = "0x58")]
		private UIHudControlLeaderboardView m_View;

		// Token: 0x0400BC73 RID: 48243
		[Token(Token = "0x400BC73")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<{QAb\u0082~u, LeaderboardData> m_ItemsBe4LocalPlayer;

		// Token: 0x0400BC74 RID: 48244
		[Token(Token = "0x400BC74")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<{QAb\u0082~u, UIHudBanknoteLeaderboardItemController> m_ItemControllers;

		// Token: 0x0400BC75 RID: 48245
		[Token(Token = "0x400BC75")]
		[FieldOffset(Offset = "0x70")]
		private bool m_LocalPlayerAdded;

		// Token: 0x0400BC76 RID: 48246
		[Token(Token = "0x400BC76")]
		[FieldOffset(Offset = "0x74")]
		private int m_LocalPlayerTeamId;

		// Token: 0x0400BC77 RID: 48247
		[Token(Token = "0x400BC77")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsSPFactionUpdated;

		// Token: 0x0400BC78 RID: 48248
		[Token(Token = "0x400BC78")]
		[FieldOffset(Offset = "0x7C")]
		private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType1;

		// Token: 0x0400BC79 RID: 48249
		[Token(Token = "0x400BC79")]
		[FieldOffset(Offset = "0x80")]
		private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType2;

		// Token: 0x0400BC7A RID: 48250
		[Token(Token = "0x400BC7A")]
		[FieldOffset(Offset = "0x84")]
		private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType3;
	}
}
