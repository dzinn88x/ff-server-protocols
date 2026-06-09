using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014F6 RID: 5366
	[Token(Token = "0x20014F6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDDEC", Offset = "0x10EDDEC")]
	public class UIEPDebrisProcessController : UIBaseController
	{
		// Token: 0x06005C00 RID: 23552 RVA: 0x0001AD48 File Offset: 0x00018F48
		[Token(Token = "0x6005C00")]
		[Address(RVA = "0x2214520", Offset = "0x2214520", VA = "0x7BBCA14520")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C01")]
		[Address(RVA = "0x2214570", Offset = "0x2214570", VA = "0x7BBCA14570", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C02")]
		[Address(RVA = "0x22147D4", Offset = "0x22147D4", VA = "0x7BBCA147D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C03")]
		[Address(RVA = "0x22146CC", Offset = "0x22146CC", VA = "0x7BBCA146CC")]
		private void InitData()
		{
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C04")]
		[Address(RVA = "0x22148BC", Offset = "0x22148BC", VA = "0x7BBCA148BC")]
		public void RefreshData()
		{
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C05")]
		[Address(RVA = "0x2214A7C", Offset = "0x2214A7C", VA = "0x7BBCA14A7C")]
		private void OnEpLevelUpdate(params object[] data)
		{
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C06")]
		[Address(RVA = "0x2214A80", Offset = "0x2214A80", VA = "0x7BBCA14A80")]
		public UIEPDebrisProcessController()
		{
		}

		// Token: 0x04007E48 RID: 32328
		[Token(Token = "0x4007E48")]
		[FieldOffset(Offset = "0x58")]
		private UIEPDebrisProcessView m_View;

		// Token: 0x04007E49 RID: 32329
		[Token(Token = "0x4007E49")]
		[FieldOffset(Offset = "0x60")]
		private UIModelElitePass m_Model;
	}
}
