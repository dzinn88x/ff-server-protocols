using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001949 RID: 6473
	[Token(Token = "0x2001949")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5EC4", Offset = "0x10F5EC4")]
	internal class UIHudRedEnvelopeReceiveListController : UIPopupWindowController
	{
		// Token: 0x06008345 RID: 33605 RVA: 0x00023A90 File Offset: 0x00021C90
		[Token(Token = "0x6008345")]
		[Address(RVA = "0x17F0D94", Offset = "0x17F0D94", VA = "0x7BBBFF0D94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008346")]
		[Address(RVA = "0x17F0DE4", Offset = "0x17F0DE4", VA = "0x7BBBFF0DE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x00023AA8 File Offset: 0x00021CA8
		[Token(Token = "0x6008347")]
		[Address(RVA = "0x17F0F00", Offset = "0x17F0F00", VA = "0x7BBBFF0F00")]
		private int GetSortOrder(RedEnvelopeAwardDisplayInfo award)
		{
			return 0;
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008348")]
		[Address(RVA = "0x17F0918", Offset = "0x17F0918", VA = "0x7BBBFF0918")]
		public void SetReceiveData(List<RedEnvelopeAwardDisplayInfo> itemList, string ownerName)
		{
		}

		// Token: 0x06008349 RID: 33609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008349")]
		[Address(RVA = "0x17F0F4C", Offset = "0x17F0F4C", VA = "0x7BBBFF0F4C")]
		public UIHudRedEnvelopeReceiveListController()
		{
		}

		// Token: 0x0600834A RID: 33610 RVA: 0x00023AC0 File Offset: 0x00021CC0
		[Token(Token = "0x600834A")]
		[Address(RVA = "0x17F0FBC", Offset = "0x17F0FBC", VA = "0x7BBBFF0FBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11432A0", Offset = "0x11432A0")]
		private int <SetReceiveData>b__5_0(RedEnvelopeAwardDisplayInfo a, RedEnvelopeAwardDisplayInfo b)
		{
			return 0;
		}

		// Token: 0x0400942F RID: 37935
		[Token(Token = "0x400942F")]
		[FieldOffset(Offset = "0x98")]
		private UIHudRedEnvelopeReceiveListView m_View;

		// Token: 0x04009430 RID: 37936
		[Token(Token = "0x4009430")]
		[FieldOffset(Offset = "0xA0")]
		private List<RedEnvelopeAwardItemView> m_ItemViewList;
	}
}
