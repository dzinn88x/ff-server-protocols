using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016F6 RID: 5878
	[Token(Token = "0x20016F6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1274", Offset = "0x10F1274")]
	public class UIChatBlockListItemController : UIEasyListItemController
	{
		// Token: 0x06006D24 RID: 27940 RVA: 0x0001EC60 File Offset: 0x0001CE60
		[Token(Token = "0x6006D24")]
		[Address(RVA = "0x1BE019C", Offset = "0x1BE019C", VA = "0x7BBC3E019C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D25")]
		[Address(RVA = "0x1BE01EC", Offset = "0x1BE01EC", VA = "0x7BBC3E01EC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D26")]
		[Address(RVA = "0x1BE02D0", Offset = "0x1BE02D0", VA = "0x7BBC3E02D0")]
		private void OnRemoveBtnClick()
		{
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D27")]
		[Address(RVA = "0x1BE05E0", Offset = "0x1BE05E0", VA = "0x7BBC3E05E0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D28")]
		[Address(RVA = "0x1BE06EC", Offset = "0x1BE06EC", VA = "0x7BBC3E06EC")]
		public UIChatBlockListItemController()
		{
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D29")]
		[Address(RVA = "0x1BE06F4", Offset = "0x1BE06F4", VA = "0x7BBC3E06F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11412EC", Offset = "0x11412EC")]
		private void <OnRemoveBtnClick>b__4_0()
		{
		}

		// Token: 0x0400887C RID: 34940
		[Token(Token = "0x400887C")]
		[FieldOffset(Offset = "0x70")]
		private UIChatBlockListItemView m_View;

		// Token: 0x0400887D RID: 34941
		[Token(Token = "0x400887D")]
		[FieldOffset(Offset = "0x78")]
		private ChatBlockUserInfo m_Info;
	}
}
