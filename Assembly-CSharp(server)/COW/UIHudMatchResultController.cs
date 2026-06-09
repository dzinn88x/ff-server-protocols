using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001911 RID: 6417
	[Token(Token = "0x2001911")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F573C", Offset = "0x10F573C")]
	internal class UIHudMatchResultController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06008113 RID: 33043 RVA: 0x00023328 File Offset: 0x00021528
		[Token(Token = "0x170009A9")]
		public bool IsShowingRewardVideoController
		{
			[Token(Token = "0x6008113")]
			[Address(RVA = "0x15CE974", Offset = "0x15CE974", VA = "0x7BBBDCE974")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x00023340 File Offset: 0x00021540
		[Token(Token = "0x6008114")]
		[Address(RVA = "0x15CE9E4", Offset = "0x15CE9E4", VA = "0x7BBBDCE9E4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008115")]
		[Address(RVA = "0x15CEA34", Offset = "0x15CEA34", VA = "0x7BBBDCEA34", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008116 RID: 33046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008116")]
		[Address(RVA = "0x15CF4EC", Offset = "0x15CF4EC", VA = "0x7BBBDCF4EC")]
		private void CheckNeedShowRewardBtn(uint surviveTime)
		{
		}

		// Token: 0x06008117 RID: 33047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008117")]
		[Address(RVA = "0x15CF450", Offset = "0x15CF450", VA = "0x7BBBDCF450")]
		private void ShowRewardBtn(bool showRewardBtn)
		{
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008118")]
		[Address(RVA = "0x15CF65C", Offset = "0x15CF65C", VA = "0x7BBBDCF65C")]
		private void WatchVideoSuccess(params object[] data)
		{
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008119")]
		[Address(RVA = "0x15CF66C", Offset = "0x15CF66C", VA = "0x7BBBDCF66C")]
		private void OnFastSendGiftPanelClose(params object[] data)
		{
		}

		// Token: 0x0600811A RID: 33050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600811A")]
		[Address(RVA = "0x15CF674", Offset = "0x15CF674", VA = "0x7BBBDCF674")]
		private void OnFastSendGiftBtnClick()
		{
		}

		// Token: 0x0600811B RID: 33051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600811B")]
		[Address(RVA = "0x15CF850", Offset = "0x15CF850", VA = "0x7BBBDCF850", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600811C")]
		[Address(RVA = "0x15CFB40", Offset = "0x15CFB40", VA = "0x7BBBDCFB40", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600811D")]
		[Address(RVA = "0x15CFCA8", Offset = "0x15CFCA8", VA = "0x7BBBDCFCA8")]
		private void Update()
		{
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600811E")]
		[Address(RVA = "0x15CFDE0", Offset = "0x15CFDE0", VA = "0x7BBBDCFDE0")]
		public void OnBackToLobbyButtonClick()
		{
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600811F")]
		[Address(RVA = "0x15CFF18", Offset = "0x15CFF18", VA = "0x7BBBDCFF18")]
		private void MakeShareImage()
		{
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008120")]
		[Address(RVA = "0x15D02B0", Offset = "0x15D02B0", VA = "0x7BBBDD02B0")]
		private void ShowSharePanel()
		{
		}

		// Token: 0x06008121 RID: 33057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008121")]
		[Address(RVA = "0x15D039C", Offset = "0x15D039C", VA = "0x7BBBDD039C")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x06008122 RID: 33058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008122")]
		[Address(RVA = "0x15D03B8", Offset = "0x15D03B8", VA = "0x7BBBDD03B8")]
		private void OnRewardBtnClick()
		{
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008123")]
		[Address(RVA = "0x15D0928", Offset = "0x15D0928", VA = "0x7BBBDD0928", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008124")]
		[Address(RVA = "0x15D196C", Offset = "0x15D196C", VA = "0x7BBBDD196C")]
		private string MakeEndgameDescription(uint rank)
		{
			return null;
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008125")]
		[Address(RVA = "0x15D0B0C", Offset = "0x15D0B0C", VA = "0x7BBBDD0B0C")]
		public void ShowUI(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008126")]
		[Address(RVA = "0x15D2E5C", Offset = "0x15D2E5C", VA = "0x7BBBDD2E5C")]
		private void ShowPVEDifficultyUI(uint difficulty)
		{
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008127")]
		[Address(RVA = "0x15D51A0", Offset = "0x15D51A0", VA = "0x7BBBDD51A0")]
		private void ShowBiaoqianWindow(MatchIncome income, MatchStats stats)
		{
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008128")]
		[Address(RVA = "0x15D5900", Offset = "0x15D5900", VA = "0x7BBBDD5900", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008129")]
		[Address(RVA = "0x15D59C0", Offset = "0x15D59C0", VA = "0x7BBBDD59C0", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812A")]
		[Address(RVA = "0x15D1B58", Offset = "0x15D1B58", VA = "0x7BBBDD1B58")]
		private void SetPVERewardUI(MatchStats statsData, MatchIncome incomeData)
		{
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812B")]
		[Address(RVA = "0x15D2AB4", Offset = "0x15D2AB4", VA = "0x7BBBDD2AB4")]
		private void ShowPlayerInfoUI(MatchStats statsData)
		{
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812C")]
		[Address(RVA = "0x15D2BA8", Offset = "0x15D2BA8", VA = "0x7BBBDD2BA8")]
		private void ShowModeNameUI()
		{
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812D")]
		[Address(RVA = "0x15D2DA8", Offset = "0x15D2DA8", VA = "0x7BBBDD2DA8")]
		private void ShowGroupMode(uint _groupMode)
		{
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812E")]
		[Address(RVA = "0x15D1F64", Offset = "0x15D1F64", VA = "0x7BBBDD1F64")]
		private void ShowKillerInfoUI()
		{
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812F")]
		[Address(RVA = "0x15D27B8", Offset = "0x15D27B8", VA = "0x7BBBDD27B8")]
		private void ShowPVEResultUI(bool is_win)
		{
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008130")]
		[Address(RVA = "0x15D2328", Offset = "0x15D2328", VA = "0x7BBBDD2328")]
		private void ShowAchievementUI(uint[] achievements)
		{
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008131")]
		[Address(RVA = "0x15D48A4", Offset = "0x15D48A4", VA = "0x7BBBDD48A4")]
		private void ShowRoomMatchUI(MatchStats statsData)
		{
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008132")]
		[Address(RVA = "0x15D3994", Offset = "0x15D3994", VA = "0x7BBBDD3994")]
		private void ShowCommonMatchUI(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008133")]
		[Address(RVA = "0x15D3E30", Offset = "0x15D3E30", VA = "0x7BBBDD3E30")]
		private void ShowPVERoomMatchUI(MatchStats statsData)
		{
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008134")]
		[Address(RVA = "0x15D2F08", Offset = "0x15D2F08", VA = "0x7BBBDD2F08")]
		private void ShowPVECommonMatchUI(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008135")]
		[Address(RVA = "0x15D6378", Offset = "0x15D6378", VA = "0x7BBBDD6378")]
		private TeammateStats GetCSMVPTeammateStats(List<TeammateStats> teammatesData)
		{
			return null;
		}

		// Token: 0x06008136 RID: 33078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008136")]
		[Address(RVA = "0x15D43E4", Offset = "0x15D43E4", VA = "0x7BBBDD43E4")]
		private void ShowCSRoomMatchUI(MatchStats statsData)
		{
		}

		// Token: 0x06008137 RID: 33079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008137")]
		[Address(RVA = "0x15D34CC", Offset = "0x15D34CC", VA = "0x7BBBDD34CC")]
		private void ShowCSMatchUI(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008138")]
		[Address(RVA = "0x15C11F8", Offset = "0x15C11F8", VA = "0x7BBBDC11F8")]
		public static void ShowRewards(MatchIncome incomeData, List<BaseItemInfo> rewardList)
		{
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008139")]
		[Address(RVA = "0x15D5A80", Offset = "0x15D5A80", VA = "0x7BBBDD5A80")]
		private void ShowItemAndRewardUI(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x00023358 File Offset: 0x00021558
		[Token(Token = "0x600813A")]
		[Address(RVA = "0x15D659C", Offset = "0x15D659C", VA = "0x7BBBDD659C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813B")]
		[Address(RVA = "0x15D65E0", Offset = "0x15D65E0", VA = "0x7BBBDD65E0")]
		public void OnDebrisRewardWindowClosed(params object[] param)
		{
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813C")]
		[Address(RVA = "0x15D65E4", Offset = "0x15D65E4", VA = "0x7BBBDD65E4")]
		public void OnLadderPopupClosed(params object[] param)
		{
		}

		// Token: 0x0600813D RID: 33085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813D")]
		[Address(RVA = "0x15D7014", Offset = "0x15D7014", VA = "0x7BBBDD7014")]
		private void OnScreenshotResponse(params object[] param)
		{
		}

		// Token: 0x0600813E RID: 33086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813E")]
		[Address(RVA = "0x15D711C", Offset = "0x15D711C", VA = "0x7BBBDD711C")]
		private void OnOpenDetail(MatchResultDetailInfo info, Vector3 pos)
		{
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600813F")]
		[Address(RVA = "0x15D724C", Offset = "0x15D724C", VA = "0x7BBBDD724C")]
		private void OnClickMask()
		{
		}

		// Token: 0x06008140 RID: 33088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008140")]
		[Address(RVA = "0x15D4C88", Offset = "0x15D4C88", VA = "0x7BBBDD4C88")]
		private void UpdateRedEnvelopeUI(List<ReceivedRedEnvelope> received_red_envelope)
		{
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008141")]
		[Address(RVA = "0x15D7308", Offset = "0x15D7308", VA = "0x7BBBDD7308")]
		private void OnClickRedAwardDetailBtn()
		{
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008142")]
		[Address(RVA = "0x15D74B8", Offset = "0x15D74B8", VA = "0x7BBBDD74B8")]
		private void OnClickAllRewardListBtn()
		{
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008143")]
		[Address(RVA = "0x15D757C", Offset = "0x15D757C", VA = "0x7BBBDD757C")]
		private void OnMatchResultNoResultFound(params object[] data)
		{
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008144")]
		[Address(RVA = "0x15D64A8", Offset = "0x15D64A8", VA = "0x7BBBDD64A8")]
		private void ShowClanMatchResult(params object[] data)
		{
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008145")]
		[Address(RVA = "0x15D790C", Offset = "0x15D790C", VA = "0x7BBBDD790C")]
		public void SetTimeCutDown(params object[] data)
		{
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008146")]
		[Address(RVA = "0x15D7918", Offset = "0x15D7918", VA = "0x7BBBDD7918")]
		public UIHudMatchResultController()
		{
		}

		// Token: 0x040092F4 RID: 37620
		[Token(Token = "0x40092F4")]
		[FieldOffset(Offset = "0x58")]
		private UIHudMatchResultViewEx m_View;

		// Token: 0x040092F5 RID: 37621
		[Token(Token = "0x40092F5")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_MatchModel;

		// Token: 0x040092F6 RID: 37622
		[Token(Token = "0x40092F6")]
		[FieldOffset(Offset = "0x68")]
		private float m_CountDownTime;

		// Token: 0x040092F7 RID: 37623
		[Token(Token = "0x40092F7")]
		[FieldOffset(Offset = "0x70")]
		private RenderTexture m_DynamicRenderTexture;

		// Token: 0x040092F8 RID: 37624
		[Token(Token = "0x40092F8")]
		[FieldOffset(Offset = "0x78")]
		private RenderTexture m_ShareScreenShotTexture;

		// Token: 0x040092F9 RID: 37625
		[Token(Token = "0x40092F9")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsBtnLocked;

		// Token: 0x040092FA RID: 37626
		[Token(Token = "0x40092FA")]
		[FieldOffset(Offset = "0x81")]
		private bool m_IsShowSendGift;

		// Token: 0x040092FB RID: 37627
		[Token(Token = "0x40092FB")]
		[FieldOffset(Offset = "0x82")]
		private bool m_CanTimeCutDown;

		// Token: 0x040092FC RID: 37628
		[Token(Token = "0x40092FC")]
		[FieldOffset(Offset = "0x88")]
		private ulong mvpID;

		// Token: 0x040092FD RID: 37629
		[Token(Token = "0x40092FD")]
		[FieldOffset(Offset = "0x90")]
		private uint all_damage;

		// Token: 0x040092FE RID: 37630
		[Token(Token = "0x40092FE")]
		[FieldOffset(Offset = "0x98")]
		private string m_ScreenshotFilePath;

		// Token: 0x040092FF RID: 37631
		[Token(Token = "0x40092FF")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_IsHaveShareFile;

		// Token: 0x04009300 RID: 37632
		[Token(Token = "0x4009300")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_HasWatchRewardVideo;

		// Token: 0x04009301 RID: 37633
		[Token(Token = "0x4009301")]
		[FieldOffset(Offset = "0xA2")]
		protected bool m_BiaoqianState;

		// Token: 0x04009302 RID: 37634
		[Token(Token = "0x4009302")]
		[FieldOffset(Offset = "0xA8")]
		private UIRewardedVideoPopupWindowController m_RewardVideoController;

		// Token: 0x04009303 RID: 37635
		[Token(Token = "0x4009303")]
		[FieldOffset(Offset = "0xB0")]
		private List<LadderLevelData> rankUpRewardList;

		// Token: 0x04009304 RID: 37636
		[Token(Token = "0x4009304")]
		[FieldOffset(Offset = "0xB8")]
		private List<CSRankData> csRankUpRewardList;

		// Token: 0x04009305 RID: 37637
		[Token(Token = "0x4009305")]
		[FieldOffset(Offset = "0xC0")]
		private List<ReceivedRedEnvelope> receivedRedEnvelope;

		// Token: 0x04009306 RID: 37638
		[Token(Token = "0x4009306")]
		[FieldOffset(Offset = "0xC8")]
		private List<BaseItemInfo> rewardList;

		// Token: 0x04009307 RID: 37639
		[Token(Token = "0x4009307")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_CallOnce;

		// Token: 0x04009308 RID: 37640
		[Token(Token = "0x4009308")]
		[FieldOffset(Offset = "0xD8")]
		private MatchIncome m_MatchIncomeData;

		// Token: 0x04009309 RID: 37641
		[Token(Token = "0x4009309")]
		[FieldOffset(Offset = "0xE0")]
		private MatchStats m_MatchStatsData;

		// Token: 0x02001912 RID: 6418
		[Token(Token = "0x2001912")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F5774", Offset = "0x10F5774")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008148 RID: 33096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008148")]
			[Address(RVA = "0x17A56B0", Offset = "0x17A56B0", VA = "0x7BBBFA56B0")]
			public <>c()
			{
			}

			// Token: 0x06008149 RID: 33097 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008149")]
			[Address(RVA = "0x17A56B8", Offset = "0x17A56B8", VA = "0x7BBBFA56B8")]
			internal FriendInfo <OnFastSendGiftBtnClick>b__27_0(TeammateStats teamMate)
			{
				return null;
			}

			// Token: 0x0600814A RID: 33098 RVA: 0x00023370 File Offset: 0x00021570
			[Token(Token = "0x600814A")]
			[Address(RVA = "0x17A56C4", Offset = "0x17A56C4", VA = "0x7BBBFA56C4")]
			internal int <GetCSMVPTeammateStats>b__57_0(TeammateStats a, TeammateStats b)
			{
				return 0;
			}

			// Token: 0x0600814B RID: 33099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600814B")]
			[Address(RVA = "0x17A5748", Offset = "0x17A5748", VA = "0x7BBBFA5748")]
			internal CommonRewardItemInfo <ShowRewards>b__60_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600814C RID: 33100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600814C")]
			[Address(RVA = "0x17A5754", Offset = "0x17A5754", VA = "0x7BBBFA5754")]
			internal void <OnLadderPopupClosed>b__64_0()
			{
			}

			// Token: 0x0600814D RID: 33101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600814D")]
			[Address(RVA = "0x17A5854", Offset = "0x17A5854", VA = "0x7BBBFA5854")]
			internal BaseItemInfo <OnLadderPopupClosed>b__64_1(AwardDesc item)
			{
				return null;
			}

			// Token: 0x0600814E RID: 33102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600814E")]
			[Address(RVA = "0x17A58BC", Offset = "0x17A58BC", VA = "0x7BBBFA58BC")]
			internal CommonRewardItemInfo <OnLadderPopupClosed>b__64_2(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600814F RID: 33103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600814F")]
			[Address(RVA = "0x17A58C8", Offset = "0x17A58C8", VA = "0x7BBBFA58C8")]
			internal void <OnLadderPopupClosed>b__64_3()
			{
			}

			// Token: 0x06008150 RID: 33104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008150")]
			[Address(RVA = "0x17A5964", Offset = "0x17A5964", VA = "0x7BBBFA5964")]
			internal CommonRewardItemInfo <OnLadderPopupClosed>b__64_4(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400930A RID: 37642
			[Token(Token = "0x400930A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudMatchResultController.<>c <>9;

			// Token: 0x0400930B RID: 37643
			[Token(Token = "0x400930B")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<TeammateStats, FriendInfo> <>9__27_0;

			// Token: 0x0400930C RID: 37644
			[Token(Token = "0x400930C")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<TeammateStats> <>9__57_0;

			// Token: 0x0400930D RID: 37645
			[Token(Token = "0x400930D")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__60_0;

			// Token: 0x0400930E RID: 37646
			[Token(Token = "0x400930E")]
			[FieldOffset(Offset = "0x20")]
			public static Action <>9__64_0;

			// Token: 0x0400930F RID: 37647
			[Token(Token = "0x400930F")]
			[FieldOffset(Offset = "0x28")]
			public static Converter<AwardDesc, BaseItemInfo> <>9__64_1;

			// Token: 0x04009310 RID: 37648
			[Token(Token = "0x4009310")]
			[FieldOffset(Offset = "0x30")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__64_2;

			// Token: 0x04009311 RID: 37649
			[Token(Token = "0x4009311")]
			[FieldOffset(Offset = "0x38")]
			public static Action <>9__64_3;

			// Token: 0x04009312 RID: 37650
			[Token(Token = "0x4009312")]
			[FieldOffset(Offset = "0x40")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__64_4;
		}
	}
}
