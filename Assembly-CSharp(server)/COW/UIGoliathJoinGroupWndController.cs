using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200137E RID: 4990
	[Token(Token = "0x200137E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB6B0", Offset = "0x10EB6B0")]
	public class UIGoliathJoinGroupWndController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x0600503A RID: 20538 RVA: 0x00018600 File Offset: 0x00016800
		[Token(Token = "0x600503A")]
		[Address(RVA = "0x1A7530C", Offset = "0x1A7530C", VA = "0x7BBC27530C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503B")]
		[Address(RVA = "0x1A7535C", Offset = "0x1A7535C", VA = "0x7BBC27535C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503C")]
		[Address(RVA = "0x1A7571C", Offset = "0x1A7571C", VA = "0x7BBC27571C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503D")]
		[Address(RVA = "0x1A7575C", Offset = "0x1A7575C", VA = "0x7BBC27575C")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503E")]
		[Address(RVA = "0x1A75764", Offset = "0x1A75764", VA = "0x7BBC275764")]
		private void OnBtnSearchClick()
		{
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503F")]
		[Address(RVA = "0x1A75938", Offset = "0x1A75938", VA = "0x7BBC275938", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00018618 File Offset: 0x00016818
		[Token(Token = "0x6005040")]
		[Address(RVA = "0x1A75ED0", Offset = "0x1A75ED0", VA = "0x7BBC275ED0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005041")]
		[Address(RVA = "0x1A75F14", Offset = "0x1A75F14", VA = "0x7BBC275F14", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005042")]
		[Address(RVA = "0x1A75FD0", Offset = "0x1A75FD0", VA = "0x7BBC275FD0", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005043")]
		[Address(RVA = "0x1A76000", Offset = "0x1A76000", VA = "0x7BBC276000")]
		public UIGoliathJoinGroupWndController()
		{
		}

		// Token: 0x040076B8 RID: 30392
		[Token(Token = "0x40076B8")]
		[FieldOffset(Offset = "0x98")]
		private UIGoliathJoinGroupWndView m_View;

		// Token: 0x040076B9 RID: 30393
		[Token(Token = "0x40076B9")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x040076BA RID: 30394
		[Token(Token = "0x40076BA")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelGoliath m_ModelGoliath;

		// Token: 0x040076BB RID: 30395
		[Token(Token = "0x40076BB")]
		[FieldOffset(Offset = "0xB0")]
		private UIGoliathJoinGroupItemController m_SearchResItemCtrl;

		// Token: 0x040076BC RID: 30396
		[Token(Token = "0x40076BC")]
		[FieldOffset(Offset = "0xB8")]
		private List<FastBigEventMsg> m_Invitations;

		// Token: 0x040076BD RID: 30397
		[Token(Token = "0x40076BD")]
		private const uint GORUP_ID_MIN_LENGTH = 10U;

		// Token: 0x0200137F RID: 4991
		[Token(Token = "0x200137F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB6E8", Offset = "0x10EB6E8")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06005044 RID: 20548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005044")]
			[Address(RVA = "0x1A75EC8", Offset = "0x1A75EC8", VA = "0x7BBC275EC8")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06005045 RID: 20549 RVA: 0x00018630 File Offset: 0x00016830
			[Token(Token = "0x6005045")]
			[Address(RVA = "0x1A76070", Offset = "0x1A76070", VA = "0x7BBC276070")]
			internal bool <OnDataChanged>b__0(FastBigEventMsg item)
			{
				return default(bool);
			}

			// Token: 0x040076BE RID: 30398
			[Token(Token = "0x40076BE")]
			[FieldOffset(Offset = "0x10")]
			public ulong groupID;
		}
	}
}
