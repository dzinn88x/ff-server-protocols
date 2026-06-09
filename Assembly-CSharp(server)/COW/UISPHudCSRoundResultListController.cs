using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B8E RID: 7054
	[Token(Token = "0x2001B8E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA59C", Offset = "0x10FA59C")]
	internal class UISPHudCSRoundResultListController : UIBaseController
	{
		// Token: 0x0600982A RID: 38954 RVA: 0x00028110 File Offset: 0x00026310
		[Token(Token = "0x600982A")]
		[Address(RVA = "0x1EE273C", Offset = "0x1EE273C", VA = "0x7BBC6E273C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600982B")]
		[Address(RVA = "0x1EE278C", Offset = "0x1EE278C", VA = "0x7BBC6E278C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600982C")]
		[Address(RVA = "0x1EE2938", Offset = "0x1EE2938", VA = "0x7BBC6E2938", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600982D")]
		[Address(RVA = "0x1EE2A30", Offset = "0x1EE2A30", VA = "0x7BBC6E2A30", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600982E")]
		[Address(RVA = "0x1EE2BA4", Offset = "0x1EE2BA4", VA = "0x7BBC6E2BA4")]
		private void OnMaxRoundChanged(params object[] data)
		{
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600982F")]
		[Address(RVA = "0x1EE3020", Offset = "0x1EE3020", VA = "0x7BBC6E3020")]
		private void OnRoundResultUpdate(params object[] data)
		{
		}

		// Token: 0x06009830 RID: 38960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009830")]
		[Address(RVA = "0x1EE3328", Offset = "0x1EE3328", VA = "0x7BBC6E3328")]
		private void OnToggleRoundInfo(params object[] data)
		{
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009831")]
		[Address(RVA = "0x1EE2964", Offset = "0x1EE2964", VA = "0x7BBC6E2964")]
		private void OnShowRoundInfo(bool show)
		{
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009832")]
		[Address(RVA = "0x1EE3338", Offset = "0x1EE3338", VA = "0x7BBC6E3338")]
		public UISPHudCSRoundResultListController()
		{
		}

		// Token: 0x0400A020 RID: 40992
		[Token(Token = "0x400A020")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudCSRoundResultListView m_View;

		// Token: 0x0400A021 RID: 40993
		[Token(Token = "0x400A021")]
		[FieldOffset(Offset = "0x60")]
		private OIzkGzi mGame;

		// Token: 0x0400A022 RID: 40994
		[Token(Token = "0x400A022")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsShow;

		// Token: 0x0400A023 RID: 40995
		[Token(Token = "0x400A023")]
		[FieldOffset(Offset = "0x70")]
		private List<UISPHudCSRoundResultItemController> mRoundItems;
	}
}
