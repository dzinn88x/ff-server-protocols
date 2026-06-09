using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018CA RID: 6346
	[Token(Token = "0x20018CA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4D6C", Offset = "0x10F4D6C")]
	internal class UIHudGameShowInfoController : UIBaseController
	{
		// Token: 0x06007E60 RID: 32352 RVA: 0x000228F0 File Offset: 0x00020AF0
		[Token(Token = "0x6007E60")]
		[Address(RVA = "0x1C13C7C", Offset = "0x1C13C7C", VA = "0x7BBC413C7C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E61")]
		[Address(RVA = "0x1C13CCC", Offset = "0x1C13CCC", VA = "0x7BBC413CCC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E62")]
		[Address(RVA = "0x1C13D30", Offset = "0x1C13D30", VA = "0x7BBC413D30")]
		public void SetUIdata(EGameShowStyle style, string introKey = "", string introDeatil = "")
		{
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E63")]
		[Address(RVA = "0x1C14474", Offset = "0x1C14474", VA = "0x7BBC414474", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E64")]
		[Address(RVA = "0x1C14520", Offset = "0x1C14520", VA = "0x7BBC414520", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E65")]
		[Address(RVA = "0x1C145CC", Offset = "0x1C145CC", VA = "0x7BBC4145CC")]
		[Attribute(Name = "ContextMenu", RVA = "0x1142CDC", Offset = "0x1142CDC")]
		public void DebugShowInfo()
		{
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E66")]
		[Address(RVA = "0x1C14654", Offset = "0x1C14654", VA = "0x7BBC414654")]
		public UIHudGameShowInfoController()
		{
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E67")]
		[Address(RVA = "0x1C146C4", Offset = "0x1C146C4", VA = "0x7BBC4146C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142D14", Offset = "0x1142D14")]
		private void <SetUIdata>b__5_0()
		{
		}

		// Token: 0x040091C2 RID: 37314
		[Token(Token = "0x40091C2")]
		[FieldOffset(Offset = "0x58")]
		private uint m_ShowinfodelayCall;

		// Token: 0x040091C3 RID: 37315
		[Token(Token = "0x40091C3")]
		[FieldOffset(Offset = "0x60")]
		private UIHudGameShowInfoView m_View;

		// Token: 0x040091C4 RID: 37316
		[Token(Token = "0x40091C4")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<int, UIHudGameShowInfoStyleController> m_StyleCtrlDict;
	}
}
