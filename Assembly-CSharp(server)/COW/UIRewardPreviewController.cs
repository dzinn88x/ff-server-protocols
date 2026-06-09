using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B59 RID: 7001
	[Token(Token = "0x2001B59")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9CE4", Offset = "0x10F9CE4")]
	public class UIRewardPreviewController : UIPopupWindowController
	{
		// Token: 0x06009683 RID: 38531 RVA: 0x00027C78 File Offset: 0x00025E78
		[Token(Token = "0x6009683")]
		[Address(RVA = "0x1E1FC94", Offset = "0x1E1FC94", VA = "0x7BBC61FC94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009684")]
		[Address(RVA = "0x1E1FCE4", Offset = "0x1E1FCE4", VA = "0x7BBC61FCE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009685")]
		[Address(RVA = "0x1E1FDC8", Offset = "0x1E1FDC8", VA = "0x7BBC61FDC8")]
		public void SetViewData(List<BaseItemInfo> infos, [Optional] string title, [Optional] string desc, [Optional] string btnLabel)
		{
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009686")]
		[Address(RVA = "0x1E20040", Offset = "0x1E20040", VA = "0x7BBC620040")]
		private void OnOKClick()
		{
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009687")]
		[Address(RVA = "0x1E20048", Offset = "0x1E20048", VA = "0x7BBC620048")]
		public UIRewardPreviewController()
		{
		}

		// Token: 0x04009F15 RID: 40725
		[Token(Token = "0x4009F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIRewardPreviewView m_View;
	}
}
