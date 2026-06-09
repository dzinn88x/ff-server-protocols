using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019B5 RID: 6581
	[Token(Token = "0x20019B5")]
	public class UIImageShareCaptureWidgetController : UIBaseController
	{
		// Token: 0x060086F3 RID: 34547 RVA: 0x000247E0 File Offset: 0x000229E0
		[Token(Token = "0x60086F3")]
		[Address(RVA = "0x138BDCC", Offset = "0x138BDCC", VA = "0x7BBBB8BDCC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060086F4 RID: 34548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086F4")]
		[Address(RVA = "0x138BE1C", Offset = "0x138BE1C", VA = "0x7BBBB8BE1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086F5")]
		[Address(RVA = "0x138BE74", Offset = "0x138BE74", VA = "0x7BBBB8BE74")]
		private void UpdatePlayerBasicInfo()
		{
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086F6")]
		[Address(RVA = "0x138C18C", Offset = "0x138C18C", VA = "0x7BBBB8C18C")]
		private void UpdatePlayerBasicInfo_P()
		{
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086F7")]
		[Address(RVA = "0x138C4A4", Offset = "0x138C4A4", VA = "0x7BBBB8C4A4")]
		public void SetTarget(GameObject target, bool hasTopBar, bool hasLeftBar, bool isLandScape, float logoScale)
		{
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086F8")]
		[Address(RVA = "0x138C7E0", Offset = "0x138C7E0", VA = "0x7BBBB8C7E0")]
		public UIImageShareCaptureWidgetController()
		{
		}

		// Token: 0x040095C7 RID: 38343
		[Token(Token = "0x40095C7")]
		[FieldOffset(Offset = "0x58")]
		private UIImageShareCaptureWidgetView m_View;
	}
}
