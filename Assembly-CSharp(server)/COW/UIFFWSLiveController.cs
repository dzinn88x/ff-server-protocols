using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200135E RID: 4958
	[Token(Token = "0x200135E")]
	internal class UIFFWSLiveController : UINaviPopController, IUIModelDataChangeObserver
	{
		// Token: 0x06004EF9 RID: 20217 RVA: 0x00018150 File Offset: 0x00016350
		[Token(Token = "0x6004EF9")]
		[Address(RVA = "0x227C600", Offset = "0x227C600", VA = "0x7BBCA7C600")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x00018168 File Offset: 0x00016368
		[Token(Token = "0x6004EFA")]
		[Address(RVA = "0x227C650", Offset = "0x227C650", VA = "0x7BBCA7C650", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFB")]
		[Address(RVA = "0x227C658", Offset = "0x227C658", VA = "0x7BBCA7C658", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFC")]
		[Address(RVA = "0x227C978", Offset = "0x227C978", VA = "0x7BBCA7C978", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFD")]
		[Address(RVA = "0x227C9B8", Offset = "0x227C9B8", VA = "0x7BBCA7C9B8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x227CB08", Offset = "0x227CB08", VA = "0x7BBCA7CB08", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFF")]
		[Address(RVA = "0x227CDD4", Offset = "0x227CDD4", VA = "0x7BBCA7CDD4", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x00018180 File Offset: 0x00016380
		[Token(Token = "0x6004F00")]
		[Address(RVA = "0x227CE04", Offset = "0x227CE04", VA = "0x7BBCA7CE04", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F01")]
		[Address(RVA = "0x227CE0C", Offset = "0x227CE0C", VA = "0x7BBCA7CE0C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x00018198 File Offset: 0x00016398
		[Token(Token = "0x6004F02")]
		[Address(RVA = "0x227CE84", Offset = "0x227CE84", VA = "0x7BBCA7CE84", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F03")]
		[Address(RVA = "0x227C948", Offset = "0x227C948", VA = "0x7BBCA7C948")]
		private void RefreshView()
		{
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F04")]
		[Address(RVA = "0x227CEC8", Offset = "0x227CEC8", VA = "0x7BBCA7CEC8")]
		private void RefreshBtnGoToGuess()
		{
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F05")]
		[Address(RVA = "0x227CF48", Offset = "0x227CF48", VA = "0x7BBCA7CF48")]
		private void RefreshBtnGoToWeb()
		{
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F06")]
		[Address(RVA = "0x227D1A8", Offset = "0x227D1A8", VA = "0x7BBCA7D1A8")]
		private void RefreshCountDown()
		{
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F07")]
		[Address(RVA = "0x227CB34", Offset = "0x227CB34", VA = "0x7BBCA7CB34")]
		private void SetLiveViewShow(bool show)
		{
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F08")]
		[Address(RVA = "0x227D4A8", Offset = "0x227D4A8", VA = "0x7BBCA7D4A8")]
		private void OnClickRule()
		{
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F09")]
		[Address(RVA = "0x227D664", Offset = "0x227D664", VA = "0x7BBCA7D664")]
		private void OnClickGoToGuess()
		{
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0A")]
		[Address(RVA = "0x227D9D0", Offset = "0x227D9D0", VA = "0x7BBCA7D9D0")]
		private void OnClickGoToWeb()
		{
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0B")]
		[Address(RVA = "0x227DB08", Offset = "0x227DB08", VA = "0x7BBCA7DB08")]
		public UIFFWSLiveController()
		{
		}

		// Token: 0x04007604 RID: 30212
		[Token(Token = "0x4007604")]
		[FieldOffset(Offset = "0xB8")]
		private UIFFWSLiveView m_View;

		// Token: 0x04007605 RID: 30213
		[Token(Token = "0x4007605")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x04007606 RID: 30214
		[Token(Token = "0x4007606")]
		[FieldOffset(Offset = "0xC8")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x04007607 RID: 30215
		[Token(Token = "0x4007607")]
		private const int m_CountDownFontSize = 25;

		// Token: 0x04007608 RID: 30216
		[Token(Token = "0x4007608")]
		[FieldOffset(Offset = "0xD0")]
		private UIFFWSLiveTvPopWndController m_TvPopWnd;
	}
}
