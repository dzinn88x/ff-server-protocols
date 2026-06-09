using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001BC9 RID: 7113
	[Token(Token = "0x2001BC9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FADCC", Offset = "0x10FADCC")]
	public class UIVeteranBundleItemController : UIEasyListItemController
	{
		// Token: 0x060099CC RID: 39372 RVA: 0x000287B8 File Offset: 0x000269B8
		[Token(Token = "0x60099CC")]
		[Address(RVA = "0x1A0B570", Offset = "0x1A0B570", VA = "0x7BBC20B570")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CD")]
		[Address(RVA = "0x1A0B5C0", Offset = "0x1A0B5C0", VA = "0x7BBC20B5C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CE")]
		[Address(RVA = "0x1A0B684", Offset = "0x1A0B684", VA = "0x7BBC20B684", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CF")]
		[Address(RVA = "0x1A0B80C", Offset = "0x1A0B80C", VA = "0x7BBC20B80C")]
		public UIVeteranBundleItemController()
		{
		}

		// Token: 0x0400A0E7 RID: 41191
		[Token(Token = "0x400A0E7")]
		[FieldOffset(Offset = "0x70")]
		private UIStandardItemMiniController awardUI;

		// Token: 0x0400A0E8 RID: 41192
		[Token(Token = "0x400A0E8")]
		[FieldOffset(Offset = "0x78")]
		private BundleShowData m_Desc;

		// Token: 0x0400A0E9 RID: 41193
		[Token(Token = "0x400A0E9")]
		[FieldOffset(Offset = "0x80")]
		private UIVeteranBundleItemView m_View;
	}
}
