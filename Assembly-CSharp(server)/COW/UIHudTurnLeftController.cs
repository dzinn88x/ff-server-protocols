using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001985 RID: 6533
	[Token(Token = "0x2001985")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6724", Offset = "0x10F6724")]
	internal class UIHudTurnLeftController : UIHudVehicleButtonBaseController
	{
		// Token: 0x06008537 RID: 34103 RVA: 0x00024210 File Offset: 0x00022410
		[Token(Token = "0x6008537")]
		[Address(RVA = "0x15ED1F0", Offset = "0x15ED1F0", VA = "0x7BBBDED1F0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008538")]
		[Address(RVA = "0x15ED240", Offset = "0x15ED240", VA = "0x7BBBDED240", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008539")]
		[Address(RVA = "0x15ED390", Offset = "0x15ED390", VA = "0x7BBBDED390", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x00024228 File Offset: 0x00022428
		[Token(Token = "0x600853A")]
		[Address(RVA = "0x15ED3D8", Offset = "0x15ED3D8", VA = "0x7BBBDED3D8", Slot = "34")]
		protected override EControlMode ShowInControlMode()
		{
			return EControlMode.Default;
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600853B")]
		[Address(RVA = "0x15ED3E0", Offset = "0x15ED3E0", VA = "0x7BBBDED3E0")]
		public UIHudTurnLeftController()
		{
		}

		// Token: 0x040094F7 RID: 38135
		[Token(Token = "0x40094F7")]
		[FieldOffset(Offset = "0x60")]
		private UIHudTurnLeftView m_View;
	}
}
