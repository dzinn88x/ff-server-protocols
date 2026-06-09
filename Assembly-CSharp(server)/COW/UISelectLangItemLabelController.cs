using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B7C RID: 7036
	[Token(Token = "0x2001B7C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA2FC", Offset = "0x10FA2FC")]
	public class UISelectLangItemLabelController : UISelectLangItemController
	{
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600979E RID: 38814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A46")]
		protected UILabel m_SelectLabel
		{
			[Token(Token = "0x600979E")]
			[Address(RVA = "0x1630188", Offset = "0x1630188", VA = "0x7BBBE30188")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x0600979F RID: 38815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A47")]
		protected UILabel m_UnSelectLabel
		{
			[Token(Token = "0x600979F")]
			[Address(RVA = "0x16301B4", Offset = "0x16301B4", VA = "0x7BBBE301B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060097A0 RID: 38816 RVA: 0x00027FC0 File Offset: 0x000261C0
		[Token(Token = "0x60097A0")]
		[Address(RVA = "0x16301E0", Offset = "0x16301E0", VA = "0x7BBBE301E0")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060097A1 RID: 38817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A1")]
		[Address(RVA = "0x1630230", Offset = "0x1630230", VA = "0x7BBBE30230", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A2")]
		[Address(RVA = "0x1630314", Offset = "0x1630314", VA = "0x7BBBE30314", Slot = "29")]
		public new virtual void SetData(PopMenuData data, int groupID)
		{
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A3")]
		[Address(RVA = "0x1630494", Offset = "0x1630494", VA = "0x7BBBE30494")]
		public new void RefreshToggleValue()
		{
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A4")]
		[Address(RVA = "0x16304FC", Offset = "0x16304FC", VA = "0x7BBBE304FC")]
		private void OnChange()
		{
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A5")]
		[Address(RVA = "0x1630618", Offset = "0x1630618", VA = "0x7BBBE30618")]
		public UISelectLangItemLabelController()
		{
		}

		// Token: 0x04009FA7 RID: 40871
		[Token(Token = "0x4009FA7")]
		[FieldOffset(Offset = "0x68")]
		private UIToggleItemView m_View;

		// Token: 0x04009FA8 RID: 40872
		[Token(Token = "0x4009FA8")]
		[FieldOffset(Offset = "0x70")]
		private PopMenuData m_Data;
	}
}
