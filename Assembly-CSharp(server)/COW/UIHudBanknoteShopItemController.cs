using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001877 RID: 6263
	[Token(Token = "0x2001877")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F429C", Offset = "0x10F429C")]
	internal class UIHudBanknoteShopItemController : UIBaseController
	{
		// Token: 0x06007BC3 RID: 31683 RVA: 0x00022038 File Offset: 0x00020238
		[Token(Token = "0x6007BC3")]
		[Address(RVA = "0x1891888", Offset = "0x1891888", VA = "0x7BBC091888")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC4")]
		[Address(RVA = "0x18918D8", Offset = "0x18918D8", VA = "0x7BBC0918D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC5")]
		[Address(RVA = "0x18919D8", Offset = "0x18919D8", VA = "0x7BBC0919D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC6")]
		[Address(RVA = "0x18919E0", Offset = "0x18919E0", VA = "0x7BBC0919E0")]
		public void SetUIData(uint itemID, int index, Action<int> callBack)
		{
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC7")]
		[Address(RVA = "0x1891AE8", Offset = "0x1891AE8", VA = "0x7BBC091AE8")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC8")]
		[Address(RVA = "0x1891B74", Offset = "0x1891B74", VA = "0x7BBC091B74")]
		public void SetSelected(bool v)
		{
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC9")]
		[Address(RVA = "0x1891C00", Offset = "0x1891C00", VA = "0x7BBC091C00")]
		public void UpdateUnLockState(bool isUnLock)
		{
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCA")]
		[Address(RVA = "0x1891CF4", Offset = "0x1891CF4", VA = "0x7BBC091CF4")]
		public UIHudBanknoteShopItemController()
		{
		}

		// Token: 0x0400901B RID: 36891
		[Token(Token = "0x400901B")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInGameShopItemViewExt m_View;

		// Token: 0x0400901C RID: 36892
		[Token(Token = "0x400901C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_Selected;

		// Token: 0x0400901D RID: 36893
		[Token(Token = "0x400901D")]
		[FieldOffset(Offset = "0x64")]
		public int m_Index;

		// Token: 0x0400901E RID: 36894
		[Token(Token = "0x400901E")]
		[FieldOffset(Offset = "0x68")]
		private Action<int> m_CallBack;
	}
}
