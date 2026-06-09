using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001712 RID: 5906
	[Token(Token = "0x2001712")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1654", Offset = "0x10F1654")]
	internal class UIClanApplyItemController : UIClanBaseItemController
	{
		// Token: 0x06006E1F RID: 28191 RVA: 0x0001F038 File Offset: 0x0001D238
		[Token(Token = "0x6006E1F")]
		[Address(RVA = "0x1BF82F0", Offset = "0x1BF82F0", VA = "0x7BBC3F82F0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E20")]
		[Address(RVA = "0x1BF8340", Offset = "0x1BF8340", VA = "0x7BBC3F8340", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E21")]
		[Address(RVA = "0x1BF856C", Offset = "0x1BF856C", VA = "0x7BBC3F856C")]
		private void OnHeadClick()
		{
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E22")]
		[Address(RVA = "0x1BF8798", Offset = "0x1BF8798", VA = "0x7BBC3F8798")]
		public UIClanApplyItemController()
		{
		}

		// Token: 0x040088E3 RID: 35043
		[Token(Token = "0x40088E3")]
		[FieldOffset(Offset = "0xE8")]
		private UIClanApplyItemView m_View;
	}
}
