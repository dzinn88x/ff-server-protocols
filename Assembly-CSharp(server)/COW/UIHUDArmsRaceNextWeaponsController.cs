using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001426 RID: 5158
	[Token(Token = "0x2001426")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC858", Offset = "0x10EC858")]
	public class UIHUDArmsRaceNextWeaponsController : UIBaseController
	{
		// Token: 0x06005539 RID: 21817 RVA: 0x00019698 File Offset: 0x00017898
		[Token(Token = "0x6005539")]
		[Address(RVA = "0x16B3704", Offset = "0x16B3704", VA = "0x7BBBEB3704")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553A")]
		[Address(RVA = "0x16B3754", Offset = "0x16B3754", VA = "0x7BBBEB3754", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553B")]
		[Address(RVA = "0x16B37B8", Offset = "0x16B37B8", VA = "0x7BBBEB37B8")]
		public void SetData(uint weaponID, int ShowLevel, bool isShowNextArrow)
		{
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553C")]
		[Address(RVA = "0x16B3ACC", Offset = "0x16B3ACC", VA = "0x7BBBEB3ACC")]
		public void HideInfo()
		{
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553D")]
		[Address(RVA = "0x16B3B10", Offset = "0x16B3B10", VA = "0x7BBBEB3B10")]
		public UIHUDArmsRaceNextWeaponsController()
		{
		}

		// Token: 0x04007A43 RID: 31299
		[Token(Token = "0x4007A43")]
		[FieldOffset(Offset = "0x58")]
		private UIHudArmsRaceNextWeaponView m_View;
	}
}
