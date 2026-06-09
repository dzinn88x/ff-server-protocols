using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200196A RID: 6506
	[Token(Token = "0x200196A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F63EC", Offset = "0x10F63EC")]
	internal class UIHudSwapWeaponQuickController : UIHudButtonBaseController
	{
		// Token: 0x06008451 RID: 33873 RVA: 0x00023EC8 File Offset: 0x000220C8
		[Token(Token = "0x6008451")]
		[Address(RVA = "0x1675934", Offset = "0x1675934", VA = "0x7BBBE75934")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008452")]
		[Address(RVA = "0x1675984", Offset = "0x1675984", VA = "0x7BBBE75984", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008453")]
		[Address(RVA = "0x16759CC", Offset = "0x16759CC", VA = "0x7BBBE759CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008454")]
		[Address(RVA = "0x1675ACC", Offset = "0x1675ACC", VA = "0x7BBBE75ACC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008455")]
		[Address(RVA = "0x1675B98", Offset = "0x1675B98", VA = "0x7BBBE75B98", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008456")]
		[Address(RVA = "0x1675C94", Offset = "0x1675C94", VA = "0x7BBBE75C94")]
		private void OnHudSettingChange(params object[] param)
		{
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008457")]
		[Address(RVA = "0x1675BC8", Offset = "0x1675BC8", VA = "0x7BBBE75BC8")]
		private void UpdateShowTiming()
		{
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008458")]
		[Address(RVA = "0x1675C34", Offset = "0x1675C34", VA = "0x7BBBE75C34")]
		private void UpdateShowHide()
		{
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008459")]
		[Address(RVA = "0x1675CB8", Offset = "0x1675CB8", VA = "0x7BBBE75CB8")]
		public UIHudSwapWeaponQuickController()
		{
		}

		// Token: 0x040094AD RID: 38061
		[Token(Token = "0x40094AD")]
		[FieldOffset(Offset = "0x60")]
		private UIHudSwapWeaponQuickView m_View;

		// Token: 0x040094AE RID: 38062
		[Token(Token = "0x40094AE")]
		[FieldOffset(Offset = "0x68")]
		private EChangeWeaponSetting m_Setting;
	}
}
