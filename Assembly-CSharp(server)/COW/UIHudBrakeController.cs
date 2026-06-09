using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001886 RID: 6278
	[Token(Token = "0x2001886")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4444", Offset = "0x10F4444")]
	internal class UIHudBrakeController : UIHudVehicleButtonBaseController
	{
		// Token: 0x06007C41 RID: 31809 RVA: 0x00022248 File Offset: 0x00020448
		[Token(Token = "0x6007C41")]
		[Address(RVA = "0x189F170", Offset = "0x189F170", VA = "0x7BBC09F170")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C42")]
		[Address(RVA = "0x189F1C0", Offset = "0x189F1C0", VA = "0x7BBC09F1C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C43")]
		[Address(RVA = "0x189F23C", Offset = "0x189F23C", VA = "0x7BBC09F23C", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x00022260 File Offset: 0x00020460
		[Token(Token = "0x6007C44")]
		[Address(RVA = "0x189F284", Offset = "0x189F284", VA = "0x7BBC09F284", Slot = "34")]
		protected override EControlMode ShowInControlMode()
		{
			return EControlMode.Default;
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C45")]
		[Address(RVA = "0x189F28C", Offset = "0x189F28C", VA = "0x7BBC09F28C")]
		public UIHudBrakeController()
		{
		}

		// Token: 0x04009052 RID: 36946
		[Token(Token = "0x4009052")]
		[FieldOffset(Offset = "0x60")]
		private UIHudBrakeView m_View;
	}
}
