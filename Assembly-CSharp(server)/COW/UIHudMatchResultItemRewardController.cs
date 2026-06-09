using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015F2 RID: 5618
	[Token(Token = "0x20015F2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF67C", Offset = "0x10EF67C")]
	public class UIHudMatchResultItemRewardController : UIPopupWindowController
	{
		// Token: 0x0600640F RID: 25615 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		[Token(Token = "0x600640F")]
		[Address(RVA = "0x17AA6F4", Offset = "0x17AA6F4", VA = "0x7BBBFAA6F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006410")]
		[Address(RVA = "0x17AA744", Offset = "0x17AA744", VA = "0x7BBBFAA744", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006411")]
		[Address(RVA = "0x17AA828", Offset = "0x17AA828", VA = "0x7BBBFAA828", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006412")]
		[Address(RVA = "0x17AA8D4", Offset = "0x17AA8D4", VA = "0x7BBBFAA8D4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006413")]
		[Address(RVA = "0x17AAA08", Offset = "0x17AAA08", VA = "0x7BBBFAAA08")]
		public void ShowRewards(List<CommonRewardItemInfo> debrisList, List<CommonRewardItemInfo> commonList)
		{
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		[Token(Token = "0x6006414")]
		[Address(RVA = "0x17AAF30", Offset = "0x17AAF30", VA = "0x7BBBFAAF30", Slot = "30")]
		public override int GlassDelay()
		{
			return 0;
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006415")]
		[Address(RVA = "0x17AAF38", Offset = "0x17AAF38", VA = "0x7BBBFAAF38")]
		private void OnClickSkipMaskBtn()
		{
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006416")]
		[Address(RVA = "0x17AAF40", Offset = "0x17AAF40", VA = "0x7BBBFAAF40")]
		public UIHudMatchResultItemRewardController()
		{
		}

		// Token: 0x040082C9 RID: 33481
		[Token(Token = "0x40082C9")]
		[FieldOffset(Offset = "0x98")]
		private UIHudMatchResultItemRewardView m_View;
	}
}
