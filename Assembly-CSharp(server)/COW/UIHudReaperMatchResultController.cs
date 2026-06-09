using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001645 RID: 5701
	[Token(Token = "0x2001645")]
	internal class UIHudReaperMatchResultController : UIHudMatchResultBaseShareController
	{
		// Token: 0x060066DF RID: 26335 RVA: 0x0001D580 File Offset: 0x0001B780
		[Token(Token = "0x60066DF")]
		[Address(RVA = "0x17EA784", Offset = "0x17EA784", VA = "0x7BBBFEA784")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E0")]
		[Address(RVA = "0x17EA7D4", Offset = "0x17EA7D4", VA = "0x7BBBFEA7D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E1")]
		[Address(RVA = "0x17EADE0", Offset = "0x17EADE0", VA = "0x7BBBFEADE0", Slot = "30")]
		protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x060066E2 RID: 26338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E2")]
		[Address(RVA = "0x17EAA0C", Offset = "0x17EAA0C", VA = "0x7BBBFEAA0C")]
		private void ShowUI(MatchStats statsData, MatchIncome income)
		{
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E3")]
		[Address(RVA = "0x17EADF4", Offset = "0x17EADF4", VA = "0x7BBBFEADF4")]
		public UIHudReaperMatchResultController()
		{
		}

		// Token: 0x04008472 RID: 33906
		[Token(Token = "0x4008472")]
		[FieldOffset(Offset = "0xA0")]
		private UIHudReaperMatchResultView m_View;

		// Token: 0x04008473 RID: 33907
		[Token(Token = "0x4008473")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_UIInited;

		// Token: 0x04008474 RID: 33908
		[Token(Token = "0x4008474")]
		[FieldOffset(Offset = "0xB0")]
		private UIHudReaperMatchResultItemController[] m_Items;

		// Token: 0x02001646 RID: 5702
		[Token(Token = "0x2001646")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFF5C", Offset = "0x10EFF5C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060066E5 RID: 26341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066E5")]
			[Address(RVA = "0x17EAEB8", Offset = "0x17EAEB8", VA = "0x7BBBFEAEB8")]
			public <>c()
			{
			}

			// Token: 0x060066E6 RID: 26342 RVA: 0x0001D598 File Offset: 0x0001B798
			[Token(Token = "0x60066E6")]
			[Address(RVA = "0x17EAEC0", Offset = "0x17EAEC0", VA = "0x7BBBFEAEC0")]
			internal int <ShowUI>b__6_0(TeammateStats a, TeammateStats b)
			{
				return 0;
			}

			// Token: 0x04008475 RID: 33909
			[Token(Token = "0x4008475")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudReaperMatchResultController.<>c <>9;

			// Token: 0x04008476 RID: 33910
			[Token(Token = "0x4008476")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<TeammateStats> <>9__6_0;
		}
	}
}
