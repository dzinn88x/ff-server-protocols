using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B57 RID: 6999
	[Token(Token = "0x2001B57")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9CAC", Offset = "0x10F9CAC")]
	public class UIRewardedVideoPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06009673 RID: 38515 RVA: 0x00027C30 File Offset: 0x00025E30
		[Token(Token = "0x6009673")]
		[Address(RVA = "0x1E20E68", Offset = "0x1E20E68", VA = "0x7BBC620E68")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06009674 RID: 38516 RVA: 0x00027C48 File Offset: 0x00025E48
		// (set) Token: 0x06009675 RID: 38517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A44")]
		private UIRewardedVideoPopupWindowController.UIState State
		{
			[Token(Token = "0x6009674")]
			[Address(RVA = "0x1E20EB8", Offset = "0x1E20EB8", VA = "0x7BBC620EB8")]
			get
			{
				return UIRewardedVideoPopupWindowController.UIState.None;
			}
			[Token(Token = "0x6009675")]
			[Address(RVA = "0x1E20EC0", Offset = "0x1E20EC0", VA = "0x7BBC620EC0")]
			set
			{
			}
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009676")]
		[Address(RVA = "0x1E21214", Offset = "0x1E21214", VA = "0x7BBC621214", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009677 RID: 38519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009677")]
		[Address(RVA = "0x1E213DC", Offset = "0x1E213DC", VA = "0x7BBC6213DC")]
		public void SetData(EActivity.Event evt, string desc)
		{
		}

		// Token: 0x06009678 RID: 38520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009678")]
		[Address(RVA = "0x1E214EC", Offset = "0x1E214EC", VA = "0x7BBC6214EC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009679 RID: 38521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009679")]
		[Address(RVA = "0x1E21590", Offset = "0x1E21590", VA = "0x7BBC621590", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600967A RID: 38522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600967A")]
		[Address(RVA = "0x1E215E8", Offset = "0x1E215E8", VA = "0x7BBC6215E8")]
		private void OnBtnLoadAndPlayClick()
		{
		}

		// Token: 0x0600967B RID: 38523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600967B")]
		[Address(RVA = "0x1E215F8", Offset = "0x1E215F8", VA = "0x7BBC6215F8")]
		private void LoadRewardedVideo()
		{
		}

		// Token: 0x0600967C RID: 38524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600967C")]
		[Address(RVA = "0x1E216A0", Offset = "0x1E216A0", VA = "0x7BBC6216A0")]
		private void PlayRewardedVideo()
		{
		}

		// Token: 0x0600967D RID: 38525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600967D")]
		[Address(RVA = "0x1E20FA4", Offset = "0x1E20FA4", VA = "0x7BBC620FA4")]
		private void UpdateUIStatus()
		{
		}

		// Token: 0x0600967E RID: 38526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600967E")]
		[Address(RVA = "0x1E21734", Offset = "0x1E21734", VA = "0x7BBC621734")]
		private void ToggleBtnLoadAndPlay(bool enabled)
		{
		}

		// Token: 0x0600967F RID: 38527 RVA: 0x00027C60 File Offset: 0x00025E60
		[Token(Token = "0x600967F")]
		[Address(RVA = "0x1E21808", Offset = "0x1E21808", VA = "0x7BBC621808", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009680")]
		[Address(RVA = "0x1E2186C", Offset = "0x1E2186C", VA = "0x7BBC62186C", Slot = "38")]
		public override void EnterByReturn()
		{
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009681")]
		[Address(RVA = "0x1E21904", Offset = "0x1E21904", VA = "0x7BBC621904", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009682")]
		[Address(RVA = "0x1E21AB4", Offset = "0x1E21AB4", VA = "0x7BBC621AB4")]
		public UIRewardedVideoPopupWindowController()
		{
		}

		// Token: 0x04009F0C RID: 40716
		[Token(Token = "0x4009F0C")]
		[FieldOffset(Offset = "0x98")]
		private UIRewardedVideoPopupWindowView m_View;

		// Token: 0x04009F0D RID: 40717
		[Token(Token = "0x4009F0D")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelRewardedVideo m_RewardedVideoModel;

		// Token: 0x04009F0E RID: 40718
		[Token(Token = "0x4009F0E")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelActivity m_ActivityModel;

		// Token: 0x04009F0F RID: 40719
		[Token(Token = "0x4009F0F")]
		[FieldOffset(Offset = "0xB0")]
		private EActivity.Event m_EventOnTrigger;

		// Token: 0x04009F10 RID: 40720
		[Token(Token = "0x4009F10")]
		[FieldOffset(Offset = "0xB4")]
		private UIRewardedVideoPopupWindowController.UIState _State;

		// Token: 0x02001B58 RID: 7000
		[Token(Token = "0x2001B58")]
		private enum UIState
		{
			// Token: 0x04009F12 RID: 40722
			[Token(Token = "0x4009F12")]
			None,
			// Token: 0x04009F13 RID: 40723
			[Token(Token = "0x4009F13")]
			Loading,
			// Token: 0x04009F14 RID: 40724
			[Token(Token = "0x4009F14")]
			Playing
		}
	}
}
