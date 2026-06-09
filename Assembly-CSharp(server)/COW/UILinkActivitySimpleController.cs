using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001553 RID: 5459
	[Token(Token = "0x2001553")]
	public class UILinkActivitySimpleController<T> : UILinkActivityDetailController where T : UIBaseController, ISetBaseItemInfo
	{
		// Token: 0x06005E70 RID: 24176 RVA: 0x0001B5A0 File Offset: 0x000197A0
		[Token(Token = "0x6005E70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E71")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E72")]
		protected override void InitActivityInfo()
		{
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E73")]
		protected virtual void InitActivityInfo(LinkActivityData data)
		{
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E74")]
		public static void InitCdnTexture(UINetworkTexture tex, string url)
		{
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E75")]
		protected void ShowDailyRewardsGot(bool e)
		{
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E76")]
		public UILinkActivitySimpleController()
		{
		}

		// Token: 0x04007FC0 RID: 32704
		[Token(Token = "0x4007FC0")]
		[FieldOffset(Offset = "0x0")]
		protected UILinkActivitySimpleView m_View;

		// Token: 0x04007FC1 RID: 32705
		[Token(Token = "0x4007FC1")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_DailyAwardControllers;
	}
}
