using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019A2 RID: 6562
	[Token(Token = "0x20019A2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6BF4", Offset = "0x10F6BF4")]
	public class UIHudWereWolvesVoteController : UIBaseController, IEasyList
	{
		// Token: 0x06008643 RID: 34371 RVA: 0x000245D0 File Offset: 0x000227D0
		[Token(Token = "0x6008643")]
		[Address(RVA = "0x1D18FE0", Offset = "0x1D18FE0", VA = "0x7BBC518FE0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008644")]
		[Address(RVA = "0x1D19030", Offset = "0x1D19030", VA = "0x7BBC519030", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008645")]
		[Address(RVA = "0x1D19870", Offset = "0x1D19870", VA = "0x7BBC519870", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008646")]
		[Address(RVA = "0x1D19B34", Offset = "0x1D19B34", VA = "0x7BBC519B34", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008647")]
		[Address(RVA = "0x1D19F7C", Offset = "0x1D19F7C", VA = "0x7BBC519F7C")]
		private void RefreshDescription()
		{
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008648")]
		[Address(RVA = "0x1D1A184", Offset = "0x1D1A184", VA = "0x7BBC51A184", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008649")]
		[Address(RVA = "0x1D1A3F0", Offset = "0x1D1A3F0", VA = "0x7BBC51A3F0")]
		private void OnQuickChatItemClick(params object[] data)
		{
		}

		// Token: 0x0600864A RID: 34378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600864A")]
		[Address(RVA = "0x1D19DD8", Offset = "0x1D19DD8", VA = "0x7BBC519DD8")]
		private void OnRefreshChatInfo(params object[] data)
		{
		}

		// Token: 0x0600864B RID: 34379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600864B")]
		[Address(RVA = "0x1D1A59C", Offset = "0x1D1A59C", VA = "0x7BBC51A59C")]
		private void OnRefreshSponsor(params object[] data)
		{
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600864C")]
		[Address(RVA = "0x1D1A89C", Offset = "0x1D1A89C", VA = "0x7BBC51A89C")]
		private void OnVotePlayer()
		{
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600864D")]
		[Address(RVA = "0x1D1AC1C", Offset = "0x1D1AC1C", VA = "0x7BBC51AC1C")]
		private void OnSkipVote()
		{
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600864E")]
		[Address(RVA = "0x1D1A210", Offset = "0x1D1A210", VA = "0x7BBC51A210")]
		public void OnRefreshVoteList(params object[] data)
		{
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600864F")]
		[Address(RVA = "0x1D1AD00", Offset = "0x1D1AD00", VA = "0x7BBC51AD00")]
		private void RefreshSkippedList()
		{
		}

		// Token: 0x06008650 RID: 34384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008650")]
		[Address(RVA = "0x1D1B160", Offset = "0x1D1B160", VA = "0x7BBC51B160")]
		private void RefreshChatNode()
		{
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008651")]
		[Address(RVA = "0x1D1B2C0", Offset = "0x1D1B2C0", VA = "0x7BBC51B2C0")]
		public void OnNewPhase(params object[] param)
		{
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008652")]
		[Address(RVA = "0x1D1B5D4", Offset = "0x1D1B5D4", VA = "0x7BBC51B5D4")]
		public void OnEndTimeCome(params object[] param)
		{
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008653")]
		[Address(RVA = "0x1D1B79C", Offset = "0x1D1B79C", VA = "0x7BBC51B79C")]
		private void Update()
		{
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008654")]
		[Address(RVA = "0x1D1B9F4", Offset = "0x1D1B9F4", VA = "0x7BBC51B9F4")]
		private void OnMap()
		{
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008655")]
		[Address(RVA = "0x1D1BB6C", Offset = "0x1D1BB6C", VA = "0x7BBC51BB6C")]
		private void OnSendChat()
		{
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008656")]
		[Address(RVA = "0x1D1BE60", Offset = "0x1D1BE60", VA = "0x7BBC51BE60")]
		private void OnQuickChat()
		{
		}

		// Token: 0x06008657 RID: 34391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008657")]
		[Address(RVA = "0x1D1BFF4", Offset = "0x1D1BFF4", VA = "0x7BBC51BFF4")]
		private void OnMic()
		{
		}

		// Token: 0x06008658 RID: 34392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008658")]
		[Address(RVA = "0x1D1C174", Offset = "0x1D1C174", VA = "0x7BBC51C174")]
		private void OnSpeaker()
		{
		}

		// Token: 0x06008659 RID: 34393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008659")]
		[Address(RVA = "0x1D19C70", Offset = "0x1D19C70", VA = "0x7BBC519C70")]
		private void RefreshVoteButtonState()
		{
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600865A")]
		[Address(RVA = "0x1D1C244", Offset = "0x1D1C244", VA = "0x7BBC51C244")]
		private void OnVoiceChange(params object[] data)
		{
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600865B")]
		[Address(RVA = "0x1D157EC", Offset = "0x1D157EC", VA = "0x7BBC5157EC")]
		public void RefreshButtonState()
		{
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x000245E8 File Offset: 0x000227E8
		[Token(Token = "0x600865C")]
		[Address(RVA = "0x1D1C248", Offset = "0x1D1C248", VA = "0x7BBC51C248")]
		private int Cmp(zCUI\u0081}O infoA, zCUI\u0081}O infoB)
		{
			return 0;
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600865D")]
		[Address(RVA = "0x1D1C2AC", Offset = "0x1D1C2AC", VA = "0x7BBC51C2AC", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600865E")]
		[Address(RVA = "0x1D1C368", Offset = "0x1D1C368", VA = "0x7BBC51C368", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600865F")]
		[Address(RVA = "0x1D1C398", Offset = "0x1D1C398", VA = "0x7BBC51C398")]
		public UIEasyListItemController GetChildController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008660")]
		[Address(RVA = "0x1D15A10", Offset = "0x1D15A10", VA = "0x7BBC515A10")]
		public void HideSpeakerNode()
		{
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008661")]
		[Address(RVA = "0x1D1C42C", Offset = "0x1D1C42C", VA = "0x7BBC51C42C")]
		public UIHudWereWolvesVoteController()
		{
		}

		// Token: 0x04009576 RID: 38262
		[Token(Token = "0x4009576")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesVoteView m_View;

		// Token: 0x04009577 RID: 38263
		[Token(Token = "0x4009577")]
		[FieldOffset(Offset = "0x60")]
		private List<zCUI\u0081}O> m_VoteList;

		// Token: 0x04009578 RID: 38264
		[Token(Token = "0x4009578")]
		[FieldOffset(Offset = "0x68")]
		private List<{QAb\u0082~u> m_SkippedList;

		// Token: 0x04009579 RID: 38265
		[Token(Token = "0x4009579")]
		[FieldOffset(Offset = "0x70")]
		private List<UIHudWereWolvesVoteIndexController> m_SkippedChildController;

		// Token: 0x0400957A RID: 38266
		[Token(Token = "0x400957A")]
		[FieldOffset(Offset = "0x78")]
		private UITimeLabelHelper m_TimeHelper;

		// Token: 0x0400957B RID: 38267
		[Token(Token = "0x400957B")]
		[FieldOffset(Offset = "0x80")]
		private float m_CountDownTime;

		// Token: 0x0400957C RID: 38268
		[Token(Token = "0x400957C")]
		[FieldOffset(Offset = "0x88")]
		private UIHudWereWolvesVoteIndexController m_SponsorIndex;

		// Token: 0x0400957D RID: 38269
		[Token(Token = "0x400957D")]
		[FieldOffset(Offset = "0x90")]
		private WereWolvesChatEasyListCallBack m_ChatEasyListCallback;

		// Token: 0x0400957E RID: 38270
		[Token(Token = "0x400957E")]
		[FieldOffset(Offset = "0x98")]
		private UIHudWereWolvesQuickChatScrollController m_QuickChatNode;

		// Token: 0x0400957F RID: 38271
		[Token(Token = "0x400957F")]
		[FieldOffset(Offset = "0xA0")]
		private UIHudWereWolvesSpeakerController m_SpeakerController;

		// Token: 0x04009580 RID: 38272
		[Token(Token = "0x4009580")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_LastQuickPlayerId;

		// Token: 0x04009581 RID: 38273
		[Token(Token = "0x4009581")]
		[FieldOffset(Offset = "0xAC")]
		private float lastLeftTimeS;
	}
}
