using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A6 RID: 5798
	[Token(Token = "0x20016A6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0844", Offset = "0x10F0844")]
	public class UIAvatarConfirmPopController : UIPopupWindowController
	{
		// Token: 0x060069B2 RID: 27058 RVA: 0x0001DF28 File Offset: 0x0001C128
		[Token(Token = "0x60069B2")]
		[Address(RVA = "0x1B23FFC", Offset = "0x1B23FFC", VA = "0x7BBC323FFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B3")]
		[Address(RVA = "0x1B2404C", Offset = "0x1B2404C", VA = "0x7BBC32404C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B4")]
		[Address(RVA = "0x1B2442C", Offset = "0x1B2442C", VA = "0x7BBC32442C")]
		private void OnBuy()
		{
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B5")]
		[Address(RVA = "0x1B24658", Offset = "0x1B24658", VA = "0x7BBC324658")]
		private void OnLevelUp()
		{
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B6")]
		[Address(RVA = "0x1B24720", Offset = "0x1B24720", VA = "0x7BBC324720", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B7")]
		[Address(RVA = "0x1B247EC", Offset = "0x1B247EC", VA = "0x7BBC3247EC")]
		private void OnUpdateInfo(params object[] data)
		{
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B8")]
		[Address(RVA = "0x1B247F0", Offset = "0x1B247F0", VA = "0x7BBC3247F0")]
		public void RefreshData(uint avatarid, int num1, int num2)
		{
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B9")]
		[Address(RVA = "0x1B248EC", Offset = "0x1B248EC", VA = "0x7BBC3248EC")]
		private void RefreshGemCount()
		{
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BA")]
		[Address(RVA = "0x1B24CB0", Offset = "0x1B24CB0", VA = "0x7BBC324CB0")]
		public UIAvatarConfirmPopController()
		{
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BB")]
		[Address(RVA = "0x1B24CC4", Offset = "0x1B24CC4", VA = "0x7BBC324CC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140CD0", Offset = "0x1140CD0")]
		private void <OnBuy>b__11_0()
		{
		}

		// Token: 0x04008678 RID: 34424
		[Token(Token = "0x4008678")]
		[FieldOffset(Offset = "0x98")]
		private UIAvatarConfirmPopView m_View;

		// Token: 0x04008679 RID: 34425
		[Token(Token = "0x4008679")]
		[FieldOffset(Offset = "0xA0")]
		private int m_num1;

		// Token: 0x0400867A RID: 34426
		[Token(Token = "0x400867A")]
		[FieldOffset(Offset = "0xA4")]
		private int m_num2;

		// Token: 0x0400867B RID: 34427
		[Token(Token = "0x400867B")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_AvatarId;

		// Token: 0x0400867C RID: 34428
		[Token(Token = "0x400867C")]
		[FieldOffset(Offset = "0xAC")]
		private uint buyid;

		// Token: 0x0400867D RID: 34429
		[Token(Token = "0x400867D")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_Interval;

		// Token: 0x0400867E RID: 34430
		[Token(Token = "0x400867E")]
		[FieldOffset(Offset = "0xB4")]
		private uint m_PriceGem;

		// Token: 0x0400867F RID: 34431
		[Token(Token = "0x400867F")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_cnt;

		// Token: 0x04008680 RID: 34432
		[Token(Token = "0x4008680")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelMall m_ModelMall;
	}
}
