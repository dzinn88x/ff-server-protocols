using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200167D RID: 5757
	[Token(Token = "0x200167D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0364", Offset = "0x10F0364")]
	public class UIHudTokenComboController : UIBaseController
	{
		// Token: 0x06006882 RID: 26754 RVA: 0x0001DA18 File Offset: 0x0001BC18
		[Token(Token = "0x6006882")]
		[Address(RVA = "0x15E63D8", Offset = "0x15E63D8", VA = "0x7BBBDE63D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006883")]
		[Address(RVA = "0x15E6428", Offset = "0x15E6428", VA = "0x7BBBDE6428", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006884")]
		[Address(RVA = "0x15E648C", Offset = "0x15E648C", VA = "0x7BBBDE648C")]
		public void SetUI(string combo, string comboKey = "")
		{
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006885")]
		[Address(RVA = "0x15E6750", Offset = "0x15E6750", VA = "0x7BBBDE6750")]
		public void HideUI()
		{
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006886")]
		[Address(RVA = "0x15E6794", Offset = "0x15E6794", VA = "0x7BBBDE6794")]
		public UIHudTokenComboController()
		{
		}

		// Token: 0x04008549 RID: 34121
		[Token(Token = "0x4008549")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTokenComboView m_View;
	}
}
