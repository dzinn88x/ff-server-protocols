using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B5B RID: 7003
	[Token(Token = "0x2001B5B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9D54", Offset = "0x10F9D54")]
	public class UIRewardPreviewItemRowController : UIPopupWindowController
	{
		// Token: 0x0600968C RID: 38540 RVA: 0x00027CA8 File Offset: 0x00025EA8
		[Token(Token = "0x600968C")]
		[Address(RVA = "0x1E20190", Offset = "0x1E20190", VA = "0x7BBC620190")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600968D")]
		[Address(RVA = "0x1E201E0", Offset = "0x1E201E0", VA = "0x7BBC6201E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600968E RID: 38542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600968E")]
		[Address(RVA = "0x1E20244", Offset = "0x1E20244", VA = "0x7BBC620244")]
		public void SetViewData(List<List<BaseItemInfo>> infos, [Optional] string desc)
		{
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600968F")]
		[Address(RVA = "0x1E204CC", Offset = "0x1E204CC", VA = "0x7BBC6204CC")]
		private void OnOKClick()
		{
		}

		// Token: 0x06009690 RID: 38544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009690")]
		[Address(RVA = "0x1E204D4", Offset = "0x1E204D4", VA = "0x7BBC6204D4")]
		public UIRewardPreviewItemRowController()
		{
		}

		// Token: 0x04009F17 RID: 40727
		[Token(Token = "0x4009F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIRewardPreviewItemRowView m_View;
	}
}
