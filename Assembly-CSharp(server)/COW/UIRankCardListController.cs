using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B36 RID: 6966
	[Token(Token = "0x2001B36")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F97CC", Offset = "0x10F97CC")]
	public class UIRankCardListController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06009593 RID: 38291 RVA: 0x000278D0 File Offset: 0x00025AD0
		[Token(Token = "0x6009593")]
		[Address(RVA = "0x1E09EF8", Offset = "0x1E09EF8", VA = "0x7BBC609EF8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009594")]
		[Address(RVA = "0x1E09F48", Offset = "0x1E09F48", VA = "0x7BBC609F48", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009595 RID: 38293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009595")]
		[Address(RVA = "0x1E09FD8", Offset = "0x1E09FD8", VA = "0x7BBC609FD8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06009596 RID: 38294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009596")]
		[Address(RVA = "0x1E09FE0", Offset = "0x1E09FE0", VA = "0x7BBC609FE0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009597 RID: 38295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009597")]
		[Address(RVA = "0x1E09FE8", Offset = "0x1E09FE8", VA = "0x7BBC609FE8")]
		public void RefreshRankCardData(int currentSelectedRankCardId)
		{
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009598")]
		[Address(RVA = "0x1E0A27C", Offset = "0x1E0A27C", VA = "0x7BBC60A27C", Slot = "41")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009599 RID: 38297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009599")]
		[Address(RVA = "0x1E0A2AC", Offset = "0x1E0A2AC", VA = "0x7BBC60A2AC", Slot = "40")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600959A")]
		[Address(RVA = "0x1E0A340", Offset = "0x1E0A340", VA = "0x7BBC60A340")]
		public UIRankCardListController()
		{
		}

		// Token: 0x04009EB1 RID: 40625
		[Token(Token = "0x4009EB1")]
		[FieldOffset(Offset = "0x98")]
		private UIRankCardListView m_View;

		// Token: 0x02001B37 RID: 6967
		[Token(Token = "0x2001B37")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9804", Offset = "0x10F9804")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x0600959B RID: 38299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600959B")]
			[Address(RVA = "0x1E0A274", Offset = "0x1E0A274", VA = "0x7BBC60A274")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0600959C RID: 38300 RVA: 0x000278E8 File Offset: 0x00025AE8
			[Token(Token = "0x600959C")]
			[Address(RVA = "0x1E0A3E8", Offset = "0x1E0A3E8", VA = "0x7BBC60A3E8")]
			internal bool <RefreshRankCardData>b__1(RankCardData e)
			{
				return default(bool);
			}

			// Token: 0x04009EB2 RID: 40626
			[Token(Token = "0x4009EB2")]
			[FieldOffset(Offset = "0x10")]
			public int currentSelectedRankCardId;
		}

		// Token: 0x02001B38 RID: 6968
		[Token(Token = "0x2001B38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9814", Offset = "0x10F9814")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600959E RID: 38302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600959E")]
			[Address(RVA = "0x1E0A3AC", Offset = "0x1E0A3AC", VA = "0x7BBC60A3AC")]
			public <>c()
			{
			}

			// Token: 0x0600959F RID: 38303 RVA: 0x00027900 File Offset: 0x00025B00
			[Token(Token = "0x600959F")]
			[Address(RVA = "0x1E0A3B4", Offset = "0x1E0A3B4", VA = "0x7BBC60A3B4")]
			internal bool <RefreshRankCardData>b__5_0(RankCardData d)
			{
				return default(bool);
			}

			// Token: 0x04009EB3 RID: 40627
			[Token(Token = "0x4009EB3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIRankCardListController.<>c <>9;

			// Token: 0x04009EB4 RID: 40628
			[Token(Token = "0x4009EB4")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<RankCardData> <>9__5_0;
		}
	}
}
