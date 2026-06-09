using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015EE RID: 5614
	[Token(Token = "0x20015EE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF5C4", Offset = "0x10EF5C4")]
	internal class UIHudMatchResultBaseController : UIHudResultShowBaseController
	{
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060063AC RID: 25516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063AD RID: 25517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E3")]
		public TeammateStats MVPPlayerData
		{
			[Token(Token = "0x60063AC")]
			[Address(RVA = "0x15C5F0C", Offset = "0x15C5F0C", VA = "0x7BBBDC5F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60063AD")]
			[Address(RVA = "0x15C5F14", Offset = "0x15C5F14", VA = "0x7BBBDC5F14")]
			protected set
			{
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060063AE RID: 25518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E4")]
		protected List<EMatchResultPlayerInfoType> InfoTypeList
		{
			[Token(Token = "0x60063AE")]
			[Address(RVA = "0x15C5F1C", Offset = "0x15C5F1C", VA = "0x7BBBDC5F1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060063AF RID: 25519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E5")]
		protected List<UIHudMatchResultItemBaseController> ItemCtrlList
		{
			[Token(Token = "0x60063AF")]
			[Address(RVA = "0x15C5F90", Offset = "0x15C5F90", VA = "0x7BBBDC5F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060063B0 RID: 25520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E6")]
		protected Dictionary<ulong, FMatchResultPlayerData> PlayerMatchResultDataMap
		{
			[Token(Token = "0x60063B0")]
			[Address(RVA = "0x15C6004", Offset = "0x15C6004", VA = "0x7BBBDC6004")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060063B1 RID: 25521 RVA: 0x0001CB18 File Offset: 0x0001AD18
		[Token(Token = "0x170008E7")]
		protected bool IsWin
		{
			[Token(Token = "0x60063B1")]
			[Address(RVA = "0x15C6078", Offset = "0x15C6078", VA = "0x7BBBDC6078")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (set) Token: 0x060063B2 RID: 25522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E8")]
		protected GameObject ShareInfoContainer
		{
			[Token(Token = "0x60063B2")]
			[Address(RVA = "0x15C6080", Offset = "0x15C6080", VA = "0x7BBBDC6080")]
			set
			{
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (set) Token: 0x060063B3 RID: 25523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E9")]
		protected UIButton ShareBtn
		{
			[Token(Token = "0x60063B3")]
			[Address(RVA = "0x15C60B8", Offset = "0x15C60B8", VA = "0x7BBBDC60B8")]
			set
			{
			}
		}

		// Token: 0x170008EA RID: 2282
		// (set) Token: 0x060063B4 RID: 25524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EA")]
		protected UIButton DetailBtn
		{
			[Token(Token = "0x60063B4")]
			[Address(RVA = "0x15C618C", Offset = "0x15C618C", VA = "0x7BBBDC618C")]
			set
			{
			}
		}

		// Token: 0x170008EB RID: 2283
		// (set) Token: 0x060063B5 RID: 25525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EB")]
		protected UIButton NextBtn
		{
			[Token(Token = "0x60063B5")]
			[Address(RVA = "0x15C6244", Offset = "0x15C6244", VA = "0x7BBBDC6244")]
			set
			{
			}
		}

		// Token: 0x170008EC RID: 2284
		// (set) Token: 0x060063B6 RID: 25526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EC")]
		protected UIButton FastSendGiftBtn
		{
			[Token(Token = "0x60063B6")]
			[Address(RVA = "0x15C62FC", Offset = "0x15C62FC", VA = "0x7BBBDC62FC")]
			set
			{
			}
		}

		// Token: 0x170008ED RID: 2285
		// (set) Token: 0x060063B7 RID: 25527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008ED")]
		protected UIButton VideoGiftBtn
		{
			[Token(Token = "0x60063B7")]
			[Address(RVA = "0x15C63B4", Offset = "0x15C63B4", VA = "0x7BBBDC63B4")]
			set
			{
			}
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B8")]
		[Address(RVA = "0x15C646C", Offset = "0x15C646C", VA = "0x7BBBDC646C")]
		public void Update()
		{
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B9")]
		[Address(RVA = "0x15C6908", Offset = "0x15C6908", VA = "0x7BBBDC6908", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BA")]
		[Address(RVA = "0x15C6BA0", Offset = "0x15C6BA0", VA = "0x7BBBDC6BA0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BB")]
		[Address(RVA = "0x15C6DBC", Offset = "0x15C6DBC", VA = "0x7BBBDC6DBC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BC")]
		[Address(RVA = "0x15C776C", Offset = "0x15C776C", VA = "0x7BBBDC776C", Slot = "30")]
		protected sealed override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BD")]
		[Address(RVA = "0x15C7834", Offset = "0x15C7834", VA = "0x7BBBDC7834", Slot = "36")]
		public sealed override void CreateProfileCallSign(PlayerData data, int index)
		{
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063BE")]
		[Address(RVA = "0x15C7CF8", Offset = "0x15C7CF8", VA = "0x7BBBDC7CF8", Slot = "38")]
		protected sealed override List<PlayerData> CreateResultData()
		{
			return null;
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BF")]
		[Address(RVA = "0x15C8050", Offset = "0x15C8050", VA = "0x7BBBDC8050", Slot = "34")]
		protected sealed override void ReturnToLobby()
		{
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C0")]
		[Address(RVA = "0x15C86A8", Offset = "0x15C86A8", VA = "0x7BBBDC86A8", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C1")]
		[Address(RVA = "0x15C8A20", Offset = "0x15C8A20", VA = "0x7BBBDC8A20", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C2")]
		[Address(RVA = "0x15C8D98", Offset = "0x15C8D98", VA = "0x7BBBDC8D98")]
		protected void RepositionRewardBtnGrid()
		{
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C3")]
		[Address(RVA = "0x15C8E38", Offset = "0x15C8E38", VA = "0x7BBBDC8E38")]
		protected void UpdateInfoTitle(UILabel infoTxt, int index)
		{
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C4")]
		protected T OpenPlayerItemUI<T>(Transform parent, TeammateStats data) where T : UIHudMatchResultItemBaseController
		{
			return null;
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C5")]
		[Address(RVA = "0x15C9470", Offset = "0x15C9470", VA = "0x7BBBDC9470")]
		protected void FillTeammateStatsToPlayerData(TeammateStats stats, PlayerData player)
		{
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C6")]
		[Address(RVA = "0x15C94B4", Offset = "0x15C94B4", VA = "0x7BBBDC94B4")]
		protected void FillMatchStatsToPlayerData(MatchStats stats, PlayerData player)
		{
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C7")]
		[Address(RVA = "0x15C94EC", Offset = "0x15C94EC", VA = "0x7BBBDC94EC")]
		protected FMatchResultPlayerData GetPlayerMatchResultData(ulong accountID)
		{
			return null;
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x0001CB30 File Offset: 0x0001AD30
		[Token(Token = "0x60063C8")]
		[Address(RVA = "0x15C6538", Offset = "0x15C6538", VA = "0x7BBBDC6538")]
		private bool CanUpdateCountDown()
		{
			return default(bool);
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C9")]
		[Address(RVA = "0x15C9578", Offset = "0x15C9578", VA = "0x7BBBDC9578")]
		private void ConstructPlayerMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CA")]
		[Address(RVA = "0x15C714C", Offset = "0x15C714C", VA = "0x7BBBDC714C")]
		private void ShowMatchResultUIData(MatchIncome income, MatchStats stats)
		{
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CB")]
		[Address(RVA = "0x15CA564", Offset = "0x15CA564", VA = "0x7BBBDCA564")]
		private void ShowBiaoqianWindow(MatchIncome income, MatchStats stats)
		{
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CC")]
		[Address(RVA = "0x15CAE88", Offset = "0x15CAE88", VA = "0x7BBBDCAE88")]
		private void OnStateMachineFinish()
		{
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CD")]
		[Address(RVA = "0x15C6624", Offset = "0x15C6624", VA = "0x7BBBDC6624")]
		private void OnClickNextBtn()
		{
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CE")]
		[Address(RVA = "0x15CB268", Offset = "0x15CB268", VA = "0x7BBBDCB268")]
		private void OnClickDetailsBtn()
		{
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CF")]
		[Address(RVA = "0x15CB390", Offset = "0x15CB390", VA = "0x7BBBDCB390")]
		private void OnClickFastSendGiftBtn()
		{
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D0")]
		[Address(RVA = "0x15CB56C", Offset = "0x15CB56C", VA = "0x7BBBDCB56C")]
		private void OnClickVideoGiftBtn()
		{
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D1")]
		[Address(RVA = "0x15CAEC8", Offset = "0x15CAEC8", VA = "0x7BBBDCAEC8")]
		private void ShowAvatarInfoUI()
		{
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D2")]
		[Address(RVA = "0x15CB0BC", Offset = "0x15CB0BC", VA = "0x7BBBDCB0BC")]
		private void ShowMatchResultDetailUI()
		{
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D3")]
		[Address(RVA = "0x15CB2D0", Offset = "0x15CB2D0", VA = "0x7BBBDCB2D0")]
		private void HideMatchResultDetailUI()
		{
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D4")]
		[Address(RVA = "0x15CA21C", Offset = "0x15CA21C", VA = "0x7BBBDCA21C")]
		private void CheckNeedShowRewardBtn()
		{
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D5")]
		[Address(RVA = "0x15CBAD4", Offset = "0x15CBAD4", VA = "0x7BBBDCBAD4")]
		private void OnWatchVideoSuccess(params object[] param)
		{
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D6")]
		[Address(RVA = "0x15CBB34", Offset = "0x15CBB34", VA = "0x7BBBDCBB34")]
		private void OnFastSendGiftPanelClose(params object[] data)
		{
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D7")]
		[Address(RVA = "0x15CBB3C", Offset = "0x15CBB3C", VA = "0x7BBBDCBB3C")]
		private void ShowClanMatchResult(params object[] data)
		{
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0x15CBC34", Offset = "0x15CBC34", VA = "0x7BBBDCBC34")]
		public void SetTimeCutDown(params object[] data)
		{
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D9")]
		[Address(RVA = "0x15C9FB0", Offset = "0x15C9FB0", VA = "0x7BBBDC9FB0")]
		private void SetResultDescTextByRank(uint rank)
		{
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DA")]
		[Address(RVA = "0x15C97A8", Offset = "0x15C97A8", VA = "0x7BBBDC97A8")]
		private void CreatePlayerMatchResultData(ulong accountID, ulong localPlayerID, bool isFriend = false)
		{
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DB")]
		[Address(RVA = "0x15C7060", Offset = "0x15C7060", VA = "0x7BBBDC7060")]
		private void OnMatchResultNoResultFound(params object[] data)
		{
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DC")]
		[Address(RVA = "0x15CAC24", Offset = "0x15CAC24", VA = "0x7BBBDCAC24")]
		private void CreateMVPAvatarInMatchResult(List<PlayerData> players)
		{
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x0001CB48 File Offset: 0x0001AD48
		[Token(Token = "0x60063DD")]
		[Address(RVA = "0x15CBC3C", Offset = "0x15CBC3C", VA = "0x7BBBDCBC3C", Slot = "40")]
		protected virtual int SortPlayerData(PlayerData player1, PlayerData player2)
		{
			return 0;
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x0001CB60 File Offset: 0x0001AD60
		[Token(Token = "0x60063DE")]
		[Address(RVA = "0x15CBC84", Offset = "0x15CBC84", VA = "0x7BBBDCBC84", Slot = "41")]
		protected virtual int SortTeammateData(TeammateStats player1, TeammateStats player2)
		{
			return 0;
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0x15CBCCC", Offset = "0x15CBCCC", VA = "0x7BBBDCBCCC", Slot = "42")]
		protected virtual EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0x15CBCD4", Offset = "0x15CBCD4", VA = "0x7BBBDCBCD4", Slot = "43")]
		protected virtual void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E1")]
		[Address(RVA = "0x15CBCD8", Offset = "0x15CBCD8", VA = "0x7BBBDCBCD8", Slot = "44")]
		protected virtual void OnShowMatchResultDetailUI(bool show)
		{
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E2")]
		[Address(RVA = "0x15CBCDC", Offset = "0x15CBCDC", VA = "0x7BBBDCBCDC", Slot = "45")]
		protected virtual void OnShowAvatarInfoUI()
		{
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E3")]
		[Address(RVA = "0x15CBCE0", Offset = "0x15CBCE0", VA = "0x7BBBDCBCE0", Slot = "46")]
		protected virtual void OnUpdate(float delta)
		{
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E4")]
		[Address(RVA = "0x15CBCE4", Offset = "0x15CBCE4", VA = "0x7BBBDCBCE4", Slot = "47")]
		protected virtual List<PlayerData> CreateShowAvatarPlayerData()
		{
			return null;
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x0001CB78 File Offset: 0x0001AD78
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0x15CBFE0", Offset = "0x15CBFE0", VA = "0x7BBBDCBFE0", Slot = "48")]
		protected virtual bool CheckIsWin(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0x15CBFFC", Offset = "0x15CBFFC", VA = "0x7BBBDCBFFC", Slot = "49")]
		protected virtual void OnFixMatchInfoForLanguage()
		{
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0x15C8F2C", Offset = "0x15C8F2C", VA = "0x7BBBDC8F2C")]
		public static string SetMatchResultPlayerInfoString(UILabel label, EMatchResultPlayerInfoType type)
		{
			return null;
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E8")]
		[Address(RVA = "0x15CC000", Offset = "0x15CC000", VA = "0x7BBBDCC000")]
		public UIHudMatchResultBaseController()
		{
		}

		// Token: 0x04008280 RID: 33408
		[Token(Token = "0x4008280")]
		protected const string ANIM_PARAM_TRIGGER_OPEN = "open";

		// Token: 0x04008281 RID: 33409
		[Token(Token = "0x4008281")]
		protected const string ANIM_PARAM_TRIGGER_CLOSE = "close";

		// Token: 0x04008282 RID: 33410
		[Token(Token = "0x4008282")]
		protected const string ANIM_PARAM_BOOL_DETAIL = "detail";

		// Token: 0x04008283 RID: 33411
		[Token(Token = "0x4008283")]
		private const int AUTO_SHOW_DETAIL_COUNTDOWN = 20;

		// Token: 0x04008284 RID: 33412
		[Token(Token = "0x4008284")]
		private const int AUTO_RETURN_LOBBY_COUNTDOWN = 30;

		// Token: 0x04008285 RID: 33413
		[Token(Token = "0x4008285")]
		private const int DETAIL_BUTTON_CLICK_INTERVAL = 1;

		// Token: 0x04008286 RID: 33414
		[Token(Token = "0x4008286")]
		[FieldOffset(Offset = "0xD8")]
		private float m_CurrentNextCountDownTime;

		// Token: 0x04008287 RID: 33415
		[Token(Token = "0x4008287")]
		[FieldOffset(Offset = "0xDC")]
		private float m_CurrentDetailClickTime;

		// Token: 0x04008288 RID: 33416
		[Token(Token = "0x4008288")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_NoFoundMatchResult;

		// Token: 0x04008289 RID: 33417
		[Token(Token = "0x4008289")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_IsShowUIData;

		// Token: 0x0400828A RID: 33418
		[Token(Token = "0x400828A")]
		[FieldOffset(Offset = "0xE2")]
		private bool m_HasShowDetailUI;

		// Token: 0x0400828B RID: 33419
		[Token(Token = "0x400828B")]
		[FieldOffset(Offset = "0xE3")]
		private bool m_IsShowDetailUI;

		// Token: 0x0400828C RID: 33420
		[Token(Token = "0x400828C")]
		[FieldOffset(Offset = "0xE8")]
		private TeammateStats m_MVPPlayerData;

		// Token: 0x0400828D RID: 33421
		[Token(Token = "0x400828D")]
		[FieldOffset(Offset = "0xF0")]
		protected bool m_BiaoqianState;

		// Token: 0x0400828E RID: 33422
		[Token(Token = "0x400828E")]
		[FieldOffset(Offset = "0xF8")]
		private List<EMatchResultPlayerInfoType> m_InfoTypeList;

		// Token: 0x0400828F RID: 33423
		[Token(Token = "0x400828F")]
		[FieldOffset(Offset = "0x100")]
		private List<UIHudMatchResultItemBaseController> m_ItemCtrlList;

		// Token: 0x04008290 RID: 33424
		[Token(Token = "0x4008290")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<ulong, FMatchResultPlayerData> m_PlayerMatchResultDataMap;

		// Token: 0x04008291 RID: 33425
		[Token(Token = "0x4008291")]
		[FieldOffset(Offset = "0x110")]
		private bool m_IsShowFastSendGift;

		// Token: 0x04008292 RID: 33426
		[Token(Token = "0x4008292")]
		[FieldOffset(Offset = "0x111")]
		private bool m_IsShowClanPopWnd;

		// Token: 0x04008293 RID: 33427
		[Token(Token = "0x4008293")]
		[FieldOffset(Offset = "0x112")]
		private bool m_HasWatchRewardVideo;

		// Token: 0x04008294 RID: 33428
		[Token(Token = "0x4008294")]
		[FieldOffset(Offset = "0x113")]
		private bool m_IsWin;

		// Token: 0x04008295 RID: 33429
		[Token(Token = "0x4008295")]
		[FieldOffset(Offset = "0x118")]
		private UIHudMatchResultStateMachine m_StateMachine;

		// Token: 0x04008296 RID: 33430
		[Token(Token = "0x4008296")]
		[FieldOffset(Offset = "0x120")]
		private Camera m_ResultBGCamera;

		// Token: 0x04008297 RID: 33431
		[Token(Token = "0x4008297")]
		[FieldOffset(Offset = "0x128")]
		private Camera m_ResultAvatarCamera;

		// Token: 0x04008298 RID: 33432
		[Token(Token = "0x4008298")]
		[FieldOffset(Offset = "0x130")]
		private UIMaleAvatar m_MVPAvatar;

		// Token: 0x04008299 RID: 33433
		[Token(Token = "0x4008299")]
		[FieldOffset(Offset = "0x138")]
		protected UIBaseView BaseView;

		// Token: 0x0400829A RID: 33434
		[Token(Token = "0x400829A")]
		[FieldOffset(Offset = "0x140")]
		protected Transform BaseRewardRoot;

		// Token: 0x0400829B RID: 33435
		[Token(Token = "0x400829B")]
		[FieldOffset(Offset = "0x148")]
		protected Transform BaseCallSignContainer;

		// Token: 0x0400829C RID: 33436
		[Token(Token = "0x400829C")]
		[FieldOffset(Offset = "0x150")]
		protected UILabel GameModeTxt;

		// Token: 0x0400829D RID: 33437
		[Token(Token = "0x400829D")]
		[FieldOffset(Offset = "0x158")]
		protected UILabel GameMapTxt;

		// Token: 0x0400829E RID: 33438
		[Token(Token = "0x400829E")]
		[FieldOffset(Offset = "0x160")]
		protected Animator MatchResultAni;

		// Token: 0x0400829F RID: 33439
		[Token(Token = "0x400829F")]
		[FieldOffset(Offset = "0x168")]
		protected GameObject BiaoQianOB;

		// Token: 0x040082A0 RID: 33440
		[Token(Token = "0x40082A0")]
		[FieldOffset(Offset = "0x170")]
		private GameObject m_ShareInfoContainer;

		// Token: 0x040082A1 RID: 33441
		[Token(Token = "0x40082A1")]
		[FieldOffset(Offset = "0x178")]
		private Transform m_ProfileFormationTran;

		// Token: 0x040082A2 RID: 33442
		[Token(Token = "0x40082A2")]
		[FieldOffset(Offset = "0x180")]
		private UIButton m_ShareBtn;

		// Token: 0x040082A3 RID: 33443
		[Token(Token = "0x40082A3")]
		[FieldOffset(Offset = "0x188")]
		private UIButton m_DetailBtn;

		// Token: 0x040082A4 RID: 33444
		[Token(Token = "0x40082A4")]
		[FieldOffset(Offset = "0x190")]
		private UIButton m_NextBtn;

		// Token: 0x040082A5 RID: 33445
		[Token(Token = "0x40082A5")]
		[FieldOffset(Offset = "0x198")]
		protected UILabel NextBtnTime;

		// Token: 0x040082A6 RID: 33446
		[Token(Token = "0x40082A6")]
		[FieldOffset(Offset = "0x1A0")]
		protected UILabel NextBtnLabel;

		// Token: 0x040082A7 RID: 33447
		[Token(Token = "0x40082A7")]
		[FieldOffset(Offset = "0x1A8")]
		protected UILabel ResultDesc;

		// Token: 0x040082A8 RID: 33448
		[Token(Token = "0x40082A8")]
		[FieldOffset(Offset = "0x1B0")]
		protected UIWidget Biaoqian1;

		// Token: 0x040082A9 RID: 33449
		[Token(Token = "0x40082A9")]
		[FieldOffset(Offset = "0x1B8")]
		protected UIWidget Biaoqian2;

		// Token: 0x040082AA RID: 33450
		[Token(Token = "0x40082AA")]
		[FieldOffset(Offset = "0x1C0")]
		protected UIWidget Biaoqian3;

		// Token: 0x040082AB RID: 33451
		[Token(Token = "0x40082AB")]
		[FieldOffset(Offset = "0x1C8")]
		protected UIWidget Biaoqian4;

		// Token: 0x040082AC RID: 33452
		[Token(Token = "0x40082AC")]
		[FieldOffset(Offset = "0x1D0")]
		protected UIWidget BiaoqianPlaceHolder;

		// Token: 0x040082AD RID: 33453
		[Token(Token = "0x40082AD")]
		[FieldOffset(Offset = "0x1D8")]
		protected UIWidget Biaoqian1Share1;

		// Token: 0x040082AE RID: 33454
		[Token(Token = "0x40082AE")]
		[FieldOffset(Offset = "0x1E0")]
		protected UIWidget Biaoqian1Share2;

		// Token: 0x040082AF RID: 33455
		[Token(Token = "0x40082AF")]
		[FieldOffset(Offset = "0x1E8")]
		protected UIWidget Biaoqian1Share3;

		// Token: 0x040082B0 RID: 33456
		[Token(Token = "0x40082B0")]
		[FieldOffset(Offset = "0x1F0")]
		protected UIWidget Biaoqian1Share4;

		// Token: 0x040082B1 RID: 33457
		[Token(Token = "0x40082B1")]
		[FieldOffset(Offset = "0x1F8")]
		protected UIGrid RewardBtnGrid;

		// Token: 0x040082B2 RID: 33458
		[Token(Token = "0x40082B2")]
		[FieldOffset(Offset = "0x200")]
		private UIButton m_FastSendGiftBtn;

		// Token: 0x040082B3 RID: 33459
		[Token(Token = "0x40082B3")]
		[FieldOffset(Offset = "0x208")]
		private UIButton m_VideoGiftBtn;

		// Token: 0x020015EF RID: 5615
		[Token(Token = "0x20015EF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF5FC", Offset = "0x10EF5FC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060063EA RID: 25578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063EA")]
			[Address(RVA = "0x15CC06C", Offset = "0x15CC06C", VA = "0x7BBBDCC06C")]
			public <>c()
			{
			}

			// Token: 0x060063EB RID: 25579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063EB")]
			[Address(RVA = "0x15CC074", Offset = "0x15CC074", VA = "0x7BBBDCC074")]
			internal void <ReturnToLobby>b__82_0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x060063EC RID: 25580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60063EC")]
			[Address(RVA = "0x15CC078", Offset = "0x15CC078", VA = "0x7BBBDCC078")]
			internal FriendInfo <OnClickFastSendGiftBtn>b__98_0(TeammateStats teamMate)
			{
				return null;
			}

			// Token: 0x040082B4 RID: 33460
			[Token(Token = "0x40082B4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudMatchResultBaseController.<>c <>9;

			// Token: 0x040082B5 RID: 33461
			[Token(Token = "0x40082B5")]
			[FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__82_0;

			// Token: 0x040082B6 RID: 33462
			[Token(Token = "0x40082B6")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<TeammateStats, FriendInfo> <>9__98_0;
		}
	}
}
