using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018CF RID: 6351
	[Token(Token = "0x20018CF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4E84", Offset = "0x10F4E84")]
	internal class UIHudGetOnVehicleAsPassengerController : UIHudGetOnVehicleController
	{
		// Token: 0x06007E86 RID: 32390 RVA: 0x00022980 File Offset: 0x00020B80
		[Token(Token = "0x6007E86")]
		[Address(RVA = "0x1C17258", Offset = "0x1C17258", VA = "0x7BBC417258")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E87")]
		[Address(RVA = "0x1C172A8", Offset = "0x1C172A8", VA = "0x7BBC4172A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007E88")]
		[Address(RVA = "0x1C17320", Offset = "0x1C17320", VA = "0x7BBC417320", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x00022998 File Offset: 0x00020B98
		[Token(Token = "0x6007E89")]
		[Address(RVA = "0x1C17368", Offset = "0x1C17368", VA = "0x7BBC417368", Slot = "35")]
		protected override bool ShouldShow(bool driverEmpty, bool passengerEmpty)
		{
			return default(bool);
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E8A")]
		[Address(RVA = "0x1C17370", Offset = "0x1C17370", VA = "0x7BBC417370")]
		public UIHudGetOnVehicleAsPassengerController()
		{
		}

		// Token: 0x040091CB RID: 37323
		[Token(Token = "0x40091CB")]
		[FieldOffset(Offset = "0x60")]
		private UIHudGetOnVehicleAsPassengerView m_View;
	}
}
