using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001681 RID: 5761
	[Token(Token = "0x2001681")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F040C", Offset = "0x10F040C")]
	public class UIHudChatBtnController : UIBaseController
	{
		// Token: 0x06006899 RID: 26777 RVA: 0x0001DA90 File Offset: 0x0001BC90
		[Token(Token = "0x6006899")]
		[Address(RVA = "0x1A8FE40", Offset = "0x1A8FE40", VA = "0x7BBC28FE40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689A")]
		[Address(RVA = "0x1A8FE90", Offset = "0x1A8FE90", VA = "0x7BBC28FE90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689B")]
		[Address(RVA = "0x1A90204", Offset = "0x1A90204", VA = "0x7BBC290204", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689C")]
		[Address(RVA = "0x1A90434", Offset = "0x1A90434", VA = "0x7BBC290434", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600689D")]
		[Address(RVA = "0x1A904FC", Offset = "0x1A904FC", VA = "0x7BBC2904FC")]
		public UIWidget GetMaskContainer()
		{
			return null;
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689E")]
		[Address(RVA = "0x1A90528", Offset = "0x1A90528", VA = "0x7BBC290528")]
		private void OnMessageVisibleChange(object[] data)
		{
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689F")]
		[Address(RVA = "0x1A905FC", Offset = "0x1A905FC", VA = "0x7BBC2905FC")]
		private void OnNewMessageReceived(object[] data)
		{
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A0")]
		[Address(RVA = "0x1A90708", Offset = "0x1A90708", VA = "0x7BBC290708")]
		private void ShowTutorialQuickChat(object[] data)
		{
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A1")]
		[Address(RVA = "0x1A907A8", Offset = "0x1A907A8", VA = "0x7BBC2907A8")]
		private void OnQuickChatStartCD(object[] data)
		{
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A2")]
		[Address(RVA = "0x1A90964", Offset = "0x1A90964", VA = "0x7BBC290964")]
		private void UpdateCDTime()
		{
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A3")]
		[Address(RVA = "0x1A908CC", Offset = "0x1A908CC", VA = "0x7BBC2908CC")]
		private void EnableChatBtn(bool enable)
		{
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A4")]
		[Address(RVA = "0x1A90AE4", Offset = "0x1A90AE4", VA = "0x7BBC290AE4")]
		private void OnChatClick()
		{
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A5")]
		[Address(RVA = "0x1A90BB4", Offset = "0x1A90BB4", VA = "0x7BBC290BB4")]
		public UIHudChatBtnController()
		{
		}

		// Token: 0x04008551 RID: 34129
		[Token(Token = "0x4008551")]
		[FieldOffset(Offset = "0x58")]
		private UIHudChatBtnView m_View;

		// Token: 0x04008552 RID: 34130
		[Token(Token = "0x4008552")]
		[FieldOffset(Offset = "0x60")]
		private UIWidget m_Widget;

		// Token: 0x04008553 RID: 34131
		[Token(Token = "0x4008553")]
		[FieldOffset(Offset = "0x68")]
		private uint m_UpdateCDCallID;

		// Token: 0x04008554 RID: 34132
		[Token(Token = "0x4008554")]
		[FieldOffset(Offset = "0x6C")]
		private float m_EndCDTime;
	}
}
