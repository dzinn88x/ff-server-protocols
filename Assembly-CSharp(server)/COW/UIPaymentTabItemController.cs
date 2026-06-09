using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001ADD RID: 6877
	[Token(Token = "0x2001ADD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8CC4", Offset = "0x10F8CC4")]
	public class UIPaymentTabItemController : UIBaseController, ITipsDelegate
	{
		// Token: 0x060091B6 RID: 37302 RVA: 0x00026CB8 File Offset: 0x00024EB8
		[Token(Token = "0x60091B6")]
		[Address(RVA = "0x1F36FBC", Offset = "0x1F36FBC", VA = "0x7BBC736FBC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B7")]
		[Address(RVA = "0x1F3700C", Offset = "0x1F3700C", VA = "0x7BBC73700C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060091B8 RID: 37304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B8")]
		[Address(RVA = "0x1F3718C", Offset = "0x1F3718C", VA = "0x7BBC73718C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060091B9 RID: 37305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B9")]
		[Address(RVA = "0x1F372D4", Offset = "0x1F372D4", VA = "0x7BBC7372D4")]
		public void SetData(UIPaymentController.Tab tab, UIPaymentController.TabInfo info)
		{
		}

		// Token: 0x060091BA RID: 37306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091BA")]
		[Address(RVA = "0x1F376DC", Offset = "0x1F376DC", VA = "0x7BBC7376DC")]
		private void UpdateBg(UIPaymentController.Tab tab)
		{
		}

		// Token: 0x060091BB RID: 37307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091BB")]
		[Address(RVA = "0x1F37144", Offset = "0x1F37144", VA = "0x7BBC737144")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091BC")]
		[Address(RVA = "0x1F37678", Offset = "0x1F37678", VA = "0x7BBC737678")]
		private void SetRedDot(ETipsType type, int num)
		{
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091BD")]
		[Address(RVA = "0x1F377A8", Offset = "0x1F377A8", VA = "0x7BBC7377A8")]
		private void OnButtonClick()
		{
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091BE")]
		[Address(RVA = "0x1F37BCC", Offset = "0x1F37BCC", VA = "0x7BBC737BCC", Slot = "28")]
		private void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x060091BF RID: 37311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091BF")]
		[Address(RVA = "0x1F37BD0", Offset = "0x1F37BD0", VA = "0x7BBC737BD0")]
		public UIPaymentTabItemController()
		{
		}

		// Token: 0x04009C98 RID: 40088
		[Token(Token = "0x4009C98")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentTabItemView m_View;

		// Token: 0x04009C99 RID: 40089
		[Token(Token = "0x4009C99")]
		[FieldOffset(Offset = "0x60")]
		private UIPaymentController.Tab m_Tab;

		// Token: 0x04009C9A RID: 40090
		[Token(Token = "0x4009C9A")]
		[FieldOffset(Offset = "0x68")]
		private UIPaymentController.TabInfo m_TabInfo;
	}
}
