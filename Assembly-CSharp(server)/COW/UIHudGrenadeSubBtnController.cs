using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018D9 RID: 6361
	[Token(Token = "0x20018D9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4FD4", Offset = "0x10F4FD4")]
	internal class UIHudGrenadeSubBtnController : UIBaseController
	{
		// Token: 0x06007ED8 RID: 32472 RVA: 0x00022AB8 File Offset: 0x00020CB8
		[Token(Token = "0x6007ED8")]
		[Address(RVA = "0x197D270", Offset = "0x197D270", VA = "0x7BBC17D270")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007ED9 RID: 32473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED9")]
		[Address(RVA = "0x197D2C0", Offset = "0x197D2C0", VA = "0x7BBC17D2C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007EDA RID: 32474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EDA")]
		[Address(RVA = "0x197D3A4", Offset = "0x197D3A4", VA = "0x7BBC17D3A4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EDB")]
		[Address(RVA = "0x197D3AC", Offset = "0x197D3AC", VA = "0x7BBC17D3AC")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EDC")]
		[Address(RVA = "0x1977968", Offset = "0x1977968", VA = "0x7BBC177968")]
		public void SetData(UIHudGrenadeBtnController.ButtonType curType, int count, int itemType)
		{
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EDD")]
		[Address(RVA = "0x197D544", Offset = "0x197D544", VA = "0x7BBC17D544")]
		public UIHudGrenadeSubBtnController()
		{
		}

		// Token: 0x04009208 RID: 37384
		[Token(Token = "0x4009208")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGrenadeSubBtnView m_View;

		// Token: 0x04009209 RID: 37385
		[Token(Token = "0x4009209")]
		[FieldOffset(Offset = "0x60")]
		private UIHudGrenadeBtnController.ButtonType m_BtnType;
	}
}
