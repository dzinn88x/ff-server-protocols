using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018CE RID: 6350
	[Token(Token = "0x20018CE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4E4C", Offset = "0x10F4E4C")]
	internal class UIHudGetOnVehicleAsDriverController : UIHudGetOnVehicleController
	{
		// Token: 0x06007E80 RID: 32384 RVA: 0x00022950 File Offset: 0x00020B50
		[Token(Token = "0x6007E80")]
		[Address(RVA = "0x1C16DB0", Offset = "0x1C16DB0", VA = "0x7BBC416DB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E81")]
		[Address(RVA = "0x1C16E00", Offset = "0x1C16E00", VA = "0x7BBC416E00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007E82")]
		[Address(RVA = "0x1C16FA8", Offset = "0x1C16FA8", VA = "0x7BBC416FA8", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x00022968 File Offset: 0x00020B68
		[Token(Token = "0x6007E83")]
		[Address(RVA = "0x1C16FF0", Offset = "0x1C16FF0", VA = "0x7BBC416FF0", Slot = "35")]
		protected override bool ShouldShow(bool driverEmpty, bool passengerEmpty)
		{
			return default(bool);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E84")]
		[Address(RVA = "0x1C16FF8", Offset = "0x1C16FF8", VA = "0x7BBC416FF8", Slot = "34")]
		protected override void OnActionEnter(params object[] param)
		{
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E85")]
		[Address(RVA = "0x1C171A4", Offset = "0x1C171A4", VA = "0x7BBC4171A4")]
		public UIHudGetOnVehicleAsDriverController()
		{
		}

		// Token: 0x040091CA RID: 37322
		[Token(Token = "0x40091CA")]
		[FieldOffset(Offset = "0x60")]
		private UIHudGetOnVehicleAsDriverView m_View;
	}
}
