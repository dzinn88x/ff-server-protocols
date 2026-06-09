using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001989 RID: 6537
	[Token(Token = "0x2001989")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F67CC", Offset = "0x10F67CC")]
	internal class UIHudVehicleAutoDriveController : UIHudVehicleButtonBaseController
	{
		// Token: 0x06008550 RID: 34128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008550")]
		[Address(RVA = "0x15EE67C", Offset = "0x15EE67C", VA = "0x7BBBDEE67C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008551 RID: 34129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008551")]
		[Address(RVA = "0x15EE78C", Offset = "0x15EE78C", VA = "0x7BBBDEE78C")]
		private void OnPlayerGetOnVehicle(object[] data)
		{
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008552")]
		[Address(RVA = "0x15EE790", Offset = "0x15EE790", VA = "0x7BBBDEE790", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x00024288 File Offset: 0x00022488
		[Token(Token = "0x6008553")]
		[Address(RVA = "0x15EE85C", Offset = "0x15EE85C", VA = "0x7BBBDEE85C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008554 RID: 34132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008554")]
		[Address(RVA = "0x15EE8AC", Offset = "0x15EE8AC", VA = "0x7BBBDEE8AC", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008555 RID: 34133 RVA: 0x000242A0 File Offset: 0x000224A0
		[Token(Token = "0x6008555")]
		[Address(RVA = "0x15EE8F4", Offset = "0x15EE8F4", VA = "0x7BBBDEE8F4", Slot = "34")]
		protected override EControlMode ShowInControlMode()
		{
			return EControlMode.Default;
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008556")]
		[Address(RVA = "0x15EE8FC", Offset = "0x15EE8FC", VA = "0x7BBBDEE8FC")]
		public UIHudVehicleAutoDriveController()
		{
		}

		// Token: 0x040094FC RID: 38140
		[Token(Token = "0x40094FC")]
		[FieldOffset(Offset = "0x60")]
		private UIHudVehicleAutoDriveView m_View;
	}
}
