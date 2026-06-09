using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200177F RID: 6015
	[Token(Token = "0x200177F")]
	public class UICustomRoomCountDownWindowController : UIPopupWindowController
	{
		// Token: 0x0600721C RID: 29212 RVA: 0x0001FC38 File Offset: 0x0001DE38
		[Token(Token = "0x600721C")]
		[Address(RVA = "0x1BAAC98", Offset = "0x1BAAC98", VA = "0x7BBC3AAC98")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600721D")]
		[Address(RVA = "0x1BAACE8", Offset = "0x1BAACE8", VA = "0x7BBC3AACE8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x0001FC50 File Offset: 0x0001DE50
		[Token(Token = "0x600721E")]
		[Address(RVA = "0x1BAAE3C", Offset = "0x1BAAE3C", VA = "0x7BBC3AAE3C", Slot = "36")]
		public override bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600721F")]
		[Address(RVA = "0x1BAAE44", Offset = "0x1BAAE44", VA = "0x7BBC3AAE44")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007220")]
		[Address(RVA = "0x1BAA728", Offset = "0x1BAA728", VA = "0x7BBC3AA728")]
		public void SetCountDownTime(uint time)
		{
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007221")]
		[Address(RVA = "0x1BAB080", Offset = "0x1BAB080", VA = "0x7BBC3AB080", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007222")]
		[Address(RVA = "0x1BAB088", Offset = "0x1BAB088", VA = "0x7BBC3AB088")]
		public UICustomRoomCountDownWindowController()
		{
		}

		// Token: 0x04008B4B RID: 35659
		[Token(Token = "0x4008B4B")]
		[FieldOffset(Offset = "0x98")]
		private UICustomRoomCountDownWindowView m_View;

		// Token: 0x04008B4C RID: 35660
		[Token(Token = "0x4008B4C")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelCustomRoom m_Model;

		// Token: 0x04008B4D RID: 35661
		[Token(Token = "0x4008B4D")]
		[FieldOffset(Offset = "0xA8")]
		private ulong m_CountDownTimeStampMS;

		// Token: 0x04008B4E RID: 35662
		[Token(Token = "0x4008B4E")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_CountDownTime;

		// Token: 0x04008B4F RID: 35663
		[Token(Token = "0x4008B4F")]
		[FieldOffset(Offset = "0xB4")]
		private uint m_CurrentCountDownTime;

		// Token: 0x04008B50 RID: 35664
		[Token(Token = "0x4008B50")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_LastCountDownTime;

		// Token: 0x04008B51 RID: 35665
		[Token(Token = "0x4008B51")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_IsRoomOwner;
	}
}
