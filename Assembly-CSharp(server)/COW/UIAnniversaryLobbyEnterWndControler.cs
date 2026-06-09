using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001412 RID: 5138
	[Token(Token = "0x2001412")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC588", Offset = "0x10EC588")]
	internal class UIAnniversaryLobbyEnterWndControler : UIPopupWindowController, IEasyList
	{
		// Token: 0x060054B6 RID: 21686 RVA: 0x000194B8 File Offset: 0x000176B8
		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x1B10EF0", Offset = "0x1B10EF0", VA = "0x7BBC310EF0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x1B10F40", Offset = "0x1B10F40", VA = "0x7BBC310F40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x1B110B0", Offset = "0x1B110B0", VA = "0x7BBC3110B0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x1B11508", Offset = "0x1B11508", VA = "0x7BBC311508", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x1B11510", Offset = "0x1B11510", VA = "0x7BBC311510", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x1B11518", Offset = "0x1B11518", VA = "0x7BBC311518", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x1B115AC", Offset = "0x1B115AC", VA = "0x7BBC3115AC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x1B115DC", Offset = "0x1B115DC", VA = "0x7BBC3115DC")]
		public UIAnniversaryLobbyEnterWndControler()
		{
		}

		// Token: 0x040079F6 RID: 31222
		[Token(Token = "0x40079F6")]
		[FieldOffset(Offset = "0x98")]
		private UIAnniversaryLobbyEnterWndView m_View;

		// Token: 0x040079F7 RID: 31223
		[Token(Token = "0x40079F7")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x040079F8 RID: 31224
		[Token(Token = "0x40079F8")]
		[FieldOffset(Offset = "0xA8")]
		private BigEventOpenInfoDesc m_BigEventOpenInfo;

		// Token: 0x040079F9 RID: 31225
		[Token(Token = "0x40079F9")]
		[FieldOffset(Offset = "0xB0")]
		private BigEventEntryDesc m_DescData;

		// Token: 0x040079FA RID: 31226
		[Token(Token = "0x40079FA")]
		private const uint MAIN_ENTRY_DESC_INDEX = 1U;

		// Token: 0x02001413 RID: 5139
		[Token(Token = "0x2001413")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC5C0", Offset = "0x10EC5C0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060054BF RID: 21695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054BF")]
			[Address(RVA = "0x1B11648", Offset = "0x1B11648", VA = "0x7BBC311648")]
			public <>c()
			{
			}

			// Token: 0x060054C0 RID: 21696 RVA: 0x000194D0 File Offset: 0x000176D0
			[Token(Token = "0x60054C0")]
			[Address(RVA = "0x1B11650", Offset = "0x1B11650", VA = "0x7BBC311650")]
			internal bool <OnUIOpen>b__7_0(BigEventEntryDesc x)
			{
				return default(bool);
			}

			// Token: 0x040079FB RID: 31227
			[Token(Token = "0x40079FB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAnniversaryLobbyEnterWndControler.<>c <>9;

			// Token: 0x040079FC RID: 31228
			[Token(Token = "0x40079FC")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<BigEventEntryDesc> <>9__7_0;
		}
	}
}
