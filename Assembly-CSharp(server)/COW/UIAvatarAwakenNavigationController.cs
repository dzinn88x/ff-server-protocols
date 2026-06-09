using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001431 RID: 5169
	[Token(Token = "0x2001431")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC9A0", Offset = "0x10EC9A0")]
	public class UIAvatarAwakenNavigationController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x060055AA RID: 21930 RVA: 0x00019818 File Offset: 0x00017A18
		[Token(Token = "0x60055AA")]
		[Address(RVA = "0x1B1DF00", Offset = "0x1B1DF00", VA = "0x7BBC31DF00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AB")]
		[Address(RVA = "0x1B1DF50", Offset = "0x1B1DF50", VA = "0x7BBC31DF50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AC")]
		[Address(RVA = "0x1B1E280", Offset = "0x1B1E280", VA = "0x7BBC31E280")]
		private void OnClickLeftArea()
		{
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AD")]
		[Address(RVA = "0x1B1E7FC", Offset = "0x1B1E7FC", VA = "0x7BBC31E7FC")]
		private void OnClickRightArea()
		{
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x1B1E808", Offset = "0x1B1E808", VA = "0x7BBC31E808", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AF")]
		[Address(RVA = "0x1B1E9C0", Offset = "0x1B1E9C0", VA = "0x7BBC31E9C0")]
		public void SetAvatar(uint curAvatarID)
		{
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B0")]
		[Address(RVA = "0x1B1EA0C", Offset = "0x1B1EA0C", VA = "0x7BBC31EA0C")]
		private void ShowAvatarInfo()
		{
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B1")]
		[Address(RVA = "0x1B1EE5C", Offset = "0x1B1EE5C", VA = "0x7BBC31EE5C")]
		private void ShowCurrentUI()
		{
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B2")]
		[Address(RVA = "0x1B1F1A4", Offset = "0x1B1F1A4", VA = "0x7BBC31F1A4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x1B1F1AC", Offset = "0x1B1F1AC", VA = "0x7BBC31F1AC", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B4")]
		[Address(RVA = "0x1B1F340", Offset = "0x1B1F340", VA = "0x7BBC31F340")]
		private void OnShowAvatarAwakenStory(params object[] data)
		{
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B5")]
		[Address(RVA = "0x1B1F3D8", Offset = "0x1B1F3D8", VA = "0x7BBC31F3D8")]
		private void OnRefreshAwakenUI(params object[] data)
		{
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B6")]
		[Address(RVA = "0x1B1F3DC", Offset = "0x1B1F3DC", VA = "0x7BBC31F3DC")]
		private void OnExchangeActivityBtnClick(params object[] data)
		{
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x00019830 File Offset: 0x00017A30
		[Token(Token = "0x60055B7")]
		[Address(RVA = "0x1B1F4E0", Offset = "0x1B1F4E0", VA = "0x7BBC31F4E0", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B8")]
		[Address(RVA = "0x1B1E28C", Offset = "0x1B1E28C", VA = "0x7BBC31E28C")]
		private void ShowAvatarAwakenStory(uint storyId)
		{
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B9")]
		[Address(RVA = "0x1B1F4E8", Offset = "0x1B1F4E8", VA = "0x7BBC31F4E8")]
		private void OnCDNBtnCloseClick()
		{
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00019848 File Offset: 0x00017A48
		[Token(Token = "0x60055BA")]
		[Address(RVA = "0x1B1F544", Offset = "0x1B1F544", VA = "0x7BBC31F544", Slot = "40")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055BB")]
		[Address(RVA = "0x1B1F588", Offset = "0x1B1F588", VA = "0x7BBC31F588", Slot = "39")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055BC")]
		[Address(RVA = "0x1B1F600", Offset = "0x1B1F600", VA = "0x7BBC31F600")]
		public UIAvatarAwakenNavigationController()
		{
		}

		// Token: 0x04007A70 RID: 31344
		[Token(Token = "0x4007A70")]
		[FieldOffset(Offset = "0xB0")]
		private UIAvatarAwakenNavigationView m_View;

		// Token: 0x04007A71 RID: 31345
		[Token(Token = "0x4007A71")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x04007A72 RID: 31346
		[Token(Token = "0x4007A72")]
		[FieldOffset(Offset = "0xC0")]
		private AvatarProfile m_CurrentShowAvatar;

		// Token: 0x04007A73 RID: 31347
		[Token(Token = "0x4007A73")]
		[FieldOffset(Offset = "0xC8")]
		private UIAvatarAwakenController m_AwakenCtrl;

		// Token: 0x04007A74 RID: 31348
		[Token(Token = "0x4007A74")]
		[FieldOffset(Offset = "0xD0")]
		private UIAvatarAwakenStoryReplayController m_AvakenStoryCtrl;

		// Token: 0x04007A75 RID: 31349
		[Token(Token = "0x4007A75")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_CurrentShowStoryID;
	}
}
