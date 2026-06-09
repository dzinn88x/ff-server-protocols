using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001389 RID: 5001
	[Token(Token = "0x2001389")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB7C0", Offset = "0x10EB7C0")]
	public class UIGoliathRecruitWndController : UIPopupWindowController
	{
		// Token: 0x06005093 RID: 20627 RVA: 0x00018738 File Offset: 0x00016938
		[Token(Token = "0x6005093")]
		[Address(RVA = "0x1A80F68", Offset = "0x1A80F68", VA = "0x7BBC280F68")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005094")]
		[Address(RVA = "0x1A80FB8", Offset = "0x1A80FB8", VA = "0x7BBC280FB8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005095")]
		[Address(RVA = "0x1A81D00", Offset = "0x1A81D00", VA = "0x7BBC281D00", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005096")]
		[Address(RVA = "0x1A81298", Offset = "0x1A81298", VA = "0x7BBC281298")]
		private void DefaultWorldState()
		{
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005097")]
		[Address(RVA = "0x1A81494", Offset = "0x1A81494", VA = "0x7BBC281494")]
		private void DefaultClanState()
		{
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005098")]
		[Address(RVA = "0x1A72F78", Offset = "0x1A72F78", VA = "0x7BBC272F78")]
		public void SetInfo(ulong groupID, string captainName, uint memberCnt)
		{
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005099")]
		[Address(RVA = "0x1A8163C", Offset = "0x1A8163C", VA = "0x7BBC28163C")]
		private void UpdateView()
		{
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509A")]
		[Address(RVA = "0x1A81DA8", Offset = "0x1A81DA8", VA = "0x7BBC281DA8")]
		private void OnSendClick()
		{
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509B")]
		[Address(RVA = "0x1A824D0", Offset = "0x1A824D0", VA = "0x7BBC2824D0")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509C")]
		[Address(RVA = "0x1A819C0", Offset = "0x1A819C0", VA = "0x7BBC2819C0")]
		private void OnChannelToggleChange()
		{
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x00018750 File Offset: 0x00016950
		[Token(Token = "0x600509D")]
		[Address(RVA = "0x1A8244C", Offset = "0x1A8244C", VA = "0x7BBC28244C")]
		private bool CheckSendToValid()
		{
			return default(bool);
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509E")]
		[Address(RVA = "0x1A824D8", Offset = "0x1A824D8", VA = "0x7BBC2824D8")]
		public UIGoliathRecruitWndController()
		{
		}

		// Token: 0x04007708 RID: 30472
		[Token(Token = "0x4007708")]
		[FieldOffset(Offset = "0x98")]
		private UIGoliathRecruitWndView m_View;

		// Token: 0x04007709 RID: 30473
		[Token(Token = "0x4007709")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChat m_ChatModel;

		// Token: 0x0400770A RID: 30474
		[Token(Token = "0x400770A")]
		[FieldOffset(Offset = "0xA8")]
		private StringBuilder m_Builder;

		// Token: 0x0400770B RID: 30475
		[Token(Token = "0x400770B")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_LastInCDState;

		// Token: 0x0400770C RID: 30476
		[Token(Token = "0x400770C")]
		[FieldOffset(Offset = "0xB4")]
		private uint m_WorldDelayCallID;

		// Token: 0x0400770D RID: 30477
		[Token(Token = "0x400770D")]
		[FieldOffset(Offset = "0xB8")]
		private readonly float GREY_ALPHA;

		// Token: 0x0400770E RID: 30478
		[Token(Token = "0x400770E")]
		private const uint LABEL_COLOR_SEND_DISABLED = 3048518911U;

		// Token: 0x0400770F RID: 30479
		[Token(Token = "0x400770F")]
		private const uint LABEL_COLOR_SEND_ENABLED = 4294967295U;

		// Token: 0x04007710 RID: 30480
		[Token(Token = "0x4007710")]
		[FieldOffset(Offset = "0xC0")]
		private readonly string SEND_BTN_SPRITE_ENABLED;

		// Token: 0x04007711 RID: 30481
		[Token(Token = "0x4007711")]
		[FieldOffset(Offset = "0xC8")]
		private readonly string SEND_BTN_SPRITE_DISABLED;

		// Token: 0x04007712 RID: 30482
		[Token(Token = "0x4007712")]
		[FieldOffset(Offset = "0xD0")]
		private ulong m_GroupID;

		// Token: 0x04007713 RID: 30483
		[Token(Token = "0x4007713")]
		[FieldOffset(Offset = "0xD8")]
		private string m_CaptainNickname;

		// Token: 0x04007714 RID: 30484
		[Token(Token = "0x4007714")]
		[FieldOffset(Offset = "0xE0")]
		private uint m_MemberCnt;
	}
}
