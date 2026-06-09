using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001986 RID: 6534
	[Token(Token = "0x2001986")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F675C", Offset = "0x10F675C")]
	internal class UIHudTurnRightController : UIHudVehicleButtonBaseController
	{
		// Token: 0x0600853C RID: 34108 RVA: 0x00024240 File Offset: 0x00022440
		[Token(Token = "0x600853C")]
		[Address(RVA = "0x15ED4E8", Offset = "0x15ED4E8", VA = "0x7BBBDED4E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600853D")]
		[Address(RVA = "0x15ED538", Offset = "0x15ED538", VA = "0x7BBBDED538", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600853E")]
		[Address(RVA = "0x15ED5B0", Offset = "0x15ED5B0", VA = "0x7BBBDED5B0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x00024258 File Offset: 0x00022458
		[Token(Token = "0x600853F")]
		[Address(RVA = "0x15ED5F8", Offset = "0x15ED5F8", VA = "0x7BBBDED5F8", Slot = "34")]
		protected override EControlMode ShowInControlMode()
		{
			return EControlMode.Default;
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008540")]
		[Address(RVA = "0x15ED600", Offset = "0x15ED600", VA = "0x7BBBDED600")]
		public UIHudTurnRightController()
		{
		}

		// Token: 0x040094F8 RID: 38136
		[Token(Token = "0x40094F8")]
		[FieldOffset(Offset = "0x60")]
		private UIHudTurnRightView m_View;
	}
}
