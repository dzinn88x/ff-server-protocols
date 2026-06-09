using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200198F RID: 6543
	[Token(Token = "0x200198F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F691C", Offset = "0x10F691C")]
	internal class UIHudVehicleResetController : UIHudButtonBaseController
	{
		// Token: 0x0600857F RID: 34175 RVA: 0x00024348 File Offset: 0x00022548
		[Token(Token = "0x600857F")]
		[Address(RVA = "0x15F0D30", Offset = "0x15F0D30", VA = "0x7BBBDF0D30")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008580")]
		[Address(RVA = "0x15F0D80", Offset = "0x15F0D80", VA = "0x7BBBDF0D80", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008581")]
		[Address(RVA = "0x15F0DC8", Offset = "0x15F0DC8", VA = "0x7BBBDF0DC8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008582")]
		[Address(RVA = "0x15F0FFC", Offset = "0x15F0FFC", VA = "0x7BBBDF0FFC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008583")]
		[Address(RVA = "0x15F111C", Offset = "0x15F111C", VA = "0x7BBBDF111C")]
		private void Update()
		{
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008584")]
		[Address(RVA = "0x15F123C", Offset = "0x15F123C", VA = "0x7BBBDF123C")]
		private void OnTryReset()
		{
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008585")]
		[Address(RVA = "0x15F1574", Offset = "0x15F1574", VA = "0x7BBBDF1574")]
		private void OnPlayerGetOnVehicle(params object[] ps)
		{
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008586")]
		[Address(RVA = "0x15F16A4", Offset = "0x15F16A4", VA = "0x7BBBDF16A4")]
		private void OnPlayerGetOffVehicle(params object[] ps)
		{
		}

		// Token: 0x06008587 RID: 34183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008587")]
		[Address(RVA = "0x15F17EC", Offset = "0x15F17EC", VA = "0x7BBBDF17EC")]
		public UIHudVehicleResetController()
		{
		}

		// Token: 0x04009507 RID: 38151
		[Token(Token = "0x4009507")]
		[FieldOffset(Offset = "0x60")]
		private UIHudVehicleResetView m_View;

		// Token: 0x04009508 RID: 38152
		[Token(Token = "0x4009508")]
		[FieldOffset(Offset = "0x68")]
		private Vehicle m_Vehicle;

		// Token: 0x04009509 RID: 38153
		[Token(Token = "0x4009509")]
		[FieldOffset(Offset = "0x70")]
		private float m_ResetTime;

		// Token: 0x0400950A RID: 38154
		[Token(Token = "0x400950A")]
		[FieldOffset(Offset = "0x74")]
		private float m_ResetVal;
	}
}
