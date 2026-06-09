using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200198E RID: 6542
	[Token(Token = "0x200198E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F68E4", Offset = "0x10F68E4")]
	public class UIHUDVehicleLevelUpTipController : UIBaseController
	{
		// Token: 0x06008579 RID: 34169 RVA: 0x00024330 File Offset: 0x00022530
		[Token(Token = "0x6008579")]
		[Address(RVA = "0x1D52784", Offset = "0x1D52784", VA = "0x7BBC552784")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600857A")]
		[Address(RVA = "0x1D527D4", Offset = "0x1D527D4", VA = "0x7BBC5527D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600857B")]
		[Address(RVA = "0x1D528B8", Offset = "0x1D528B8", VA = "0x7BBC5528B8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600857C RID: 34172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600857C")]
		[Address(RVA = "0x1D52984", Offset = "0x1D52984", VA = "0x7BBC552984")]
		private void OnLocalVehcleLevelUp(object[] data)
		{
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600857D")]
		[Address(RVA = "0x1D52BD0", Offset = "0x1D52BD0", VA = "0x7BBC552BD0")]
		public UIHUDVehicleLevelUpTipController()
		{
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600857E")]
		[Address(RVA = "0x1D52BD8", Offset = "0x1D52BD8", VA = "0x7BBC552BD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143458", Offset = "0x1143458")]
		private void <OnLocalVehcleLevelUp>b__5_0()
		{
		}

		// Token: 0x04009505 RID: 38149
		[Token(Token = "0x4009505")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDVehicleLevelUpTipView m_View;

		// Token: 0x04009506 RID: 38150
		[Token(Token = "0x4009506")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallCD;
	}
}
