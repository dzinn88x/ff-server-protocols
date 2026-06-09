using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018E5 RID: 6373
	[Token(Token = "0x20018E5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F519C", Offset = "0x10F519C")]
	internal class UIHudInGameShopItemController : UIBaseController
	{
		// Token: 0x06007F57 RID: 32599 RVA: 0x00022C38 File Offset: 0x00020E38
		[Token(Token = "0x6007F57")]
		[Address(RVA = "0x198A4DC", Offset = "0x198A4DC", VA = "0x7BBC18A4DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F58")]
		[Address(RVA = "0x198A52C", Offset = "0x198A52C", VA = "0x7BBC18A52C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F59")]
		[Address(RVA = "0x198AA1C", Offset = "0x198AA1C", VA = "0x7BBC18AA1C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x00022C50 File Offset: 0x00020E50
		[Token(Token = "0x6007F5A")]
		[Address(RVA = "0x1987E9C", Offset = "0x1987E9C", VA = "0x7BBC187E9C")]
		public int GetSortOrder()
		{
			return 0;
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F5B")]
		[Address(RVA = "0x198AC8C", Offset = "0x198AC8C", VA = "0x7BBC18AC8C")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F5C")]
		[Address(RVA = "0x1987AFC", Offset = "0x1987AFC", VA = "0x7BBC187AFC")]
		public void SetUIData(oOu}}D^ data)
		{
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F5D")]
		[Address(RVA = "0x198B614", Offset = "0x198B614", VA = "0x7BBC18B614")]
		private void OnClearSelectedItem(params object[] data)
		{
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F5E")]
		[Address(RVA = "0x198B628", Offset = "0x198B628", VA = "0x7BBC18B628")]
		private void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F5F")]
		[Address(RVA = "0x198ADAC", Offset = "0x198ADAC", VA = "0x7BBC18ADAC")]
		private void SetSelected(bool v)
		{
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F60")]
		[Address(RVA = "0x198B750", Offset = "0x198B750", VA = "0x7BBC18B750")]
		private void OnTokenChanged(params object[] data)
		{
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F61")]
		[Address(RVA = "0x198B904", Offset = "0x198B904", VA = "0x7BBC18B904")]
		private void OnBagCapacityLeftChanged(params object[] data)
		{
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F62")]
		[Address(RVA = "0x198B9E8", Offset = "0x198B9E8", VA = "0x7BBC18B9E8")]
		private void OnAvailableNumChanged(params object[] data)
		{
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F63")]
		[Address(RVA = "0x198BB24", Offset = "0x198BB24", VA = "0x7BBC18BB24")]
		private void OnShopHudInited(params object[] data)
		{
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F64")]
		[Address(RVA = "0x198B4F4", Offset = "0x198B4F4", VA = "0x7BBC18B4F4")]
		private void UpdateLimitationLabel(int available)
		{
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F65")]
		[Address(RVA = "0x198BCC4", Offset = "0x198BCC4", VA = "0x7BBC18BCC4")]
		public UIHudInGameShopItemController()
		{
		}

		// Token: 0x0400923E RID: 37438
		[Token(Token = "0x400923E")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInGameShopItemViewExt m_View;

		// Token: 0x0400923F RID: 37439
		[Token(Token = "0x400923F")]
		[FieldOffset(Offset = "0x60")]
		private oOu}}D^ m_ItemInfo;

		// Token: 0x04009240 RID: 37440
		[Token(Token = "0x4009240")]
		[FieldOffset(Offset = "0x68")]
		private bool m_Selected;
	}
}
