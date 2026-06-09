using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B5C RID: 7004
	[Token(Token = "0x2001B5C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9D8C", Offset = "0x10F9D8C")]
	public class UIRewardPreviewMultiRowController : UIPopupWindowController
	{
		// Token: 0x06009691 RID: 38545 RVA: 0x00027CC0 File Offset: 0x00025EC0
		[Token(Token = "0x6009691")]
		[Address(RVA = "0x1E207FC", Offset = "0x1E207FC", VA = "0x7BBC6207FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009692")]
		[Address(RVA = "0x1E2084C", Offset = "0x1E2084C", VA = "0x7BBC62084C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009693")]
		[Address(RVA = "0x1E20930", Offset = "0x1E20930", VA = "0x7BBC620930")]
		public void SetViewData(List<List<List<BaseItemInfo>>> infos, List<string> desc, [Optional] string title, [Optional] string btnLabel)
		{
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009694")]
		[Address(RVA = "0x1E20BB4", Offset = "0x1E20BB4", VA = "0x7BBC620BB4")]
		private void OnOKClick()
		{
		}

		// Token: 0x06009695 RID: 38549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009695")]
		[Address(RVA = "0x1E20BBC", Offset = "0x1E20BBC", VA = "0x7BBC620BBC")]
		public UIRewardPreviewMultiRowController()
		{
		}

		// Token: 0x04009F18 RID: 40728
		[Token(Token = "0x4009F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIRewardPreviewMultiRowView m_View;
	}
}
