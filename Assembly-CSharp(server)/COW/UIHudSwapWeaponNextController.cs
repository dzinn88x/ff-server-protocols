using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001968 RID: 6504
	[Token(Token = "0x2001968")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F637C", Offset = "0x10F637C")]
	internal class UIHudSwapWeaponNextController : UIHudButtonBaseController
	{
		// Token: 0x06008449 RID: 33865 RVA: 0x00023E98 File Offset: 0x00022098
		[Token(Token = "0x6008449")]
		[Address(RVA = "0x16755B4", Offset = "0x16755B4", VA = "0x7BBBE755B4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600844A")]
		[Address(RVA = "0x1675604", Offset = "0x1675604", VA = "0x7BBBE75604", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600844B")]
		[Address(RVA = "0x1675680", Offset = "0x1675680", VA = "0x7BBBE75680", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600844C")]
		[Address(RVA = "0x16756C8", Offset = "0x16756C8", VA = "0x7BBBE756C8")]
		public UIHudSwapWeaponNextController()
		{
		}

		// Token: 0x040094AB RID: 38059
		[Token(Token = "0x40094AB")]
		[FieldOffset(Offset = "0x60")]
		private UIHudSwapWeaponNextView m_View;
	}
}
