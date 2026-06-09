using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017FA RID: 6138
	[Token(Token = "0x20017FA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F32FC", Offset = "0x10F32FC")]
	public class UIGachaLegendExtraPreviewWndController : UIPopupWindowController
	{
		// Token: 0x06007738 RID: 30520 RVA: 0x00020F58 File Offset: 0x0001F158
		[Token(Token = "0x6007738")]
		[Address(RVA = "0x205652C", Offset = "0x205652C", VA = "0x7BBC85652C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007739")]
		[Address(RVA = "0x205657C", Offset = "0x205657C", VA = "0x7BBC85657C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773A")]
		[Address(RVA = "0x2056660", Offset = "0x2056660", VA = "0x7BBC856660")]
		public void SetViewData(ExtraRewardDesc desc, UIGachaLengendaryExtraListItemController.ExtraAwardItemState m_State)
		{
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773B")]
		[Address(RVA = "0x2056DA4", Offset = "0x2056DA4", VA = "0x7BBC856DA4")]
		private void OnOKClick()
		{
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773C")]
		[Address(RVA = "0x2056DAC", Offset = "0x2056DAC", VA = "0x7BBC856DAC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773D")]
		[Address(RVA = "0x2056DB4", Offset = "0x2056DB4", VA = "0x7BBC856DB4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773E")]
		[Address(RVA = "0x2056DBC", Offset = "0x2056DBC", VA = "0x7BBC856DBC")]
		public UIGachaLegendExtraPreviewWndController()
		{
		}

		// Token: 0x04008DAD RID: 36269
		[Token(Token = "0x4008DAD")]
		[FieldOffset(Offset = "0x98")]
		private UIGachaLegendExtraPreviewWndView m_View;
	}
}
