using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B23 RID: 6947
	[Token(Token = "0x2001B23")]
	public class UIProfileDocumentRulePopWndController : UIPopupWindowController
	{
		// Token: 0x060094C5 RID: 38085 RVA: 0x00027540 File Offset: 0x00025740
		[Token(Token = "0x60094C5")]
		[Address(RVA = "0x1B66A8C", Offset = "0x1B66A8C", VA = "0x7BBC366A8C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094C6")]
		[Address(RVA = "0x1B66ADC", Offset = "0x1B66ADC", VA = "0x7BBC366ADC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094C7")]
		[Address(RVA = "0x1B67194", Offset = "0x1B67194", VA = "0x7BBC367194")]
		private void InitDots()
		{
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094C8")]
		[Address(RVA = "0x1B66D00", Offset = "0x1B66D00", VA = "0x7BBC366D00")]
		private void InitTutorial()
		{
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094C9")]
		[Address(RVA = "0x1B675D4", Offset = "0x1B675D4", VA = "0x7BBC3675D4")]
		private void OnAutoScrollAdItem()
		{
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CA")]
		[Address(RVA = "0x1B569BC", Offset = "0x1B569BC", VA = "0x7BBC3569BC")]
		public void ForceScrollToItem(int index)
		{
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CB")]
		[Address(RVA = "0x1B676DC", Offset = "0x1B676DC", VA = "0x7BBC3676DC")]
		private void GetCenterItem(GameObject centerGo)
		{
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CC")]
		[Address(RVA = "0x1B678B8", Offset = "0x1B678B8", VA = "0x7BBC3678B8")]
		public UIProfileDocumentRulePopWndController()
		{
		}

		// Token: 0x04009E40 RID: 40512
		[Token(Token = "0x4009E40")]
		[FieldOffset(Offset = "0x98")]
		private List<UILobbyDotController> m_DotCtrls;

		// Token: 0x04009E41 RID: 40513
		[Token(Token = "0x4009E41")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIProfileDocumentRuleItemController> m_Items;

		// Token: 0x04009E42 RID: 40514
		[Token(Token = "0x4009E42")]
		[FieldOffset(Offset = "0xA8")]
		private UIProfileDocumentRulePopWndView m_View;

		// Token: 0x04009E43 RID: 40515
		[Token(Token = "0x4009E43")]
		[FieldOffset(Offset = "0xB0")]
		private UICenterOnChild m_wrapCenter;

		// Token: 0x04009E44 RID: 40516
		[Token(Token = "0x4009E44")]
		[FieldOffset(Offset = "0xB8")]
		private UIDragScrollView m_Drag;

		// Token: 0x04009E45 RID: 40517
		[Token(Token = "0x4009E45")]
		[FieldOffset(Offset = "0xC0")]
		private int m_LastSelectedMapIndex;
	}
}
