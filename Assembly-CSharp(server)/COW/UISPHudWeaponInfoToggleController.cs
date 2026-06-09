using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BA0 RID: 7072
	[Token(Token = "0x2001BA0")]
	public class UISPHudWeaponInfoToggleController : UIBaseController
	{
		// Token: 0x0600989E RID: 39070 RVA: 0x00028320 File Offset: 0x00026520
		[Token(Token = "0x600989E")]
		[Address(RVA = "0x1627590", Offset = "0x1627590", VA = "0x7BBBE27590")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600989F")]
		[Address(RVA = "0x16275E0", Offset = "0x16275E0", VA = "0x7BBBE275E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A0")]
		[Address(RVA = "0x16277D0", Offset = "0x16277D0", VA = "0x7BBBE277D0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A1")]
		[Address(RVA = "0x162789C", Offset = "0x162789C", VA = "0x7BBBE2789C")]
		private void OnHotkeyToggleWeaponInfo(object[] data)
		{
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A2")]
		[Address(RVA = "0x16278A0", Offset = "0x16278A0", VA = "0x7BBBE278A0")]
		private void OnToggleWeaponInfo()
		{
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A3")]
		[Address(RVA = "0x162793C", Offset = "0x162793C", VA = "0x7BBBE2793C")]
		public UISPHudWeaponInfoToggleController()
		{
		}

		// Token: 0x0400A04B RID: 41035
		[Token(Token = "0x400A04B")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudWeaponInfoToggleView m_View;
	}
}
