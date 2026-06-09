using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200169B RID: 5787
	[Token(Token = "0x200169B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F06BC", Offset = "0x10F06BC")]
	public class UIAccountPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06006943 RID: 26947 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		[Token(Token = "0x6006943")]
		[Address(RVA = "0x1A3B558", Offset = "0x1A3B558", VA = "0x7BBC23B558")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006944")]
		[Address(RVA = "0x1A3B5A8", Offset = "0x1A3B5A8", VA = "0x7BBC23B5A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006945")]
		[Address(RVA = "0x1A3C3AC", Offset = "0x1A3C3AC", VA = "0x7BBC23C3AC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006946")]
		[Address(RVA = "0x1A3C460", Offset = "0x1A3C460", VA = "0x7BBC23C460")]
		private void OnLeftButtonClick()
		{
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006947")]
		[Address(RVA = "0x1A3C464", Offset = "0x1A3C464", VA = "0x7BBC23C464")]
		private void OnRightButtonClick()
		{
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006948")]
		[Address(RVA = "0x1A3B83C", Offset = "0x1A3B83C", VA = "0x7BBC23B83C")]
		private void ToggleState(UIAccountPopupWindowController.State state)
		{
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006949")]
		[Address(RVA = "0x1A3C13C", Offset = "0x1A3C13C", VA = "0x7BBC23C13C")]
		public void RefreshRegionLabel()
		{
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x0001DCB8 File Offset: 0x0001BEB8
		[Token(Token = "0x600694A")]
		[Address(RVA = "0x1A3C468", Offset = "0x1A3C468", VA = "0x7BBC23C468", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600694B")]
		[Address(RVA = "0x1A3C4AC", Offset = "0x1A3C4AC", VA = "0x7BBC23C4AC", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600694C")]
		[Address(RVA = "0x1A3C4E0", Offset = "0x1A3C4E0", VA = "0x7BBC23C4E0")]
		public UIAccountPopupWindowController()
		{
		}

		// Token: 0x04008642 RID: 34370
		[Token(Token = "0x4008642")]
		[FieldOffset(Offset = "0x98")]
		private UIAccountPopupWindowView m_View;

		// Token: 0x04008643 RID: 34371
		[Token(Token = "0x4008643")]
		[FieldOffset(Offset = "0xA0")]
		private UIAccountPopupWindowController.State _State;

		// Token: 0x04008644 RID: 34372
		[Token(Token = "0x4008644")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_SavePassward;

		// Token: 0x0200169C RID: 5788
		[Token(Token = "0x200169C")]
		private enum State
		{
			// Token: 0x04008646 RID: 34374
			[Token(Token = "0x4008646")]
			Register,
			// Token: 0x04008647 RID: 34375
			[Token(Token = "0x4008647")]
			Login
		}
	}
}
