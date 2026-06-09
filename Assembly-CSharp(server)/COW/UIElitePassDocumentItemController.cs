using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014E9 RID: 5353
	[Token(Token = "0x20014E9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDC0C", Offset = "0x10EDC0C")]
	public class UIElitePassDocumentItemController : UIEasyListItemController
	{
		// Token: 0x06005B92 RID: 23442 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		[Token(Token = "0x6005B92")]
		[Address(RVA = "0x1AE7654", Offset = "0x1AE7654", VA = "0x7BBC2E7654")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B93")]
		[Address(RVA = "0x1AE76A4", Offset = "0x1AE76A4", VA = "0x7BBC2E76A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B94")]
		[Address(RVA = "0x1AE7708", Offset = "0x1AE7708", VA = "0x7BBC2E7708", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B95")]
		[Address(RVA = "0x1AE7ACC", Offset = "0x1AE7ACC", VA = "0x7BBC2E7ACC")]
		public UIElitePassDocumentItemController()
		{
		}

		// Token: 0x04007E11 RID: 32273
		[Token(Token = "0x4007E11")]
		[FieldOffset(Offset = "0x70")]
		private UIElitePassDocumentItemView m_View;
	}
}
