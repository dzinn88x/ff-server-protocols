using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016B7 RID: 5815
	[Token(Token = "0x20016B7")]
	public class UIAvatarPopMenuController : UIBasePopMenuController<UIAvatarPopMenuItemContoller>
	{
		// Token: 0x06006A48 RID: 27208 RVA: 0x0001E270 File Offset: 0x0001C470
		[Token(Token = "0x6006A48")]
		[Address(RVA = "0x207AC7C", Offset = "0x207AC7C", VA = "0x7BBC87AC7C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A49")]
		[Address(RVA = "0x207ACCC", Offset = "0x207ACCC", VA = "0x7BBC87ACCC")]
		public void SetData(List<CommonPopMenuData> list, [Optional] Action onDestroy)
		{
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4A")]
		[Address(RVA = "0x207AD38", Offset = "0x207AD38", VA = "0x7BBC87AD38", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0x207AD6C", Offset = "0x207AD6C", VA = "0x7BBC87AD6C")]
		public UIAvatarPopMenuController()
		{
		}

		// Token: 0x040086CC RID: 34508
		[Token(Token = "0x40086CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Action m_OnDestroyCallback;
	}
}
