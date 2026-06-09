using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200198A RID: 6538
	[Token(Token = "0x200198A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6804", Offset = "0x10F6804")]
	internal class UIHudVehicleBoostController : UIHudVehicleItemButtonController
	{
		// Token: 0x06008557 RID: 34135 RVA: 0x000242B8 File Offset: 0x000224B8
		[Token(Token = "0x6008557")]
		[Address(RVA = "0x15EE9A8", Offset = "0x15EE9A8", VA = "0x7BBBDEE9A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008558")]
		[Address(RVA = "0x15EE9F8", Offset = "0x15EE9F8", VA = "0x7BBBDEE9F8", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008559")]
		[Address(RVA = "0x15EEA40", Offset = "0x15EEA40", VA = "0x7BBBDEEA40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600855A")]
		[Address(RVA = "0x15EECE4", Offset = "0x15EECE4", VA = "0x7BBBDEECE4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600855B")]
		[Address(RVA = "0x15EEF2C", Offset = "0x15EEF2C", VA = "0x7BBBDEEF2C")]
		private void OnDriverAiming(params object[] param)
		{
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600855C")]
		[Address(RVA = "0x15EF0E8", Offset = "0x15EF0E8", VA = "0x7BBBDEF0E8", Slot = "34")]
		protected override void OnPlayerGetOnVehicle(params object[] ps)
		{
		}

		// Token: 0x0600855D RID: 34141 RVA: 0x000242D0 File Offset: 0x000224D0
		[Token(Token = "0x600855D")]
		[Address(RVA = "0x15EF0F4", Offset = "0x15EF0F4", VA = "0x7BBBDEF0F4", Slot = "35")]
		protected override bool ShouldHide()
		{
			return default(bool);
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600855E")]
		[Address(RVA = "0x15EF0FC", Offset = "0x15EF0FC", VA = "0x7BBBDEF0FC")]
		public UIHudVehicleBoostController()
		{
		}

		// Token: 0x040094FD RID: 38141
		[Token(Token = "0x40094FD")]
		[FieldOffset(Offset = "0x70")]
		private UIHudVehicleBoostView m_View;

		// Token: 0x040094FE RID: 38142
		[Token(Token = "0x40094FE")]
		[FieldOffset(Offset = "0x78")]
		private bool m_DriverAiming;
	}
}
