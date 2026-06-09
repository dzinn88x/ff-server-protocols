using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001617 RID: 5655
	[Token(Token = "0x2001617")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFA74", Offset = "0x10EFA74")]
	public class UISPReplayItemController : UIEasyListItemController
	{
		// Token: 0x0600658E RID: 25998 RVA: 0x0001D058 File Offset: 0x0001B258
		[Token(Token = "0x600658E")]
		[Address(RVA = "0x1627E1C", Offset = "0x1627E1C", VA = "0x7BBBE27E1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658F")]
		[Address(RVA = "0x1627E6C", Offset = "0x1627E6C", VA = "0x7BBBE27E6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006590")]
		[Address(RVA = "0x1628000", Offset = "0x1628000", VA = "0x7BBBE28000", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006591")]
		[Address(RVA = "0x1628384", Offset = "0x1628384", VA = "0x7BBBE28384")]
		private void OnPlayClick()
		{
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006592")]
		[Address(RVA = "0x16284C0", Offset = "0x16284C0", VA = "0x7BBBE284C0")]
		private void OnDelClick()
		{
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006593")]
		[Address(RVA = "0x1628324", Offset = "0x1628324", VA = "0x7BBBE28324")]
		private string Replace(string origin)
		{
			return null;
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006594")]
		[Address(RVA = "0x16284F4", Offset = "0x16284F4", VA = "0x7BBBE284F4")]
		public UISPReplayItemController()
		{
		}

		// Token: 0x040083CD RID: 33741
		[Token(Token = "0x40083CD")]
		[FieldOffset(Offset = "0x70")]
		private UISPReplayItemView m_View;

		// Token: 0x040083CE RID: 33742
		[Token(Token = "0x40083CE")]
		[FieldOffset(Offset = "0x78")]
		private TimeSpan m_Span;

		// Token: 0x040083CF RID: 33743
		[Token(Token = "0x40083CF")]
		[FieldOffset(Offset = "0x80")]
		private ReplayInfo m_CurInfo;

		// Token: 0x040083D0 RID: 33744
		[Token(Token = "0x40083D0")]
		[FieldOffset(Offset = "0x88")]
		private UIModelReplay m_Model;
	}
}
