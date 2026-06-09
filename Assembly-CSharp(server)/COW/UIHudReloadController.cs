using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200194C RID: 6476
	[Token(Token = "0x200194C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5F44", Offset = "0x10F5F44")]
	internal class UIHudReloadController : UIHudButtonBaseController
	{
		// Token: 0x06008363 RID: 33635 RVA: 0x00023B08 File Offset: 0x00021D08
		[Token(Token = "0x6008363")]
		[Address(RVA = "0x17F2424", Offset = "0x17F2424", VA = "0x7BBBFF2424")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008364")]
		[Address(RVA = "0x17F2474", Offset = "0x17F2474", VA = "0x7BBBFF2474", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008365 RID: 33637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008365")]
		[Address(RVA = "0x17F24F0", Offset = "0x17F24F0", VA = "0x7BBBFF24F0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008366")]
		[Address(RVA = "0x17F2538", Offset = "0x17F2538", VA = "0x7BBBFF2538")]
		public void ShowWarningTip(bool show)
		{
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008367")]
		[Address(RVA = "0x17F25D8", Offset = "0x17F25D8", VA = "0x7BBBFF25D8")]
		public UIHudReloadController()
		{
		}

		// Token: 0x04009439 RID: 37945
		[Token(Token = "0x4009439")]
		[FieldOffset(Offset = "0x60")]
		private UIHudReloadView m_View;
	}
}
