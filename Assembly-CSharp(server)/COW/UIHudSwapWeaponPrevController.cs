using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001969 RID: 6505
	[Token(Token = "0x2001969")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F63B4", Offset = "0x10F63B4")]
	internal class UIHudSwapWeaponPrevController : UIHudButtonBaseController
	{
		// Token: 0x0600844D RID: 33869 RVA: 0x00023EB0 File Offset: 0x000220B0
		[Token(Token = "0x600844D")]
		[Address(RVA = "0x1675774", Offset = "0x1675774", VA = "0x7BBBE75774")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600844E")]
		[Address(RVA = "0x16757C4", Offset = "0x16757C4", VA = "0x7BBBE757C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600844F")]
		[Address(RVA = "0x1675840", Offset = "0x1675840", VA = "0x7BBBE75840", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008450")]
		[Address(RVA = "0x1675888", Offset = "0x1675888", VA = "0x7BBBE75888")]
		public UIHudSwapWeaponPrevController()
		{
		}

		// Token: 0x040094AC RID: 38060
		[Token(Token = "0x40094AC")]
		[FieldOffset(Offset = "0x60")]
		private UIHudSwapWeaponPrevView m_View;
	}
}
