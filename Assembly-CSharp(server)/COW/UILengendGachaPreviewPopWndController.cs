using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001834 RID: 6196
	[Token(Token = "0x2001834")]
	public class UILengendGachaPreviewPopWndController : UIPopupWindowController
	{
		// Token: 0x06007923 RID: 31011 RVA: 0x00021570 File Offset: 0x0001F770
		[Token(Token = "0x6007923")]
		[Address(RVA = "0x1CB5250", Offset = "0x1CB5250", VA = "0x7BBC4B5250")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007924")]
		[Address(RVA = "0x1CB52A0", Offset = "0x1CB52A0", VA = "0x7BBC4B52A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007925")]
		[Address(RVA = "0x1CB5458", Offset = "0x1CB5458", VA = "0x7BBC4B5458", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007926 RID: 31014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007926")]
		[Address(RVA = "0x1CB550C", Offset = "0x1CB550C", VA = "0x7BBC4B550C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007927")]
		[Address(RVA = "0x1CB55D8", Offset = "0x1CB55D8", VA = "0x7BBC4B55D8")]
		public void SetGachaID(uint gachaID)
		{
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007928")]
		[Address(RVA = "0x1CB55E0", Offset = "0x1CB55E0", VA = "0x7BBC4B55E0")]
		private void ShowView()
		{
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007929")]
		[Address(RVA = "0x1CB5BD0", Offset = "0x1CB5BD0", VA = "0x7BBC4B5BD0")]
		private void OnBtnProbabilityClick()
		{
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600792A")]
		[Address(RVA = "0x1CB5C80", Offset = "0x1CB5C80", VA = "0x7BBC4B5C80")]
		private void ShowRareProbabilityTips(params object[] param)
		{
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600792B")]
		[Address(RVA = "0x1CB5F28", Offset = "0x1CB5F28", VA = "0x7BBC4B5F28")]
		public UILengendGachaPreviewPopWndController()
		{
		}

		// Token: 0x04008EA8 RID: 36520
		[Token(Token = "0x4008EA8")]
		[FieldOffset(Offset = "0x98")]
		private UILengendGachaPreviewPopWndView m_View;

		// Token: 0x04008EA9 RID: 36521
		[Token(Token = "0x4008EA9")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelGacha m_Model;

		// Token: 0x04008EAA RID: 36522
		[Token(Token = "0x4008EAA")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_GachaID;
	}
}
