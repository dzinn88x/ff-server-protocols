using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001967 RID: 6503
	[Token(Token = "0x2001967")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6344", Offset = "0x10F6344")]
	internal class UIHudSwapWeaponController : UIHudButtonBaseController
	{
		// Token: 0x06008445 RID: 33861 RVA: 0x00023E80 File Offset: 0x00022080
		[Token(Token = "0x6008445")]
		[Address(RVA = "0x1675498", Offset = "0x1675498", VA = "0x7BBBE75498")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008446")]
		[Address(RVA = "0x16754E8", Offset = "0x16754E8", VA = "0x7BBBE754E8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008447")]
		[Address(RVA = "0x1675564", Offset = "0x1675564", VA = "0x7BBBE75564", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008448")]
		[Address(RVA = "0x16755AC", Offset = "0x16755AC", VA = "0x7BBBE755AC")]
		public UIHudSwapWeaponController()
		{
		}

		// Token: 0x040094AA RID: 38058
		[Token(Token = "0x40094AA")]
		[FieldOffset(Offset = "0x60")]
		private UIHudSwapWeaponView m_View;
	}
}
