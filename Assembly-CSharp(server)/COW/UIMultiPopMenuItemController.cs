using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A7D RID: 6781
	[Token(Token = "0x2001A7D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F848C", Offset = "0x10F848C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x10F848C", Offset = "0x10F848C")]
	public class UIMultiPopMenuItemController : UIPopMenuItemBaseController
	{
		// Token: 0x06008ED8 RID: 36568 RVA: 0x00026160 File Offset: 0x00024360
		[Token(Token = "0x6008ED8")]
		[Address(RVA = "0x14CBE50", Offset = "0x14CBE50", VA = "0x7BBBCCBE50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ED9")]
		[Address(RVA = "0x14CBEA0", Offset = "0x14CBEA0", VA = "0x7BBBCCBEA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EDA")]
		[Address(RVA = "0x14CBF84", Offset = "0x14CBF84", VA = "0x7BBBCCBF84", Slot = "29")]
		public override void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
		{
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EDB")]
		[Address(RVA = "0x14CC2A8", Offset = "0x14CC2A8", VA = "0x7BBBCCC2A8")]
		public void SetDisableState(bool CanSelect)
		{
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EDC")]
		[Address(RVA = "0x14CC144", Offset = "0x14CC144", VA = "0x7BBBCCC144")]
		public void SetSelectedState(bool selected)
		{
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EDD")]
		[Address(RVA = "0x14CC370", Offset = "0x14CC370", VA = "0x7BBBCCC370")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EDE")]
		[Address(RVA = "0x14CC618", Offset = "0x14CC618", VA = "0x7BBBCCC618")]
		public UIMultiPopMenuItemController()
		{
		}

		// Token: 0x04009A69 RID: 39529
		[Token(Token = "0x4009A69")]
		[FieldOffset(Offset = "0x60")]
		private UIMultiPopMenuItemView m_View;

		// Token: 0x04009A6A RID: 39530
		[Token(Token = "0x4009A6A")]
		[FieldOffset(Offset = "0x68")]
		private PopMenuData m_Data;

		// Token: 0x04009A6B RID: 39531
		[Token(Token = "0x4009A6B")]
		[FieldOffset(Offset = "0x70")]
		private MultiPopMenuItemVO m_VO;
	}
}
