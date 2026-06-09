using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001406 RID: 5126
	[Token(Token = "0x2001406")]
	public class UIActivityScrollViewItemController : UIActivityContentController
	{
		// Token: 0x06005463 RID: 21603 RVA: 0x000192F0 File Offset: 0x000174F0
		[Token(Token = "0x6005463")]
		[Address(RVA = "0x195B320", Offset = "0x195B320", VA = "0x7BBC15B320")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005464")]
		[Address(RVA = "0x195B370", Offset = "0x195B370", VA = "0x7BBC15B370", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005465")]
		[Address(RVA = "0x195AEF0", Offset = "0x195AEF0", VA = "0x7BBC15AEF0")]
		public void SetData(UIActivityScrollViewController.Data data)
		{
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005466")]
		[Address(RVA = "0x195B3D4", Offset = "0x195B3D4", VA = "0x7BBC15B3D4")]
		private void OnGoToClick()
		{
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005467")]
		[Address(RVA = "0x195B02C", Offset = "0x195B02C", VA = "0x7BBC15B02C")]
		public void SetLine()
		{
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005468")]
		[Address(RVA = "0x195B428", Offset = "0x195B428", VA = "0x7BBC15B428")]
		public UIActivityScrollViewItemController()
		{
		}

		// Token: 0x040079CD RID: 31181
		[Token(Token = "0x40079CD")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityScrollViewItemView m_View;

		// Token: 0x040079CE RID: 31182
		[Token(Token = "0x40079CE")]
		[FieldOffset(Offset = "0x60")]
		private UIActivityScrollViewController.Data m_Data;
	}
}
